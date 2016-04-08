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
using Microsoft.VisualBasic;

namespace pjMantenimientoClientes
{
    public partial class frmMantenimiento : Form
    {
        int n;
        ArrayList aProductos = new ArrayList();
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tsAgregar_Click(object sender, EventArgs e)
        {
            if (valida() == "OK")
            {
                Producto objP = new Producto();
                objP.codigo = lblCodigo.Text;
                objP.descripcion = txtDescripcion.Text;
                objP.categoria = cboCategoria.Text;
                objP.fecha = dtpFecha.Value;
                objP.stock = int.Parse(txtStock.Text);
                objP.precio = double.Parse(txtPrecio.Text);

                //Validamos que la descripción del video no se repita
                foreach (Producto p in aProductos)
                {
                    if(p.descripcion == objP.descripcion)
                    {
                        MessageBox.Show("Producto ya registrado");
                        return;
                    }
                }

                aProductos.Add(objP);
                listado();

                //Habilitar los botones
                tsGrabar.Visible = false;
                tsNuevo.Visible = true;

                habilitarBotones(true);
                habilitarCajas(false);
                limpiarControles();
            }
            else
            {
                MessageBox.Show("El error esá en : " + valida());
            }
        }

        private void limpiarControles()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) c.Text = "";
            }
            cboCategoria.SelectedIndex = 0;
            lblCodigo.Text = "";
            txtDescripcion.Focus();
        }

        private void habilitarCajas(Boolean banderita)
        {
            txtDescripcion.Enabled = banderita;
            cboCategoria.Enabled = banderita;
            txtPrecio.Enabled = banderita;
            dtpFecha.Enabled = banderita;
            txtStock.Enabled = banderita;
        }

        private void habilitarBotones(Boolean banderita)
        {
            tsBuscar.Enabled = banderita;
            tsEliminar.Enabled = banderita;
            tsModificar.Enabled = banderita;
        }

        private void listado()
        {
            lvR.Items.Clear();
            foreach (Producto p in aProductos)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.descripcion);
                fila.SubItems.Add(p.categoria);
                fila.SubItems.Add(p.fecha.ToShortDateString());
                fila.SubItems.Add(p.stock.ToString());
                fila.SubItems.Add(p.precio.ToString("0.00"));
                lvR.Items.Add(fila);

            }
        }

        //Metodo que genera el nuevo codigo de cliente
        public void generaCodigo()
        {
            n++;
            lblCodigo.Text = DateTime.Now.Year.ToString().Substring(2) + "-PR" + n.ToString("0000");
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            cargarCombo();
            tsGrabar.Visible = false;
            habilitarCajas(false);
        }

        private void cargarCombo()
        {
            cboCategoria.Items.Add("Bebidas");
            cboCategoria.Items.Add("Lacteos");
            cboCategoria.Items.Add("Golosinas");
            cboCategoria.Items.Add("Abarrotes");
            cboCategoria.Items.Add("Otros");
            cboCategoria.SelectedIndex = 0;
        }

        public  String valida()
        {
            if(txtDescripcion.Text.Trim().Length == 0)
            {
                txtDescripcion.Focus();
                txtDescripcion.Clear();
                return "en la descripción del producto";
            }

            if (!Information.IsNumeric(txtStock.Text))
            {
                txtStock.Focus();
                txtStock.Clear();
                return "el stock del producto";
            }

            if (!Information.IsNumeric(txtPrecio.Text))
            {
                txtPrecio.Clear();
                txtPrecio.Focus();
                return "el precio del producto";
            }

            return "OK";
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            generaCodigo();
            //limpiarControles();
            tsGrabar.Visible = true;
            tsNuevo.Visible = true;

            habilitarBotones(false);
            habilitarCajas(true);
        }

        private void lvR_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Capturamos el elemento seleccionado
            ListViewItem valor = lvR.GetItemAt(e.X, e.Y);
            lblCodigo.Text = valor.Text;
            txtDescripcion.Text = valor.SubItems[1].Text;
            dtpFecha.Value = DateTime.Parse(valor.SubItems[3].Text);
            txtStock.Text = valor.SubItems[4].Text;
            txtPrecio.Text = valor.SubItems[5].Text;

            habilitarCajas(true);
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            foreach (Producto p in aProductos)
            {
                if(lblCodigo.Text == p.codigo) {

                    p.descripcion = txtDescripcion.Text;
                    p.categoria = cboCategoria.Text;
                    p.fecha = dtpFecha.Value;
                    p.stock = int.Parse(txtStock.Text);
                    p.precio = double.Parse(txtPrecio.Text);
                    break;
                }

            }

            listado();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            foreach (Producto p in aProductos)
            {
                if(lblCodigo.Text == p.codigo)
                {
                    aProductos.Remove(p);
                    break;
                }
            }

            listado();
            habilitarBotones(false);
            habilitarCajas(false);
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; //No escribe
                return;
            }
        }
    }
}
