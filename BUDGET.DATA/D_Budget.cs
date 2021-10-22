using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.DATA
{
    public class D_Budget
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BUDGET.DESKTOP.Properties.Settings.FinanceDBConnectionString"].ConnectionString);

        public DataTable ListandoBudget()
        {
            DataTable tabla = new DataTable();
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUDGET", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();
            tabla.Load(LeerFilas);

            LeerFilas.Close();
            conexion.Close();

            return tabla;
        }

    }
}
