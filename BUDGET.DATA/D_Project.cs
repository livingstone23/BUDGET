using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUDGET.ENTITIES;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BUDGET.DATA
{
    public class D_Project
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar3"].ConnectionString);
        public List<E_ProjectJoinInitiative> ListarProjects(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_SEARCHPROJECT", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();
            List<E_ProjectJoinInitiative> Listar = new List<E_ProjectJoinInitiative>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_ProjectJoinInitiative
                {
                    IdProject = LeerFilas.GetInt32(0),
                    NombreProject = LeerFilas.GetString(1),
                    DescriptionProject = LeerFilas.GetString(2),
                    AmountDefined = LeerFilas.GetDecimal(3),
                    InitiativeName = LeerFilas.GetString(4)

                }); ;
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }
        public List<E_Project> getProjectPorIdInitiative(string idInitiative)
        {
            List<E_Project> proyectos = new List<E_Project>();
            SqlDataReader LeerFilas;
            conexion.Open();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Project where IdInitiative = {idInitiative}", conexion);
            LeerFilas = cmd.ExecuteReader();
            while (LeerFilas.Read())
            {
                proyectos.Add(new E_Project
                {
                    IdProject = LeerFilas.GetInt32(0),
                    NameProject = LeerFilas.GetString(1),
                                        
                });
            }
            return proyectos;
        }
        public int GetIdInitiative(string stNombre)
        {
            int iId;
            try
            {
                //conexion.Open();

                //string sentencia = $"SELECT IdInitiative FROM Initiative WHERE InitiativeName = '{stNombre}' ";
                //SqlCommand cmd = new SqlCommand(sentencia, conexion);
                //iId = Convert.ToInt32(cmd.ExecuteScalar());
                //return iId;
                SqlCommand cmd = new SqlCommand("SP_GETINITIATIVEID", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@NombreInitiative", stNombre.ToUpper());
                iId = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
                return iId;
            }
            catch (Exception ex)
            {

                return 0;
            }


        }
        public void InsertarProject(E_Project oProject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_INSERTPROJECT", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@ProjectName", oProject.NameProject);
                cmd.Parameters.AddWithValue("@ProjectDescription", oProject.DescripcionProject);
                cmd.Parameters.AddWithValue("@Amount", oProject.Amount);
                cmd.Parameters.AddWithValue("@IdInitiative", oProject.IdIniciativa);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
            }

        }
        public void EditarProject(E_Project oProject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_EDITPROJECT", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@IdProyecto", oProject.IdProject);
                cmd.Parameters.AddWithValue("@ProjectName", oProject.NameProject);
                cmd.Parameters.AddWithValue("@ProjectDescription", oProject.DescripcionProject);
                cmd.Parameters.AddWithValue("@Amount", oProject.Amount);
                cmd.Parameters.AddWithValue("@IdInitiative", oProject.IdIniciativa);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
            }
        }
        public void EliminarProject(E_Project oProject)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_DELETEPROJECT", conexion);
                conexion.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProyecto", oProject.IdProject);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
            }
        }

    }
}
