using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocios
{
    public class negBitacora
    {
        public DataTable CargarDatos()
        {
            datBitacora datbitacora = new datBitacora();
            return datbitacora.CargarDatos();
        }
        public void InsertarDato(entBitacoras bitacora)
        {
            datBitacora datbitacora = new datBitacora();
            datbitacora.InsertarDato(bitacora);
        }
    }
}
