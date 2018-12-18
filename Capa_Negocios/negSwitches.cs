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
    public class negSwitches
    {
        public DataTable CargarDatos()
        {
            datSwitches datswitches = new datSwitches();
            return datswitches.CargarDatos();
        }
        public void InsertarDato(entSwitches entswitch)
        {
            datSwitches datswitches = new datSwitches();
            datswitches.InsertarDato(entswitch);
        }
        public void ActualizaDato(entSwitches entswitch)
        {
            datSwitches datswitches = new datSwitches();
            datswitches.ActualizaDato(entswitch);
        }
        public void EliminaDato(entSwitches entswitch)
        {
            datSwitches datswitches = new datSwitches();
            datswitches.EliminaDato(entswitch);
        }
    }
}
