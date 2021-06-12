
namespace AldeloInfileFel
{
    partial class frmInfo
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
            this.pnBrowser = new System.Windows.Forms.Panel();
            this.edInfo = new System.Windows.Forms.TextBox();
            this.pnBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBrowser
            // 
            this.pnBrowser.Controls.Add(this.edInfo);
            this.pnBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnBrowser.Name = "pnBrowser";
            this.pnBrowser.Size = new System.Drawing.Size(507, 353);
            this.pnBrowser.TabIndex = 0;
            // 
            // edInfo
            // 
            this.edInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edInfo.Location = new System.Drawing.Point(0, 0);
            this.edInfo.Multiline = true;
            this.edInfo.Name = "edInfo";
            this.edInfo.ReadOnly = true;
            this.edInfo.Size = new System.Drawing.Size(507, 353);
            this.edInfo.TabIndex = 0;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 353);
            this.Controls.Add(this.pnBrowser);
            this.Name = "frmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información de Aplicación";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.pnBrowser.ResumeLayout(false);
            this.pnBrowser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBrowser;
        private System.Windows.Forms.TextBox edInfo;
    }
}