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
    public class datCatComunes
    {
        public DataTable CargarDatosMarcas()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_Marca;", Conexion.AbrirConexion()); 
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarMarca(string Marcas)
        {
            var comando = new SqlCommand("INSERT INTO[dbo].[Cat_Marca]([Marca])VALUES ('"+ Marcas +"')", Conexion.AbrirConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            Conexion.CerrarConexion();
        }

        public void InsertarSite(string Site)
        {
            var comando = new SqlCommand("INSERT INTO[dbo].[Cat_Site]([Site])VALUES ('" + Site + "')", Conexion.AbrirConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            Conexion.CerrarConexion();
        }


        public void InsertarModo(string Modo)
        {
            var comando = new SqlCommand("INSERT INTO[dbo].[Cat_Modo]([Modo])VALUES ('" + Modo + "')", Conexion.AbrirConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            Conexion.CerrarConexion();
        }
        public DataTable CargarDatosEdificios()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_Edificios;", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public DataTable CargarDatosModelos()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_Modelo;", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarModelo(string Modelo)
        {
            var comando = new SqlCommand("INSERT INTO[dbo].[Cat_Modelo]([Modelo])VALUES ('" + Modelo + "')", Conexion.AbrirConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            Conexion.CerrarConexion();
        }

        public void InsertarProveedor(string Proveedor)
        {
            var comando = new SqlCommand("INSERT INTO[dbo].[Cat_Proveedor]([Proveedor])VALUES ('" + Proveedor + "')", Conexion.AbrirConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            Conexion.CerrarConexion();
        }
        public DataTable CargarDatosSites(int edificio)
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_Site where idEdificio = '"+edificio+"';", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public DataTable CargarDatosSSID()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_SSID;", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public void InsertarSDDI(string SSID)
        {
            var comando = new SqlCommand("INSERT INTO[dbo].[Cat_SSID]([SSID])VALUES ('" + SSID + "')", Conexion.AbrirConexion());
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            Conexion.CerrarConexion();
        }

        /// /////////////////////
     
        public DataTable CargarDatosSeguridad()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_Seguridad;", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public DataTable CargarDatosModo()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_Modo;", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }
        public DataTable CargarDatosUser()
        {
            DataTable dtd = new DataTable();
            var comando = new SqlCommand("select * from Cat_User;", Conexion.AbrirConexion());
            SqlDataReader dr = comando.ExecuteReader();
            dtd.Clear();
            dtd.Load(dr);
            Conexion.CerrarConexion();
            return dtd;
        }



    }
}
