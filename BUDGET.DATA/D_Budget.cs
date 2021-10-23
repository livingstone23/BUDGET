using BUDGET.ENTITIES;
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

        public void ShowTotals(E_BUDGET budget)
        {
            SqlCommand cmd = new SqlCommand("summaryTotals", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalInitiative = new SqlParameter("@totalInitiative", 0);
            totalInitiative.Direction = ParameterDirection.Output;

            SqlParameter totalProjects = new SqlParameter("@totalProjects", 0);
            totalProjects.Direction = ParameterDirection.Output;

            SqlParameter totalProducts = new SqlParameter("@totalPos", 0);
            totalProducts.Direction = ParameterDirection.Output;


            cmd.Parameters.Add(totalInitiative);
            cmd.Parameters.Add(totalProjects);
            cmd.Parameters.Add(totalProducts);
            conexion.Open();

            cmd.ExecuteNonQuery();

            budget.TotalInitiative = cmd.Parameters["@totalInitiative"].Value.ToString();
            budget.TotalProjects = cmd.Parameters["@totalProjects"].Value.ToString();
            budget.TotalPos = cmd.Parameters["@totalPos"].Value.ToString();

            conexion.Close();
        }

    }
}
