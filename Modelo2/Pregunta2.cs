using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Modelo2
{
    public partial class Pregunta2 : Form
    {
        Thread hilo;
        ArrayList aArtefacto = new ArrayList();

        public Pregunta2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Artefacto objA = new Artefacto();
            objA.codigo = lblCodigoGenerado.Text;
            objA.descripcion = txtDescripcion.Text;
            aArtefacto.Add(objA);
            mostrarListado();
            generarCodigo();
        }

        private void mostrarListado()
        {
            lvResultados.Items.Clear();

            foreach (Artefacto a in aArtefacto)
            {
                ListViewItem fila = new ListViewItem(a.codigo);
                fila.SubItems.Add(a.descripcion);
                lvResultados.Items.Add(fila);
            }
        }

        private void generarCodigo()
        {
            //Agregamos codigos randoms
            int codigo;
            Random rnd = new Random();
            codigo = rnd.Next(10, 99);
            lblCodigoGenerado.Text = codigo.ToString();
        }

        private void Pregunta2_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            generarCodigo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hilo = new Thread(sorteo);
            hilo.Start();
        }

        private void sorteo()
        {
            Random rnd = new Random();
            int numero;
            do
            {
                //Imprimimos los numeros aleatorios
                Thread.Sleep(500);
                numero = rnd.Next(10, 99);
                lblCodigoGanador.Text = numero.ToString();

                foreach (ListViewItem fila in lvResultados.Items)
                {
                    if (fila.SubItems[0].Text == numero.ToString()) {

                        lblCodigoGanador.Text = "Codigo Ganador: " + numero.ToString();
                        lblPremio.Text = fila.SubItems[1].Text;
                        return;
                    }

                }

            } while (true);
        }
    }
}
