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
    public partial class frmPrincipal : Form
    {
        int n = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            configurarLista();
            txtCodigo.Enabled = false;
            generarCodigo();
        }

        private void configurarLista()
        {
            lvR.View = View.Details;
            lvR.GridLines = true;
            lvR.Columns.Add("Código", 70);
            lvR.Columns.Add("Nombres", 120);
            lvR.Columns.Add("Ingreso", 80);
            lvR.Columns.Add("Teléfono", 80);
            lvR.Columns.Add("Descuento", 70);
            lvR.Columns.Add("Neto", 80);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Asalariado objSal = new Asalariado();

            //Obtener los valores del formulario
            objSal.codigo = txtCodigo.Text;
            objSal.nombres = txtNombres.Text;
            objSal.fechaIngreso = dtFecha.Value;
            objSal.telefono = txtTelefono.Text;

            //Confirmacion para registrar
            DialogResult r = MessageBox.Show("Está seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(r == DialogResult.Yes)
            {
                //Enviamos los valores a la lista
                ListViewItem fila = new ListViewItem(objSal.codigo);
                fila.SubItems.Add(objSal.nombres);
                fila.SubItems.Add(objSal.fechaIngreso.ToString("d"));
                fila.SubItems.Add(objSal.telefono);
                fila.SubItems.Add(objSal.calculaDescuento().ToString("0.00"));
                fila.SubItems.Add(objSal.calcularNeto().ToString("0.00"));
                lvR.Items.Add(fila);

                generarCodigo();
                limpiarControles();
            }

        }

        private void limpiarControles()
        {
            txtNombres.Clear();
            txtTelefono.Clear();
            txtNombres.Focus();
        }

        private void generarCodigo()
        {
            n++;
            txtCodigo.Text = "T" + n.ToString("0000");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir..!!",
             "Salir",
             MessageBoxButtons.YesNo,
            MessageBoxIcon.Error);
            if (r == DialogResult.Yes)
                this.Close();
        }

    }
}
