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
    public partial class Form_vivencias_principal : Form
    {
        public Form_vivencias_principal()
        {
            InitializeComponent();
        }
        public void AbrirVentana(object formhijo)
        {
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            this.panel_vivencias.Controls.Clear();
            this.panel_vivencias.Controls.Add(fh);
            this.panel_vivencias.Tag = fh;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.Show();
            fh.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String cb_vivencias = CB_vivencias.Text;

            switch (cb_vivencias)
            {
                case "Agregar": AbrirVentana(new Form_bitacora_agregar()); break;
                //case "Buscar": AbrirVentana(new Form_vivencias_buscar()); break;

            }
        }
    }
}
