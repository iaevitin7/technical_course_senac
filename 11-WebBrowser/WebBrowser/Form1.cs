using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'>";
                html += "</head><body><iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='400' frameborder='0'></iframe>";
                html += "</body></html>";

                this.webBrowser1.DocumentText = string.Format(html, linkLabel1.Text.Split('=')[1]);
            }
            catch (Exception)
            {

                
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'>";
                html += "</head><body><iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='400' frameborder='0'></iframe>";
                html += "</body></html>";

                this.webBrowser1.DocumentText = string.Format(html, linkLabel2.Text.Split('=')[1]);
            }
            catch (Exception)
            {


            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            try
            {
                string html = "<html><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'>";
                html += "</head><body><iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='400' frameborder='0'></iframe>";
                html += "</body></html>";

                this.webBrowser1.DocumentText = string.Format(html, txbLink.Text.Split('=')[1]);
            }
            catch (Exception)
            {


            }
        }
    }
}
