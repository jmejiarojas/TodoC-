using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Modelo3
{
    public partial class EncriptacionArchivos : Form
    {
        UTF8Encoding ue = new UTF8Encoding();
        RSACryptoServiceProvider sec = new RSACryptoServiceProvider();
        byte[] bytString, bytEncriptado, bytDesencriptado;

        public EncriptacionArchivos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCadena.Text = Desencriptar(txtCifrado.Text);
        }

        private string Desencriptar(string cadena)
        {
            String salida = "";

            bytDesencriptado = sec.Decrypt(Convert.FromBase64String(cadena), false);
            salida = ue.GetString(bytDesencriptado);

            return salida;
        }

        private string Encriptar(string cadena)
        {
            String encriptado = "";

            bytString = ue.GetBytes(cadena);
            bytEncriptado = sec.Encrypt(bytString, false);
            encriptado = Convert.ToBase64String(bytEncriptado);
            return encriptado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCifrado.Text = Encriptar(txtCadena.Text);
        }

        
    }
}
