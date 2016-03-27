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
    public partial class frmContado : Form
    {
        int n = 0;

        public frmContado()
        {
            InitializeComponent();
        }

        private void configurarLista()
        {
            lvR.View = View.Details;
            lvR.GridLines = true;
            lvR.Columns.Add("Nro Venta", 90);
            lvR.Columns.Add("Fecha", 110);
            lvR.Columns.Add("Monto", 90);
            lvR.Columns.Add("Descuento", 90);
            lvR.Columns.Add("Neto a Pagar", 120);
        }

        private void generarCodigo()
        {
            n++;
            txtNroVenta.Text = "BOL" + n.ToString("0000");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Instanciamos a la clase
            Contado objContado = new Contado();
            //Capturamos los valores para pasarlos al listView
            objContado.numVenta = txtNroVenta.Text;
            //objContado.fecha = txtFecha.Text;
            objContado.fecha = Convert.ToDateTime(txtFecha.Text);
            objContado.monto = double.Parse(txtMonto.Text);

            mostrarDatos(objContado);

            generarCodigo();

        }

        private void mostrarDatos(Contado objContado)
        {
            //Mostramos los datos al LVr
            ListViewItem fila = new ListViewItem(objContado.numVenta);
            fila.SubItems.Add(objContado.fecha.ToString("d"));
            fila.SubItems.Add(objContado.monto.ToString("0.00"));
            fila.SubItems.Add(objContado.calculaDescuento().ToString("0.00"));
            fila.SubItems.Add(objContado.calculaNeto().ToString("0.00"));
            lvR.Items.Add(fila);
        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            generarCodigo();
            configurarLista();
            generarFecha();
            txtFecha.Enabled = false;
            txtNroVenta.Enabled = false;
        }

        private void generarFecha()
        {
            txtFecha.Text = DateTime.Now.ToString("d");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
