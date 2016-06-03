using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace SeguridadCriptografia
{
    public partial class Form1 : Form
    {
        UTF8Encoding ue = new UTF8Encoding();
        RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
        Byte[] byString, byEncriptar, byDesencriptar;

        private void btnCifrado_Click(object sender, EventArgs e)
        {
            txtCifrado.Text = encriptar(txtTexto.Text);
        }

        private string encriptar(String cadena)
        {
            byString = ue.GetBytes(cadena);
            byEncriptar = sec.Encrypt(byString, false);
            return Convert.ToBase64String(byEncriptar);
        }

        private void btnDescifrado_Click(object sender, EventArgs e)
        {
            txtTexto.Text = desencriptar(txtCifrado.Text);

        }

        private string desencriptar(string cadena)
        {
            byDesencriptar = sec.Decrypt(Convert.FromBase64String(cadena), false);
            return ue.GetString(byDesencriptar);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
