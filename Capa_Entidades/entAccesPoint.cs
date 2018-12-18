using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class entAccesPoint
    {
        public int idAccesPoint { get; set; }
        public int Edificio { get; set; }
        public int Marca { get; set; }
        public int Modelo { get; set; }
        public string HostName { get; set; }
        public int SSID { get; set; }
        public string Serie { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public int User { get; set; }
        public string Pass { get; set; }
        public string Key { get; set; }
        public int Seguridad { get; set; }
        public string Estado { get; set; }
    }
}
