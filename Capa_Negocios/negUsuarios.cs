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
    public class negUsuarios
    {
        public DataTable CargarDatos()
        {
            datUsuarios datusuario = new datUsuarios();
            return datusuario.CargarDatos();
        }
        public void InsertarDato(entUsuario usuario)
        {
            datUsuarios datusuario = new datUsuarios();
            datusuario.InsertarDato(usuario);
        }
        public void ActualizaDato(entUsuario usuario)
        {
            datUsuarios datusuario = new datUsuarios();
            datusuario.ActualizaDato(usuario);
        }
        public void EliminaDato(entUsuario usuario)
        {
            datUsuarios datusuario = new datUsuarios();
            datusuario.EliminaDato(usuario);
        }
    }
}
