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
    public class negRadios
    {
        public DataTable CargarDatos()
        {
            datRadios datradios = new datRadios();
            return datradios.CargarDatos();
        }
        public void InsertarDato(entRadio entradio)
        {
            datRadios datradios = new datRadios();
            datradios.InsertarDato(entradio);
        }
        public void ActualizaDato(entRadio entradio)
        {
            datRadios datradios = new datRadios();
            datradios.ActualizaDato(entradio);
        }
        public void EliminaDato(entRadio entradio)
        {
            datRadios datradios = new datRadios();
            datradios.EliminaDato(entradio);
        }
    }
}
