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
    public partial class Altas_Radio : Form
    {
        public Altas_Radio()
        {
            InitializeComponent();
        }

        private void btn_asigSW_Click(object sender, EventArgs e)
        {
            Form_Radio formsw = new Form_Radio();
            formsw.Show();
        }
    }
}
