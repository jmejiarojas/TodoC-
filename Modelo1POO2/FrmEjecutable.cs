using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo1POO2
{
    public partial class FrmEjecutable : Form
    {
        ClsSimulacro objSimulacro = new ClsSimulacro();

        public FrmEjecutable()
        {
            InitializeComponent();
        }

        private void FrmEjecutable_Load(object sender, EventArgs e)
        {
           
            llenarComboClientes();

        }

        private void llenarComboClientes()
        {
            cboClientes.DataSource = objSimulacro.listarClientes();
            cboClientes.ValueMember = "COD_CLI";
            cboClientes.DisplayMember = "CLIENTE";
        }

        private void cboClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarComboBoletas();
        }

        private void llenarComboBoletas()
        {
            cboBoletas.DataSource = objSimulacro.listarBoletasPorCliente(getCodigoCliente());
            cboBoletas.DisplayMember = "COD_BOL";
        }

        private string getCodigoCliente()
        {
            return cboClientes.SelectedValue.ToString();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgResultados.DataSource = objSimulacro.detallePedidoPorCodBoleta(getCodigoBoleta());
        }

        private string getCodigoBoleta()
        {
            return cboBoletas.Text;
        }
    }
}
