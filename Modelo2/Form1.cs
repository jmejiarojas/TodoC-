using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pregunta1 pregunta1 = new Pregunta1();
            pregunta1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pregunta2 pregunta2 = new Pregunta2();
            pregunta2.Visible = true;
        }
    }
}
