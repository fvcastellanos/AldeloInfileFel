
namespace AldeloInfileFel
{
    partial class frmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edNit = new System.Windows.Forms.TextBox();
            this.edNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.edResultado = new System.Windows.Forms.TextBox();
            this.edOrden = new System.Windows.Forms.NumericUpDown();
            this.pnBrowser = new System.Windows.Forms.Panel();
            this.gbFelStatus = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.lbCertificate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSignature = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApiStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmApiStatus = new System.Windows.Forms.Timer(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edOrden)).BeginInit();
            this.gbFelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Orden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nit:";
            // 
            // edNit
            // 
            this.edNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNit.Location = new System.Drawing.Point(115, 110);
            this.edNit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edNit.Name = "edNit";
            this.edNit.Size = new System.Drawing.Size(275, 30);
            this.edNit.TabIndex = 10;
            // 
            // edNombre
            // 
            this.edNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNombre.Location = new System.Drawing.Point(115, 162);
            this.edNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edNombre.Name = "edNombre";
            this.edNombre.Size = new System.Drawing.Size(505, 30);
            this.edNombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // edCorreo
            // 
            this.edCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edCorreo.Location = new System.Drawing.Point(115, 215);
            this.edCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edCorreo.Name = "edCorreo";
            this.edCorreo.Size = new System.Drawing.Size(505, 30);
            this.edCorreo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(444, 103);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(177, 48);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(668, 64);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(219, 48);
            this.btnGenerar.TabIndex = 40;
            this.btnGenerar.Text = "Generar Factura";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(669, 119);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 48);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // edResultado
            // 
            this.edResultado.Location = new System.Drawing.Point(39, 263);
            this.edResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edResultado.Multiline = true;
            this.edResultado.Name = "edResultado";
            this.edResultado.ReadOnly = true;
            this.edResultado.Size = new System.Drawing.Size(848, 118);
            this.edResultado.TabIndex = 61;
            this.edResultado.TabStop = false;
            // 
            // edOrden
            // 
            this.edOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edOrden.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.edOrden.Location = new System.Drawing.Point(120, 68);
            this.edOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edOrden.Maximum = new decimal(new int[] {
            1084293119,
            -1718009309,
            429496729,
            0});
            this.edOrden.Name = "edOrden";
            this.edOrden.Size = new System.Drawing.Size(160, 30);
            this.edOrden.TabIndex = 5;
            // 
            // pnBrowser
            // 
            this.pnBrowser.Location = new System.Drawing.Point(39, 396);
            this.pnBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnBrowser.Name = "pnBrowser";
            this.pnBrowser.Size = new System.Drawing.Size(848, 416);
            this.pnBrowser.TabIndex = 62;
            // 
            // gbFelStatus
            // 
            this.gbFelStatus.Controls.Add(this.btnInfo);
            this.gbFelStatus.Controls.Add(this.btnStatus);
            this.gbFelStatus.Controls.Add(this.lbCertificate);
            this.gbFelStatus.Controls.Add(this.label7);
            this.gbFelStatus.Controls.Add(this.lbSignature);
            this.gbFelStatus.Controls.Add(this.label6);
            this.gbFelStatus.Controls.Add(this.lbApiStatus);
            this.gbFelStatus.Controls.Add(this.label5);
            this.gbFelStatus.Location = new System.Drawing.Point(16, 6);
            this.gbFelStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFelStatus.Name = "gbFelStatus";
            this.gbFelStatus.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFelStatus.Size = new System.Drawing.Size(892, 54);
            this.gbFelStatus.TabIndex = 63;
            this.gbFelStatus.TabStop = false;
            this.gbFelStatus.Text = "Estado FEL";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(771, 14);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 28);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(489, 14);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(100, 28);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "Estado";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // lbCertificate
            // 
            this.lbCertificate.AutoSize = true;
            this.lbCertificate.Location = new System.Drawing.Point(424, 20);
            this.lbCertificate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCertificate.Name = "lbCertificate";
            this.lbCertificate.Size = new System.Drawing.Size(27, 17);
            this.lbCertificate.TabIndex = 5;
            this.lbCertificate.Text = "UP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Certificación InFile:";
            // 
            // lbSignature
            // 
            this.lbSignature.AutoSize = true;
            this.lbSignature.Location = new System.Drawing.Point(244, 20);
            this.lbSignature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSignature.Name = "lbSignature";
            this.lbSignature.Size = new System.Drawing.Size(27, 17);
            this.lbSignature.TabIndex = 3;
            this.lbSignature.Text = "UP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Firma InFile:";
            // 
            // lbApiStatus
            // 
            this.lbApiStatus.AutoSize = true;
            this.lbApiStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbApiStatus.Location = new System.Drawing.Point(84, 20);
            this.lbApiStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApiStatus.Name = "lbApiStatus";
            this.lbApiStatus.Size = new System.Drawing.Size(27, 17);
            this.lbApiStatus.TabIndex = 1;
            this.lbApiStatus.Text = "UP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "API Fel:";
            // 
            // tmApiStatus
            // 
            this.tmApiStatus.Enabled = true;
            this.tmApiStatus.Interval = 300000;
            this.tmApiStatus.Tag = "";
            this.tmApiStatus.Tick += new System.EventHandler(this.tmApiStatus_Tick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(669, 175);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(219, 48);
            this.btnImprimir.TabIndex = 64;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 672);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbFelStatus);
            this.Controls.Add(this.pnBrowser);
            this.Controls.Add(this.edOrden);
            this.Controls.Add(this.edResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edNombre);
            this.Controls.Add(this.edNit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Factura";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edOrden)).EndInit();
            this.gbFelStatus.ResumeLayout(false);
            this.gbFelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edNit;
        private System.Windows.Forms.TextBox edNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox edResultado;
        private System.Windows.Forms.NumericUpDown edOrden;
        private System.Windows.Forms.Panel pnBrowser;
        private System.Windows.Forms.GroupBox gbFelStatus;
        private System.Windows.Forms.Label lbSignature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbApiStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCertificate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmApiStatus;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnImprimir;
    }
}

