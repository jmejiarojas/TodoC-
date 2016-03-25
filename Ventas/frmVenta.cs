using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void cargarCombo()
        {
            /*
            Impresora Inyección 150.00
            Impresora Laser 320.00
            Mouse Óptico 60.00
            Teclado Multimedia 50.00
            */

            cboDescripcion.Items.Add("Impresora Inyección");
            cboDescripcion.Items.Add("Impresora Laser");
            cboDescripcion.Items.Add("Mouse Óptico");
            cboDescripcion.Items.Add("Teclado Multimedia");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.cantidad = int.Parse(txtCantidad.Text);
            venta.descripcion = cboDescripcion.Text;
            venta.precio = venta.asignarPrecio();

            //Impresion de datos
            limpiar();
            lstR.Items.Add("******CUADRO DE RESUMEN********");
            lstR.Items.Add("--------------------------------");
            lstR.Items.Add("PRODUCTO:  " + venta.descripcion);
            lstR.Items.Add("PRECIO: S/. " + venta.precio.ToString("0.00"));
            lstR.Items.Add("CANTIDAD: " + venta.cantidad);
            lstR.Items.Add("----------------------------------");
            lstR.Items.Add("SUBTOTAL: S/. " + venta.calcularSubtotal().ToString("0.00"));
            lstR.Items.Add("DESCUENTO(7.5%): S/. " + venta.calcularDescuento().ToString("0.00"));
            lstR.Items.Add("NETO A PAGAR: S/. " + venta.calcularNeto().ToString("0.00"));
        }

        private void limpiar()
        {
            lstR.Items.Clear();
            txtCantidad.Clear();
            cboDescripcion.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de Salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
