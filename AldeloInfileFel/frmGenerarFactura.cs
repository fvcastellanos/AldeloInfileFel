using AldeloInfileFel.Domain;
using AldeloInfileFel.Repositories;
using AldeloInfileFel.Services;
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.WinForms;
using Spire.Pdf;

namespace AldeloInfileFel
{
    public partial class frmInvoice : Form
    {
        private const string DownStatus = "DOWN";
        private readonly InvoiceService _invoiceService;
        private readonly ChromiumWebBrowser _browser;
        private readonly Configuration _configuration;
        private List<string> _generatedUUIDList;

        public frmInvoice()
        {
            InitializeComponent();

            _browser = new ChromiumWebBrowser("about:blank");
            _browser.Dock = DockStyle.Fill;

            var tokenService = new TokenService(new TokenRepository());
            _invoiceService = new InvoiceService(new OrderRepository(), tokenService);
            _configuration = ConfigurationService.LoadConfiguration();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            rbCF.Checked = true;
            edOrden.Value = 0;
            edNit.Text = "CF";
            edNombre.Text = "";
            edCorreo.Text = "";
            edResultado.Text = "";
            _browser.Load("about:blank");
            edNit.Focus();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (!validateData()) return;

            btnGenerar.Enabled = false;
            btnPrintInvoice.Enabled = false;
            edResultado.Text = "";

            if (string.IsNullOrEmpty(edNombre.Text))
            {
                edNombre.Text = _invoiceService.QueryTaxId(edNit.Text);

            }

            var consumerData = new ConsumerData
            {
                OrderId = long.Parse(edOrden.Text),
                TaxId = edNit.Text,
                TaxIdType = BuildTaxIdType(),
                Name = edNombre.Text,
                Email = edCorreo.Text
            };

            var result = _invoiceService.GenerateInvoice(consumerData);

            if (result.Success)
            {
                PresentarResultado(result.Invoices);
                btnGenerar.Enabled = true;
                btnPrintInvoice.Enabled = true;

                return;
            }

            PresentarError(result.Errors);

            btnGenerar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PresentarError(IEnumerable<string> errores)
        {
            var mensaje = new StringBuilder();

            foreach (var error in errores)
            {
                mensaje.AppendLine(error);
            }

            edResultado.Text = mensaje.ToString();
        }

        private void PresentarResultado(IEnumerable<InvoiceInformation> invoicesInformation)
        {
            var builder = new StringBuilder();

            var invoiceInformationList = invoicesInformation.ToList();

            invoiceInformationList.ForEach(invoiceInformation =>
            {
                builder.AppendLine("Tipo Factura: " + invoiceInformation.Type);
                builder.AppendLine("UUID: " + invoiceInformation.UUID);
                builder.AppendLine("Fecha certificacion: " + invoiceInformation.Date);
                builder.AppendLine("Correlativo: " + invoiceInformation.Correlative);
                builder.AppendLine("Origen: " + invoiceInformation.Origin);
                builder.AppendLine("\n\n");
            });

            var invoices = invoicesInformation.Select(invoiceInformation => invoiceInformation.UUID)
                .ToList();

            edResultado.Text = builder.ToString();
            _generatedUUIDList = invoices;
        }

        private void ObtenerOrden()
        {
            var argumentos = Environment.GetCommandLineArgs();

            if (argumentos.Length > 0)
            {
                if (argumentos.ToList().Contains("readonly"))
                    edOrden.Enabled = false;

                var orden = argumentos.ToList()
                    .FirstOrDefault<string>(arg => arg.Contains("OrderId"));

                if (orden != null)
                {
                    var valores = orden.Split('=');

                    if (valores.Length == 2)
                    {
                        edOrden.Text = valores[1];
                    }
                }
            }
        }

        private void ImprimirFactura(string UUID)
        {
            var url = _configuration.PreviewUrl.Replace("#value", UUID);
            var tempFile = Path.GetTempFileName();

            var webClient = new WebClient();
            webClient.DownloadFile(url, tempFile);

            var pdfDocument = new PdfDocument();
            pdfDocument.LoadFromFile(tempFile);
            pdfDocument.Print();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            ObtenerOrden();
            ShowApiStatus();
        }

        private void ShowApiStatus()
        {
            var status = _invoiceService.GetApiStatus();

            lbApiStatus.ForeColor = System.Drawing.Color.DarkGreen;
            lbSignature.ForeColor = System.Drawing.Color.DarkGreen;
            lbCertificate.ForeColor = System.Drawing.Color.DarkGreen;

            lbApiStatus.Text = status.Status;
            lbSignature.Text = status.Components.InFile.Details.Signature;
            lbCertificate.Text = status.Components.InFile.Details.Certificate;

            if (DownStatus.Equals(lbApiStatus.Text))
            {
                lbApiStatus.ForeColor = System.Drawing.Color.Red;
            }

            if (DownStatus.Equals(lbSignature.Text))
            {
                lbSignature.ForeColor = System.Drawing.Color.Red;
            }

            if (DownStatus.Equals(lbCertificate.Text))
            {
                lbCertificate.ForeColor = System.Drawing.Color.Red;
            }

        }

        private bool validateData()
        {
            if (string.IsNullOrEmpty(edNit.Text) && rbNit.Checked)
            {
                MessageBox.Show("Debe ingresar un número de NIT");
                edNit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(edNit.Text) && rbCui.Checked)
            {
                MessageBox.Show("Debe ingresar un número de CUI");
                edNit.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(edNit.Text) && rbExt.Checked)
            {
                MessageBox.Show("Debe ingresar un número de Pasaporte");
                edNit.Focus();
                return false;
            }

            if (edOrden.Value == 0)
            {
                MessageBox.Show("Debe ingresar un No. de Orden");
                edOrden.Focus();
                return false;
            }

            return true;
        }


        private void tmApiStatus_Tick(object sender, EventArgs e)
        {
            ShowApiStatus();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ShowApiStatus();
        }

        private void edNit_Leave(object sender, EventArgs e)
        {
            if (rbNit.Checked && !string.IsNullOrEmpty(edNit.Text))
            {
                edNombre.Text = _invoiceService.QueryTaxId(edNit.Text);
                return;
            }

            if (rbCui.Checked && !string.IsNullOrEmpty(edNit.Text))
            {
                edNombre.Text = _invoiceService.QueryId(edNit.Text);
                return;
            }
        }

        private void rbCui_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCui.Checked)
            {
                lbConsumer.Text = "CUI:";
                edNit.Text = "";
                edNombre.Text = "";
            }
        }

        private void rbCF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCF.Checked)
            {
                lbConsumer.Text = "NIT:";
                edNit.Text = "CF";
                edNombre.Text = "CONSUMIDOR FINAL";
            }
        }

        private void rbNit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNit.Checked)
            {
                lbConsumer.Text = "NIT:";
                edNit.Text = "";
                edNombre.Text = "";
            }
        }

        private void rbExt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExt.Checked)
            {
                lbConsumer.Text = "Pasaporte:";
                edNit.Text = "";
                edNombre.Text = "";
            }
        }

        private string BuildTaxIdType()
        {
            if (rbCui.Checked) return "CUI";

            if (rbExt.Checked) return "EXT";

            // For CF or NIT
            return "";
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (_generatedUUIDList != null)
            {
                _generatedUUIDList.ForEach(ImprimirFactura);
            }
        }
    }
}
