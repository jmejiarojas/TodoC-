using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoSueldosHerencia
{
    public partial class frmEmpleadosComision : Form
    {
        int n = 0; //Declaramos una variable global

        public frmEmpleadosComision()
        {
            InitializeComponent();
            configurarLista();
            generaCodigo();
        }

        private void configurarLista()
        {
            lvR.View = View.Details;
            lvR.GridLines = true;
            lvR.Columns.Add("Código", 60);
            lvR.Columns.Add("Nombres", 150);
            lvR.Columns.Add("Ingreso", 100);
            lvR.Columns.Add("Monto", 90);
            lvR.Columns.Add("Año Serv", 90);
            lvR.Columns.Add("Sueldo", 100);

        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //Creamo el objeto de la clase Comision
            Comision objComi = new Comision();
            //Enviamos los valores a la clase
            objComi.codigo = txtCodigo.Text;
            objComi.nombres = txtNombres.Text;
            objComi.fechaIngreso = dtpFecha.Value;
            objComi.montoVendido = double.Parse(txtMontoVendido.Text);

            DialogResult r = MessageBox.Show("¿Está seguro de registrar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                //Enviando los valores a la lista
                ListViewItem fila = new ListViewItem(objComi.codigo);
                fila.SubItems.Add(objComi.nombres);
                fila.SubItems.Add(objComi.fechaIngreso.ToString("d"));
                fila.SubItems.Add(objComi.montoVendido.ToString("0.00"));
                fila.SubItems.Add(objComi.calculaAniosServicios().ToString());
                fila.SubItems.Add(objComi.calculaSueldo().ToString("0.00"));
                lvR.Items.Add(fila);
                generaCodigo();
            }

        }

        private void generaCodigo()
        {
            n++;
            txtCodigo.Text = "C" + n.ToString("0000");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            txtNombres.Clear();
            txtMontoVendido.Clear();
            txtNombres.Focus();
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
