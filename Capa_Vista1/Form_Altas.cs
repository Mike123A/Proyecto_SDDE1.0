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
    public partial class Form_Altas : Form
    {
        public Form_Altas()
        {
            InitializeComponent();
        }

           public void LlenarCombos()
        {
            //negCatComunes negcatcomunes = new negCatComunes();
            //cmbMarca.DataSource = negcatcomunes.CargarDatosMarcas();
            //cmbMarca.ValueMember = "idMarca";
            //cmbMarca.DisplayMember = "Marca";
            //cmbModelo.DataSource = negcatcomunes.CargarDatosModelos();
            //cmbModelo.ValueMember = "idModelo";
            //cmbModelo.DisplayMember = "Modelo";
            //cmbEdificios.DataSource = negcatcomunes.CargarDatosEdificios();
            //cmbEdificios.ValueMember = "idEdificios";
            //cmbEdificios.DisplayMember = "Nombre_Edificio";
        }
        //public void AbrirVentana(object formhijo)
        //{
        //    Form fh = formhijo as Form;
        //    fh.TopLevel = false;
        //    this.panelcont2.Controls.Clear();
        //    this.panelcont2.Controls.Add(fh);
        //    this.panelcont2.Tag = fh;
        //    fh.FormBorderStyle = FormBorderStyle.None;
        //    fh.Dock = DockStyle.Fill;
        //    fh.Show();
        //    fh.WindowState = FormWindowState.Maximized;
        //}

        private void Form_Altas_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_asigSW_Click(object sender, EventArgs e)
        {
            Form_SW formsw = new Form_SW();
            formsw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_Marca form = new MiniVentanas.Min_Marca();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_Modelo form = new MiniVentanas.Min_Modelo();
            form.Show();
        }

        private void Mas_proveedor_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_Proveedor form = new MiniVentanas.Min_Proveedor();
            form.Show();
        }
    }
}
