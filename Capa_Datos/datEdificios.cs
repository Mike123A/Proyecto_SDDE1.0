using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Datos
{
    public class datEdificios
    {
        public DataTable CargarDatos()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("stp_Consulta_Edificios", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarDato(entEdificio edificio)
        {
            var comando = new SqlCommand("stp_Inserta_Edificios", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_Edificio", edificio.NombreE);
            comando.Parameters.AddWithValue("@Calle", edificio.Calle);
            comando.Parameters.AddWithValue("@N_Exte", edificio.NumE);
            comando.Parameters.AddWithValue("@Colonia", edificio.Colonia);
            comando.Parameters.AddWithValue("@Cruzamientos", edificio.Cruzamientos);
            comando.Parameters.AddWithValue("@CP", edificio.CP);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Conexion.CerrarConexion();
        }
        public void ActualizaDato(entEdificio edificio)
        {

            var comando = new SqlCommand("stp_Actualiza_Edificios", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEdificios", edificio.idEdificio);
            comando.Parameters.AddWithValue("@Nombre_Edificio", edificio.NombreE);
            comando.Parameters.AddWithValue("@Calle", edificio.Calle);
            comando.Parameters.AddWithValue("@N_Exte", edificio.NumE);
            comando.Parameters.AddWithValue("@Colonia", edificio.Colonia);
            comando.Parameters.AddWithValue("@Cruzamientos",edificio.Cruzamientos );
            comando.Parameters.AddWithValue("@CP", edificio.CP);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Conexion.CerrarConexion();
        }
        public void EliminaDato(entEdificio edificio)
        {

            var comando = new SqlCommand("stp_Elimina_Edificios", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEdificios", edificio.idEdificio);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Conexion.CerrarConexion();
        }
    }
}
