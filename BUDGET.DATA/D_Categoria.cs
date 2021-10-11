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
    public class D_Categoria
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar3"].ConnectionString);


        public List<E_Categoria> ListaCategoria(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCATEGORIA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Categoria> Listar = new List<E_Categoria>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Categoria
                {
                    Idcategoria = LeerFilas.GetInt32(0),
                    Codigocategoria = LeerFilas.GetString(1),
                    Nombrecategoria = LeerFilas.GetString(2),
                    Descripcioncategoria = LeerFilas.GetString(3)
                });
            }

            conexion.Close();
            LeerFilas.Close();

            return Listar;
        }

        public void InsertarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCATEGORIA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Categoria.Nombrecategoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Categoria.Descripcioncategoria);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", Categoria.Idcategoria);
            cmd.Parameters.AddWithValue("@NOMBRE", Categoria.Nombrecategoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Categoria.Descripcioncategoria);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCategoria(E_Categoria Categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINACATEGORIA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCATEGORIA", Categoria.Idcategoria);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
