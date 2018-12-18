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
    public class datBitacora
    {
        public DataTable CargarDatos()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("stp_Consulta_Bitacora", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarDato(entBitacoras bitacora)
        {
            var comando = new SqlCommand("stp_Inserta_Bitacora", Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Dispositivo", bitacora.Dispositivo);
            comando.Parameters.AddWithValue("@Status", bitacora.Estatus);
            comando.Parameters.AddWithValue("@Problema", bitacora.Problema);
            comando.Parameters.AddWithValue("@Recomendacion", bitacora.Recomendacion);
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
