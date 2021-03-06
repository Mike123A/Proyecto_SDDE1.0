﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocios
{
    public class negCatComunes
    {
        public DataTable CargarDatosMarcas()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosMarcas();
        }
        ///
        public void InsertarMarca(string Marca)
        {
            datCatComunes datcatcomunes = new datCatComunes();
            datcatcomunes.InsertarMarca(Marca);
        }

        public void InsertarSDDI(string SDDI)
        {
            datCatComunes datcatcomunes = new datCatComunes();
            datcatcomunes.InsertarSDDI(SDDI);
        }
        ///
        public void InsertarProveedor(string Proveedor)
        {
            datCatComunes datcatcomunes = new datCatComunes();
            datcatcomunes.InsertarProveedor(Proveedor);
        }
        ///
        public DataTable CargarDatosModelos()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosModelos();
        }
        //
        public void InsertarModelo(string Modelo)
        {
            datCatComunes datcatcomunes = new datCatComunes();
            datcatcomunes.InsertarModelo(Modelo);
        }
        //
        public DataTable CargarDatosSite(int edificio)
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosSites(edificio);
        }
        //
        public DataTable CargarDatosEdificios()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosEdificios();
        }
        //
        public DataTable CargarDatosSSID()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosSSID();
        }
        //
        public DataTable CargarDatosSeguridad()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosSeguridad();
        }
        //
        public DataTable CargarDatosModo()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosModo();
        }
        //
        public DataTable CargarDatosUser()
        {
            datCatComunes datcatcomunes = new datCatComunes();
            return datcatcomunes.CargarDatosUser();
        }
        public void InsertarModo(string Modo)
        {
            datCatComunes datcatcomunes = new datCatComunes();
            datcatcomunes.InsertarModo(Modo);
        }


    }
}
