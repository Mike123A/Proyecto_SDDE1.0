using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Vista1
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            Contabilizar();
        }

        public void Contabilizar()
        {
            negSwitches negswitches = new negSwitches();
            lblSwitches.Text = negswitches.CargarDatos().Rows.Count.ToString();
            negRadios negradios = new negRadios();
            lblRadios.Text = negradios.CargarDatos().Rows.Count.ToString();
            negAccesPoint negap = new negAccesPoint();
            lblAP.Text = negap.CargarDatos().Rows.Count.ToString();


        }
    }
}
