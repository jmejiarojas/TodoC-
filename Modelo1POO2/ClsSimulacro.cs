using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Modelo1POO2
{
    class ClsSimulacro
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public DataTable listarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_CLIENTES", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable listarBoletasPorCliente(String codCliente)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTADO_BOLETAS_POR_CLIENTE", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@COD_CLI",SqlDbType.VarChar, 6).Value = codCliente;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable detallePedidoPorCodBoleta(String codBoleta)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_DETALLE_BOLETA_POR_CODIGO", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@COD_BOL", SqlDbType.VarChar, 6).Value = codBoleta;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
