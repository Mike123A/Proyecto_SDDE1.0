using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class entRadio
    {
        public int idRadio { get; set; }
        public int Edificio { get; set; }
        public int Marca { get; set; }
        public int Modelo { get; set; }
        public string HostName { get; set; }
        public int SSID { get; set; }
        public string Serie { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public string Mascara { get; set; }
        public string Gateway { get; set; }
        public int Seguridad { get; set; }
        public int Modo { get; set; }
    }
}
