using BUDGET.ENTITIES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDGET.DATA
{
    public class D_Initiative
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar4"].ConnectionString);


        public List<E_Initiative> ListInitiative(string search)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_SEARCHINITIATIVE", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SEARCH", search);
            LeerFilas = cmd.ExecuteReader();

            List<E_Initiative> Listar = new List<E_Initiative>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Initiative
                {
                    IdInitiative = LeerFilas.GetInt32(0),
                    InitiativeName = LeerFilas.GetString(1),
                    InitiativeDescription = LeerFilas.GetString(2)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }


        public void InsertInitiative(E_Initiative Initiative)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTINITIATIVE", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@InitiativeName", Initiative.InitiativeName);
            cmd.Parameters.AddWithValue("@InitiativeDescription", Initiative.InitiativeDescription);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void EditInitiative(E_Initiative Initiative)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITINITIATIVE", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdInititive", Initiative.IdInitiative);
            cmd.Parameters.AddWithValue("@InitiativeName", Initiative.InitiativeName);
            cmd.Parameters.AddWithValue("@InitiativeDescription", Initiative.InitiativeDescription);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public void DeleteInitiative(E_Initiative Initiative)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETEINITIATIVE", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDINITIATIVE", Initiative.IdInitiative);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
