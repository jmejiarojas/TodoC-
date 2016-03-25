using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoVendedores
{
    public partial class frmPrincipal : Form
    {
        int n = 0;
        double subtotal;

        public frmPrincipal()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarCombo();
            configurarLista();
        }

        private void configurarLista()
        {
            lvR.View = View.Details;
            lvR.GridLines = true;
            lvR.Columns.Add("Nro",30);
            lvR.Columns.Add("Vendedor", 120);
            lvR.Columns.Add("Cat",40);
            lvR.Columns.Add("Horas Tr.", 70);
            lvR.Columns.Add("S. Bruto", 70);
            lvR.Columns.Add("Descuento", 70);
            lvR.Columns.Add("S. Neto", 70);
        }

        private void cargarCombo()
        {
            cboCategoria.Items.Add("A");
            cboCategoria.Items.Add("B");
            cboCategoria.Items.Add("C");
            cboCategoria.Items.Add("D");
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                n++;
                Pago pago = new Pago();
                pago.vendedor = txtVendedor.Text;

                leerHoras(pago);

                pago.categoria = cboCategoria.Text;

                //Aumentamos el subtotal que es una variable global
                subtotal += pago.calcularSubtotal();

                //Imprimiendo en el Listview
                ListViewItem fila = new ListViewItem(n.ToString());
                fila.SubItems.Add(pago.vendedor);
                fila.SubItems.Add(pago.categoria);
                fila.SubItems.Add(pago.horas.ToString());
                fila.SubItems.Add(pago.calcularSubtotal().ToString());
                fila.SubItems.Add(pago.calcularDescuento().ToString());
                fila.SubItems.Add(pago.calcularNeto().ToString());
                lvR.Items.Add(fila);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la aplicación !!", "Adevertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void leerHoras(Pago pago)
        {
            if (String.IsNullOrEmpty(txtHoras.Text))
            {
                pago.horas = 30;
            }
            else
            {
                pago.horas = int.Parse(txtHoras.Text);
            }
        }

        public void limpiarCajas()
        {
            txtVendedor.Clear();
            txtHoras.Clear();
            cboCategoria.SelectedIndex = -1;

        }

        public void reinicar()
        {
            n = 0;
            subtotal = 0;
            lvR.Items.Clear();
            limpiarCajas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            reinicar();
        }

        private void salir()
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
    }
}
