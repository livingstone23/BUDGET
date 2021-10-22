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
    public  class D_POSPay
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BUDGET.DESKTOP.Properties.Settings.FinanceDBConnectionString"].ConnectionString);
   
    
        public DataTable ListPOSPays(string buscar)
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_listPOSPay", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }

        public DataTable SearchPOSPays(E_POSPay  posPay)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_searchPOSPay", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@search", posPay.DescriptionPOS);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public void DeletePOSPay(int idPosPay)
        {
            SqlCommand cmd = new SqlCommand("SP_deletePOSPay", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@id", idPosPay);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CreatePOSPay(E_POSPay posPay)
        {
            SqlCommand cmd = new SqlCommand("SP_createPOSPay", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@payDay", posPay.PayDay);
            cmd.Parameters.AddWithValue("@currencyPay", posPay.CurrencyPay);
            cmd.Parameters.AddWithValue("@descriptionPos", posPay.DescriptionPOS);
            cmd.Parameters.AddWithValue("@numberTransfer", posPay.NumberTransfer);
            cmd.Parameters.AddWithValue("@payAmount", posPay.PayAmount);
            cmd.Parameters.AddWithValue("@rateChange", posPay.RateChange);

            cmd.Parameters.AddWithValue("@idInitiative", posPay.IdInitiative);
            cmd.Parameters.AddWithValue("@idProject", posPay.IdProject);
            cmd.Parameters.AddWithValue("@idPOSPosPayAdjust", posPay.IdPOSPaysAdjust);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }




    }
}
