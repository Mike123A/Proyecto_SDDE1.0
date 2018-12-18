using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    class Conexion
    {
        const string CadenaConexion = @"Data Source=localhost;Initial Catalog=bd_SDDE;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(CadenaConexion);

        public static SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public static void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
    }
}
