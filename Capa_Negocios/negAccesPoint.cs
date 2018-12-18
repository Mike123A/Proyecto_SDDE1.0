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
    public class negAccesPoint
    {
        public DataTable CargarDatos()
        {
            datAccesPoint dataccespoint = new datAccesPoint();
            return dataccespoint.CargarDatos();
        }
        public void InsertarDato(entAccesPoint accespoint)
        {
            datAccesPoint dataccespoint = new datAccesPoint();

            dataccespoint.InsertarDato(accespoint);
        }
        public void ActualizaDato(entAccesPoint accespoint)
        {
            datAccesPoint dataccespoint = new datAccesPoint();

            dataccespoint.ActualizaDato(accespoint);
        }
        public void EliminaDato(entAccesPoint accespoint)
        {
            datAccesPoint dataccespoint = new datAccesPoint();

            dataccespoint.EliminaDato(accespoint);
        }
    }
}
