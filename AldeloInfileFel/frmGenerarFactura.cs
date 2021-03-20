﻿using AldeloInfileFel.Domain;
using AldeloInfileFel.Repositories;
using AldeloInfileFel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldeloInfileFel
{
    public partial class frmInvoice : Form
    {
        private InvoiceService _invoiceService;

        public frmInvoice()
        {
            InitializeComponent();

            _invoiceService = new InvoiceService(new OrderRepository());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            edOrden.Value = 0;
            edNit.Text = "";
            edNombre.Text = "";
            edCorreo.Text = "";
            edResultado.Text = "";
            edNit.Focus();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (edOrden.Value == 0)
            {
                MessageBox.Show("Debe ingresar un No. de Orden");
                edOrden.Focus();
                return;
            }

            edResultado.Text = "";

            var noOrden = long.Parse(edOrden.Text);
            var result = _invoiceService.GenerateInvoice(noOrden, edNit.Text, edNombre.Text, edCorreo.Text);

            if (result.Success)
            {
                PresentarResultado(result.InvoiceInformation);
                return;
            }

            PresentarError(result.Errors);
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

        private void PresentarResultado(InvoiceInformation invoiceInformation)
        {
            var builder = new StringBuilder();

            builder.AppendLine("UUID: " + invoiceInformation.UUID);
            builder.AppendLine("Fecha certificacion: " + invoiceInformation.Date);
            builder.AppendLine("Correlativo: " + invoiceInformation.Correlative);
            builder.AppendLine("Origen: " + invoiceInformation.Origin);

            edResultado.Text = builder.ToString();
        }

        private void ObtenerOrden()
        {
            var argumentos = Environment.GetCommandLineArgs();

            if (argumentos.Length > 0)
            {
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

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            ObtenerOrden();
        }
    }
}
