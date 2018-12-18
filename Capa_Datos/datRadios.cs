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
    public class datRadios
    {
        public DataTable CargarDatos()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("stp_Consulta_Radios", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarDato(entRadio entradio)
        {
            var comando = new SqlCommand("stp_Inserta_Radio", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEdificios", entradio.Edificio);
            comando.Parameters.AddWithValue("@idMarca", entradio.Marca);
            comando.Parameters.AddWithValue("@idModelo", entradio.Modelo);
            comando.Parameters.AddWithValue("@HostName", entradio.HostName);
            comando.Parameters.AddWithValue("@idSSID", entradio.SSID);
            comando.Parameters.AddWithValue("@Serie", entradio.Serie);
            comando.Parameters.AddWithValue("@Mac", entradio.Mac);
            comando.Parameters.AddWithValue("@Ip", entradio.Ip);
            comando.Parameters.AddWithValue("@Msk", entradio.Mascara);
            comando.Parameters.AddWithValue("@Gw", entradio.Gateway);
            comando.Parameters.AddWithValue("@idSeguridad", entradio.Seguridad);
            comando.Parameters.AddWithValue("@idModo", entradio.Modo);
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
        public void ActualizaDato(entRadio entradio)
        {

            var comando = new SqlCommand("stp_Actualiza_Radio", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idRadios", entradio.idRadio);
            comando.Parameters.AddWithValue("@idEdificios", entradio.Edificio);
            comando.Parameters.AddWithValue("@idMarca", entradio.Marca);
            comando.Parameters.AddWithValue("@idModelo", entradio.Modelo);
            comando.Parameters.AddWithValue("@HostName", entradio.HostName);
            comando.Parameters.AddWithValue("@idSSID", entradio.SSID);
            comando.Parameters.AddWithValue("@Serie", entradio.Serie);
            comando.Parameters.AddWithValue("@Mac", entradio.Mac);
            comando.Parameters.AddWithValue("@Ip", entradio.Ip);
            comando.Parameters.AddWithValue("@Msk", entradio.Mascara);
            comando.Parameters.AddWithValue("@Gw", entradio.Gateway);
            comando.Parameters.AddWithValue("@idSeguridad", entradio.Seguridad);
            comando.Parameters.AddWithValue("@idModo", entradio.Modo);

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
        public void EliminaDato(entRadio entradio)
        {

            var comando = new SqlCommand("stp_Elimina_Radio", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idRadios", entradio.idRadio);
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
