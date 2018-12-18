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
    public class datAccesPoint
    {
        public DataTable CargarDatos()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("stp_Consulta_AP", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarDato(entAccesPoint accespoint)
        {
            var comando = new SqlCommand("stp_Inserta_AP", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEdificio", accespoint.Edificio);
            comando.Parameters.AddWithValue("@idMarca", accespoint.Marca);
            comando.Parameters.AddWithValue("@idModelo", accespoint.Modelo);
            comando.Parameters.AddWithValue("@HostName", accespoint.HostName);
            comando.Parameters.AddWithValue("@idSSID", accespoint.SSID);
            comando.Parameters.AddWithValue("@Serie_Aps", accespoint.Serie);
            comando.Parameters.AddWithValue("@Mac", accespoint.Mac);
            comando.Parameters.AddWithValue("@Ip_Aps", accespoint.Ip);
            comando.Parameters.AddWithValue("@idUser", accespoint.User);
            comando.Parameters.AddWithValue("@Pass", accespoint.Pass);
            comando.Parameters.AddWithValue("@keys", accespoint.Key);
            comando.Parameters.AddWithValue("@idSeguridad", accespoint.Seguridad);
            comando.Parameters.AddWithValue("@Estado", accespoint.Estado);
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
        public void ActualizaDato(entAccesPoint accespoint)
        {

            var comando = new SqlCommand("stp_Actualiza_AP", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAps", accespoint.idAccesPoint);
            comando.Parameters.AddWithValue("@idEdificio", accespoint.Edificio);
            comando.Parameters.AddWithValue("@idMarca", accespoint.Marca);
            comando.Parameters.AddWithValue("@idModelo", accespoint.Modelo);
            comando.Parameters.AddWithValue("@HostName", accespoint.HostName);
            comando.Parameters.AddWithValue("@idSSID", accespoint.SSID);
            comando.Parameters.AddWithValue("@Serie_Aps", accespoint.Serie);
            comando.Parameters.AddWithValue("@Mac", accespoint.Mac);
            comando.Parameters.AddWithValue("@Ip_Aps", accespoint.Ip);
            comando.Parameters.AddWithValue("@idUser", accespoint.User);
            comando.Parameters.AddWithValue("@Pass", accespoint.Pass);
            comando.Parameters.AddWithValue("@keys", accespoint.Key);
            comando.Parameters.AddWithValue("@idSeguridad", accespoint.Seguridad);
            comando.Parameters.AddWithValue("@Estado", accespoint.Estado);

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
        public void EliminaDato(entAccesPoint accespoint)
        {

            var comando = new SqlCommand("stp_Elimina_AP", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAps", accespoint.idAccesPoint);
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
