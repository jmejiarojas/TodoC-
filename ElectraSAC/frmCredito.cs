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
    public partial class frmCredito : Form
    {
        int n = 0;

        public frmCredito()
        {
            InitializeComponent();
        }

        private void frmCredito_Load(object sender, EventArgs e)
        {
            generarCodigo();
            cargarCombo();
            configurarLista();
            generarFecha();

            txtFecha.Enabled = false;
            txtNroVenta.Enabled = false;
        }

        private void generarFecha()
        {
            txtFecha.Text = DateTime.Now.ToString("d");
        }

        private void configurarLista()
        {

            lvR.View = View.Details;
            lvR.GridLines = true;
            lvR.Columns.Add("Nro Venta", 80);
            lvR.Columns.Add("Fecha", 100);
            lvR.Columns.Add("Monto", 110);
            lvR.Columns.Add("Monto Mensual", 110);
            lvR.Columns.Add("Total Crédito", 120);
        }

        private void cargarCombo()
        {
            cboNroLetras.Items.Add("3");
            cboNroLetras.Items.Add("6");
            cboNroLetras.Items.Add("9");
            cboNroLetras.Items.Add("12");
        }

        private void generarCodigo()
        {
            n++;
            txtNroVenta.Text = "BOL" + n.ToString("0000");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                //Creamos una instancia de la clase Credito
                Credito objCredito = new Credito();
                //Le asignamos los valores a la clase
                objCredito.numVenta = txtNroVenta.Text;
                objCredito.fecha = Convert.ToDateTime(txtFecha.Text);
                objCredito.monto = double.Parse(txtMonto.Text);
                objCredito.numLetras = int.Parse(cboNroLetras.Text);


                DialogResult r = MessageBox.Show("¿Esta seguro de resgistrar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    mostrarDatos(objCredito);
                    generarCodigo();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la aplicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void mostrarDatos(Credito objCredito)
        {

            ListViewItem fila = new ListViewItem(objCredito.numVenta);
            fila.SubItems.Add(objCredito.fecha.ToString("d"));
            fila.SubItems.Add(objCredito.monto.ToString("0.00"));
            fila.SubItems.Add(objCredito.calculaMontoMensual().ToString("0.00"));
            fila.SubItems.Add(objCredito.calculaNeto().ToString("0.00"));
            lvR.Items.Add(fila);
        }
    }
}
