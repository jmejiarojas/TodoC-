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

namespace pjMantenimientoClientes
{
    public partial class frmMantenimiento : Form
    {
        int n;
        ArrayList aClientes = new ArrayList();
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tsAgregar_Click(object sender, EventArgs e)
        {
            //Creando un objeto de la clase Cliente
            Cliente objC = new Cliente();

            //Enviar la informacion po el objeto
            objC.codigo = lblCodigo.Text;
            objC.nombres = txtNombres.Text;
            objC.telefono = txtTelefono.Text;
            objC.correo = txtCorreo.Text;

            //Enviar al arraylist
            aClientes.Add(objC);

            lblCodigo.Text = generaCodigo();

            listado();
        }

        private void listado()
        {
            lvR.Items.Clear();
            
            foreach (Cliente c in aClientes)
            {
                ListViewItem fila = new ListViewItem(c.codigo);
                fila.SubItems.Add(c.nombres);
                fila.SubItems.Add(c.telefono);
                fila.SubItems.Add(c.correo);
                lvR.Items.Add(fila);
                
            }
        }

        //Metodo que genera el nuevo codigo de cliente
        public String generaCodigo()
        {
            n++;
            return "CL" + n.ToString("0000");
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = generaCodigo();
        }
    }
}
