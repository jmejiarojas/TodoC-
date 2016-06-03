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
using System.Xml.Serialization;

namespace Modelo3
{
    public partial class SerializacionXML : Form
    {
        public SerializacionXML()
        {
            InitializeComponent();
        }

        private void SerializacionXML_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double promedio = calcularPromedio(int.Parse(txtNota1.Text), int.Parse(txtNota2.Text), 
                int.Parse(txtNota3.Text), int.Parse(txtNota4.Text));
            txtPromedio.Text = promedio.ToString();
        }   

        Func<int, int, int, int, double> calcularPromedio = (n1,n2,n3,n4) => {

            int menor;
            double suma = 0;

            menor = n1;
            if (n2 < menor) menor = n2;
            if (n3 < menor) menor = n3;
            if (n4 < menor) menor = n4;

            suma = n1 + n2 + n3 + n4 - menor;
            double promedio = suma / 3;
            return promedio;
        };

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo XML|*.xml";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                Registro objR = new Registro();
                objR.alumno = txtAlumno.Text;
                objR.promedio = Double.Parse(txtPromedio.Text);
                objR.fecha = DateTime.Parse(lblFecha.Text);

                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Registro));
                    xml.Serialize(fs, objR);
                }
            }
        }
    }
}
