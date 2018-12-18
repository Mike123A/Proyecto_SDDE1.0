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
    public class datSwitches
    {
        public DataTable CargarDatos()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("stp_Consulta_Switches", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarDato(entSwitches entswitch)
        {

            var comando = new SqlCommand("stp_Inserta_Switch", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Serie_Sw", entswitch.Serie);
            comando.Parameters.AddWithValue("@Mac_Sw", entswitch.Mac);
            comando.Parameters.AddWithValue("@Ip_Sw", entswitch.Ip);
            comando.Parameters.AddWithValue("@Msk", entswitch.Mascara);
            comando.Parameters.AddWithValue("@Gw", entswitch.Gateway);
            comando.Parameters.AddWithValue("@Tip_Conex", entswitch.TConexion);
            comando.Parameters.AddWithValue("@idMarca", entswitch.Marca);
            comando.Parameters.AddWithValue("@idModelo", entswitch.Modelo);
            comando.Parameters.AddWithValue("@idSite", entswitch.Site);
            comando.Parameters.AddWithValue("@idEdificio", entswitch.Edificio);
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
        public void ActualizaDato(entSwitches entswitch)
        {

            var comando = new SqlCommand("stp_Actualiza_Switch", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSwitch", entswitch.idSwitch);
            comando.Parameters.AddWithValue("@Serie_Sw", entswitch.Serie);
            comando.Parameters.AddWithValue("@Mac_Sw", entswitch.Mac);
            comando.Parameters.AddWithValue("@Ip_Sw", entswitch.Ip);
            comando.Parameters.AddWithValue("@Msk", entswitch.Mascara);
            comando.Parameters.AddWithValue("@Gw", entswitch.Gateway);
            comando.Parameters.AddWithValue("@Tip_Conex", entswitch.TConexion);
            comando.Parameters.AddWithValue("@idMarca", entswitch.Marca);
            comando.Parameters.AddWithValue("@idModelo", entswitch.Modelo);
            comando.Parameters.AddWithValue("@idSite", entswitch.Site);
            comando.Parameters.AddWithValue("@idEdificio", entswitch.Edificio);
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
        public void EliminaDato(entSwitches entswitch)
        {

            var comando = new SqlCommand("stp_Elimina_Switch", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSwitch", entswitch.idSwitch);
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
