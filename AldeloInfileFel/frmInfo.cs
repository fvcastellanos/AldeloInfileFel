using AldeloInfileFel.Domain;
using AldeloInfileFel.Services;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AldeloInfileFel
{
    public partial class frmInfo : Form
    {
        private readonly Configuration _configuration = ConfigurationService.LoadConfiguration();

        private readonly ChromiumWebBrowser _browser;

        public frmInfo()
        {
            InitializeComponent();

            _browser = new ChromiumWebBrowser(_configuration.FelApiInfo);
            pnBrowser.Controls.Add(_browser);
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
        }
    }
}
