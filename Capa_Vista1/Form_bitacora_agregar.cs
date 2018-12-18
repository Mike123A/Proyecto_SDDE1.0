using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Negocios;

namespace Capa_Vista1
{
    public partial class Form_bitacora_agregar : Form
    {
        public Form_bitacora_agregar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            entBitacoras entbitacoras = new entBitacoras();
            entbitacoras.Dispositivo = cmbDispositivos.Text;
            if (rdbR.Checked)
            {
                entbitacoras.Estatus = "Resuelto";
            }
            else
            {
                entbitacoras.Estatus = "En proceso";
            }
            entbitacoras.Problema = rtxtProblema.Text;
            entbitacoras.Recomendacion = rtxtRecomendacion.Text;
            negBitacora negbitacora = new negBitacora();
            negbitacora.InsertarDato(entbitacoras);
            

            this.Close();
        }
    }
}
