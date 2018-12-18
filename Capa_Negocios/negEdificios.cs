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
    public class negEdficios
    {
        public DataTable CargarDatos()
        {
            datEdificios datedificio = new datEdificios();
            return datedificio.CargarDatos();
        }
        public void InsertarDato(entEdificio edificio)
        {
            datEdificios datedificio = new datEdificios();

            datedificio.InsertarDato(edificio);
        }
        public void ActualizaDato(entEdificio edificio)
        {
            datEdificios datedificio = new datEdificios();

            datedificio.ActualizaDato(edificio);
        }
        public void EliminaDato(entEdificio edificio)
        {
            datEdificios datedificio = new datEdificios();

            datedificio.EliminaDato(edificio);
        }
    }
}
