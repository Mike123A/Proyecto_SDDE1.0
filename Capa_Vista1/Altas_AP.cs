using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista1
{
    public partial class Altas_AP : Form
    {
        public Altas_AP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agre_Conex_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_SSDI form = new MiniVentanas.Min_SSDI();
            form.Show();
        }
    }
}
