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
    public partial class Form_Ordenes : Form
    {
        public Form_Ordenes()
        {
            InitializeComponent();
        }

        private void CB_Ordenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AbrirVentana(object formhijo)
        {
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            this.Panel_Ordenes_Add.Controls.Clear();
            this.Panel_Ordenes_Add.Controls.Add(fh);
            this.Panel_Ordenes_Add.Tag = fh;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.Show();
            fh.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cb_ordebes = CB_Ordenes.Text;

            switch (cb_ordebes)
            {
                case "Altas": AbrirVentana(new Form_Altas()); break;
                case "Bajas": AbrirVentana(new Form_Bajas()); break;
                case "Diagnostico": AbrirVentana(new Form_Diagnostico()); break;


            }
        }
    }
}
