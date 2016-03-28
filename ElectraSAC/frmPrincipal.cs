using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectraSAC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContado contado = new frmContado();
            contado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCredito credito = new frmCredito();
            credito.Show();
        }
    }
}
