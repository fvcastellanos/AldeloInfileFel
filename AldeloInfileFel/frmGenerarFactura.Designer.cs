﻿
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
            this.lbConsumer = new System.Windows.Forms.Label();
            this.edNit = new System.Windows.Forms.TextBox();
            this.edNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.edResultado = new System.Windows.Forms.TextBox();
            this.edOrden = new System.Windows.Forms.NumericUpDown();
            this.pnBrowser = new System.Windows.Forms.Panel();
            this.gbFelStatus = new System.Windows.Forms.GroupBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.lbCertificate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSignature = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApiStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmApiStatus = new System.Windows.Forms.Timer(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbCF = new System.Windows.Forms.RadioButton();
            this.rbNit = new System.Windows.Forms.RadioButton();
            this.rbCui = new System.Windows.Forms.RadioButton();
            this.rbExt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.edOrden)).BeginInit();
            this.gbFelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Orden:";
            // 
            // lbConsumer
            // 
            this.lbConsumer.AutoSize = true;
            this.lbConsumer.Location = new System.Drawing.Point(25, 157);
            this.lbConsumer.Name = "lbConsumer";
            this.lbConsumer.Size = new System.Drawing.Size(28, 13);
            this.lbConsumer.TabIndex = 2;
            this.lbConsumer.Text = "NIT:";
            // 
            // edNit
            // 
            this.edNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNit.Location = new System.Drawing.Point(85, 149);
            this.edNit.Name = "edNit";
            this.edNit.Size = new System.Drawing.Size(207, 26);
            this.edNit.TabIndex = 10;
            this.edNit.Text = "CF";
            this.edNit.Leave += new System.EventHandler(this.edNit_Leave);
            // 
            // edNombre
            // 
            this.edNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNombre.Location = new System.Drawing.Point(85, 192);
            this.edNombre.Name = "edNombre";
            this.edNombre.Size = new System.Drawing.Size(380, 26);
            this.edNombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // edCorreo
            // 
            this.edCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edCorreo.Location = new System.Drawing.Point(85, 235);
            this.edCorreo.Name = "edCorreo";
            this.edCorreo.Size = new System.Drawing.Size(380, 26);
            this.edCorreo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(332, 144);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 39);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(507, 144);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(164, 106);
            this.btnGenerar.TabIndex = 40;
            this.btnGenerar.Text = "Generar Factura";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // edResultado
            // 
            this.edResultado.Location = new System.Drawing.Point(28, 274);
            this.edResultado.Multiline = true;
            this.edResultado.Name = "edResultado";
            this.edResultado.ReadOnly = true;
            this.edResultado.Size = new System.Drawing.Size(637, 78);
            this.edResultado.TabIndex = 110;
            this.edResultado.TabStop = false;
            // 
            // edOrden
            // 
            this.edOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edOrden.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.edOrden.Location = new System.Drawing.Point(90, 55);
            this.edOrden.Maximum = new decimal(new int[] {
            1084293119,
            -1718009309,
            429496729,
            0});
            this.edOrden.Name = "edOrden";
            this.edOrden.Size = new System.Drawing.Size(120, 26);
            this.edOrden.TabIndex = 5;
            // 
            // pnBrowser
            // 
            this.pnBrowser.Location = new System.Drawing.Point(28, 406);
            this.pnBrowser.Name = "pnBrowser";
            this.pnBrowser.Size = new System.Drawing.Size(638, 154);
            this.pnBrowser.TabIndex = 120;
            // 
            // gbFelStatus
            // 
            this.gbFelStatus.Controls.Add(this.btnStatus);
            this.gbFelStatus.Controls.Add(this.lbCertificate);
            this.gbFelStatus.Controls.Add(this.label7);
            this.gbFelStatus.Controls.Add(this.lbSignature);
            this.gbFelStatus.Controls.Add(this.label6);
            this.gbFelStatus.Controls.Add(this.lbApiStatus);
            this.gbFelStatus.Controls.Add(this.label5);
            this.gbFelStatus.Location = new System.Drawing.Point(12, 5);
            this.gbFelStatus.Name = "gbFelStatus";
            this.gbFelStatus.Size = new System.Drawing.Size(654, 44);
            this.gbFelStatus.TabIndex = 63;
            this.gbFelStatus.TabStop = false;
            this.gbFelStatus.Text = "Estado FEL";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(367, 11);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 100;
            this.btnStatus.Text = "Estado";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // lbCertificate
            // 
            this.lbCertificate.AutoSize = true;
            this.lbCertificate.Location = new System.Drawing.Point(318, 16);
            this.lbCertificate.Name = "lbCertificate";
            this.lbCertificate.Size = new System.Drawing.Size(22, 13);
            this.lbCertificate.TabIndex = 5;
            this.lbCertificate.Text = "UP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Certificación InFile:";
            // 
            // lbSignature
            // 
            this.lbSignature.AutoSize = true;
            this.lbSignature.Location = new System.Drawing.Point(183, 16);
            this.lbSignature.Name = "lbSignature";
            this.lbSignature.Size = new System.Drawing.Size(22, 13);
            this.lbSignature.TabIndex = 3;
            this.lbSignature.Text = "UP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Firma InFile:";
            // 
            // lbApiStatus
            // 
            this.lbApiStatus.AutoSize = true;
            this.lbApiStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbApiStatus.Location = new System.Drawing.Point(63, 16);
            this.lbApiStatus.Name = "lbApiStatus";
            this.lbApiStatus.Size = new System.Drawing.Size(22, 13);
            this.lbApiStatus.TabIndex = 1;
            this.lbApiStatus.Text = "UP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
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
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(501, 358);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(164, 40);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "Reimprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(28, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 40);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbCF
            // 
            this.rbCF.AutoSize = true;
            this.rbCF.Checked = true;
            this.rbCF.Location = new System.Drawing.Point(28, 106);
            this.rbCF.Name = "rbCF";
            this.rbCF.Size = new System.Drawing.Size(38, 17);
            this.rbCF.TabIndex = 6;
            this.rbCF.TabStop = true;
            this.rbCF.Text = "CF";
            this.rbCF.UseVisualStyleBackColor = true;
            this.rbCF.CheckedChanged += new System.EventHandler(this.rbCF_CheckedChanged);
            // 
            // rbNit
            // 
            this.rbNit.AutoSize = true;
            this.rbNit.Location = new System.Drawing.Point(125, 106);
            this.rbNit.Name = "rbNit";
            this.rbNit.Size = new System.Drawing.Size(43, 17);
            this.rbNit.TabIndex = 7;
            this.rbNit.TabStop = true;
            this.rbNit.Text = "NIT";
            this.rbNit.UseVisualStyleBackColor = true;
            this.rbNit.CheckedChanged += new System.EventHandler(this.rbNit_CheckedChanged);
            // 
            // rbCui
            // 
            this.rbCui.AutoSize = true;
            this.rbCui.Location = new System.Drawing.Point(332, 106);
            this.rbCui.Name = "rbCui";
            this.rbCui.Size = new System.Drawing.Size(43, 17);
            this.rbCui.TabIndex = 9;
            this.rbCui.TabStop = true;
            this.rbCui.Text = "CUI";
            this.rbCui.UseVisualStyleBackColor = true;
            this.rbCui.CheckedChanged += new System.EventHandler(this.rbCui_CheckedChanged);
            // 
            // rbExt
            // 
            this.rbExt.AutoSize = true;
            this.rbExt.Location = new System.Drawing.Point(210, 106);
            this.rbExt.Name = "rbExt";
            this.rbExt.Size = new System.Drawing.Size(72, 17);
            this.rbExt.TabIndex = 8;
            this.rbExt.TabStop = true;
            this.rbExt.Text = "Extranjero";
            this.rbExt.UseVisualStyleBackColor = true;
            this.rbExt.CheckedChanged += new System.EventHandler(this.rbExt_CheckedChanged);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 572);
            this.ControlBox = false;
            this.Controls.Add(this.rbExt);
            this.Controls.Add(this.rbCui);
            this.Controls.Add(this.rbNit);
            this.Controls.Add(this.rbCF);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbFelStatus);
            this.Controls.Add(this.pnBrowser);
            this.Controls.Add(this.edOrden);
            this.Controls.Add(this.edResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edNombre);
            this.Controls.Add(this.edNit);
            this.Controls.Add(this.lbConsumer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lbConsumer;
        private System.Windows.Forms.TextBox edNit;
        private System.Windows.Forms.TextBox edNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
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
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbCF;
        private System.Windows.Forms.RadioButton rbNit;
        private System.Windows.Forms.RadioButton rbCui;
        private System.Windows.Forms.RadioButton rbExt;
    }
}

