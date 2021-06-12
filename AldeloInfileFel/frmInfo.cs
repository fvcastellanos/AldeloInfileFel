using AldeloInfileFel.Client;
using AldeloInfileFel.Domain;
using AldeloInfileFel.Services;
using CefSharp.WinForms;
using Newtonsoft.Json;
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

        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            var info = AldeloFelClient.GetApiInfo();
            edInfo.Text = PrettyPrintJson(info);
        }

        private string PrettyPrintJson(string json)
        {
            var jsonObject = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            //string sPrettyStr;
            //var item2 = "{\"messageType\":\"0\",\"code\":\"1\"}";
            //sPrettyStr = JToken.Parse(item2).ToString(Formatting.Indented);
        }
    }
}
