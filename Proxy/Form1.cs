using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy_Samir
{
    public partial class Form1 : Form
    {
        private ProxyTranslator _proxyTranslator;

        public Form1()
        {
            InitializeComponent();

            _proxyTranslator = new ProxyTranslator();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (textBoxEnglish.Text == string.Empty)
                return;

            try
            {
                textBoxRussian.Text = _proxyTranslator.Translate(textBoxEnglish.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void textBoxEnglish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                buttonGo_Click(this, e);
            }
        }
    }
}
