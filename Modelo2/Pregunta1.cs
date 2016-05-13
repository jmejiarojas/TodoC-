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

namespace Modelo2
{
    public partial class Pregunta1 : Form
    {
        static int n = 0;
        ArrayList aProductos = new ArrayList();

        Func<String> generaCodigo = () => {

            n++;
            return "PR" + n.ToString("0000");
        };

        public Pregunta1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos un objeto de la clase productos
            Producto objP = new Producto();
            objP.codigo = generaCodigo();
            objP.descripcion = txtDescripcionR.Text;
            objP.precio = Double.Parse(txtPrecioR.Text);
            objP.proveedor = cboProveedorR.Text;

            //Verifiquemos que no ingresemos un producto con la misma descripcion
            var lProductos = from Producto p in aProductos
                             where p.descripcion == objP.descripcion
                             select p;
            
            if(lProductos.Count() != 0)
            {
                MessageBox.Show("Ya existe producto con esa descripcion");
                return;
            }

            //Todo salio ok, entonces ingresamos el objeto al arreglo
            aProductos.Add(objP);
            MessageBox.Show("Producto registrado");
            lblCodigo.Text = generaCodigo();
            mostrarListado();
              
        }

        private void mostrarListado()
        {
            lvListadoL.Items.Clear();

            var lProductos = from Producto p in aProductos
                             select p;

            foreach (Producto p in lProductos)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.descripcion);
                fila.SubItems.Add(p.precio.ToString());
                fila.SubItems.Add(p.proveedor);

                lvListadoL.Items.Add(fila);
            }
        }

        private void Pregunta1_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            cboProveedorR.Items.Add("MACRO SAC");
            cboProveedorR.Items.Add("MAYORSA SAC");
            cboProveedorR.Items.Add("OTROS");

            cboProveedorC.Items.Add("MACRO SAC");
            cboProveedorC.Items.Add("MAYORSA SAC");
            cboProveedorC.Items.Add("OTROS");
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            lvListadoL.Items.Clear();

            var lProductos = from Producto p in aProductos
                             orderby p.descripcion ascending
                             select p;

            foreach (Producto p in lProductos)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.descripcion);
                fila.SubItems.Add(p.precio.ToString());
                fila.SubItems.Add(p.proveedor);

                lvListadoL.Items.Add(fila);
            }
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            lvListadoL.Items.Clear();

            var lProductos = from Producto p in aProductos
                             orderby p.descripcion descending
                             select p;

            foreach (Producto p in lProductos)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.descripcion);
                fila.SubItems.Add(p.precio.ToString());
                fila.SubItems.Add(p.proveedor);

                lvListadoL.Items.Add(fila);
            }
        }

        private void cboProveedorC_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lProductos = from Producto p in aProductos
                             where p.proveedor == cboProveedorC.Text
                             select p;
            lvListadoC.Items.Clear();
            foreach (Producto p in lProductos)
            {
                ListViewItem fila = new ListViewItem(p.codigo);
                fila.SubItems.Add(p.descripcion);
                fila.SubItems.Add(p.precio.ToString());
                fila.SubItems.Add(p.proveedor);

                lvListadoL.Items.Add(fila);
            }

        }
    }
}
