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
    public partial class Form_Edificios : Form
    {
        bool Nuevo;
        public Form_Edificios()
        {
            InitializeComponent();
        }
        public void InhabilitaObjetos()
        {
            txtNombre.Enabled = false;
            txtCalle.Enabled = false;
            txtColonia.Enabled = false;
            txtNum.Enabled = false;
            txtCruzamientos.Enabled = false;
            txtCP.Enabled = false;
        }
        public void HabilitaObjetos()
        {
            txtNombre.Enabled = true;
            txtCalle.Enabled = true;
            txtColonia.Enabled = true;
            txtNum.Enabled = true;
            txtCruzamientos.Enabled = true;
            txtCP.Enabled = true;
        }
        public void LimpiaObjetos()
        {
            txtNombre.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtNum.Text = "";
            txtCruzamientos.Text = "";
            txtCP.Text = "";
        }
        public void CargarDGV()
        {
            negEdficios negedificios = new negEdficios();
            dgvEdificios.DataSource = negedificios.CargarDatos();
        }

        private void Form_Edificios_Load(object sender, EventArgs e)
        {
            CargarDGV();
            InhabilitaObjetos();
            LimpiaObjetos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HabilitaObjetos();
            LimpiaObjetos();
            Nuevo = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HabilitaObjetos();
            Nuevo = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            negEdficios negedificios = new negEdficios();
            entEdificio entedificio = new entEdificio();
            entedificio.NombreE= txtNombre.Text;
            entedificio.Calle= txtCalle.Text;
            entedificio.Colonia= txtColonia.Text;
            entedificio.NumE= txtNum.Text;
            entedificio.Cruzamientos = txtCruzamientos.Text;
            entedificio.CP = txtCP.Text;
            if (Nuevo)
            {
                negedificios.InsertarDato(entedificio);
            }
            else
            {
                entedificio.idEdificio = Convert.ToInt32( dgvEdificios.CurrentRow.Cells["Clave"].Value.ToString());
                negedificios.ActualizaDato(entedificio);
            }
            CargarDGV();
            InhabilitaObjetos();
            LimpiaObjetos();

        }

        private void dgvEdificios_SelectionChanged(object sender, EventArgs e)
        {
            
            txtNombre.Text = dgvEdificios.CurrentRow.Cells["Edificio"].Value.ToString();
            txtCalle.Text = dgvEdificios.CurrentRow.Cells["Calle"].Value.ToString();
            txtColonia.Text = dgvEdificios.CurrentRow.Cells["Colonia"].Value.ToString();
            txtNum.Text = dgvEdificios.CurrentRow.Cells["Numero"].Value.ToString();
            txtCruzamientos.Text = dgvEdificios.CurrentRow.Cells["Cruzamientos"].Value.ToString();
            txtCP.Text = dgvEdificios.CurrentRow.Cells["CP"].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            negEdficios negedificios = new negEdficios();
            entEdificio entedificio = new entEdificio();
            entedificio.idEdificio = Convert.ToInt32(dgvEdificios.CurrentRow.Cells["Clave"].Value.ToString());
            negedificios.EliminaDato(entedificio);
            CargarDGV();
            InhabilitaObjetos();
            LimpiaObjetos();
        }
    }
}
