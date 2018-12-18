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
    public partial class Form_Radio : Form
    {
        bool Nuevo;
        public Form_Radio()
        {
            InitializeComponent();
        }

        private void Form_Radio_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            //CargarDGV();
            InhabilitarObjetos();
            LimpiarObjetos();
        }
        public void LlenarCombos()
        {
            negCatComunes negcatcomunes = new negCatComunes();
            cmbEdificio.DataSource = negcatcomunes.CargarDatosEdificios();
            cmbEdificio.ValueMember = "idEdificios";
            cmbEdificio.DisplayMember = "Nombre_Edificio";
            //cmbMarca.DataSource = negcatcomunes.CargarDatosMarcas();
            //cmbMarca.ValueMember = "idMarca";
            //cmbMarca.DisplayMember = "Marca";
            //cmbModelo.DataSource = negcatcomunes.CargarDatosModelos();
            //cmbModelo.ValueMember = "idModelo";
            //cmbModelo.DisplayMember = "Modelo";
            cmbSSID.DataSource = negcatcomunes.CargarDatosSSID();
            cmbSSID.ValueMember = "idSSID";
            cmbSSID.DisplayMember = "SSID";
            cmbSeguridad.DataSource = negcatcomunes.CargarDatosSeguridad();
            cmbSeguridad.ValueMember = "idSeguridad";
            cmbSeguridad.DisplayMember = "Seguridad";
            cmbModo.DataSource = negcatcomunes.CargarDatosModo();
            cmbModo.ValueMember = "idModo";
            cmbModo.DisplayMember = "Modo";
        }
        public void CargarDGV()
        {
            negRadios negradios = new negRadios();
            //dgvRadios.DataSource = negradios.CargarDatos();
        }
        public void InhabilitarObjetos()
        {
            cmbEdificio.Enabled = false;
            //cmbMarca.Enabled = false;
            //cmbModelo.Enabled = false;
            txtHostName.Enabled = false;
            //cmbSSID.Enabled = false;
            //txtSerie.Enabled = false;
            //txtMac.Enabled = false;
            txtIp.Enabled = false;
            txtMascara.Enabled = false;
            txtGateway.Enabled = false;
            cmbSeguridad.Enabled = false;
            cmbModo.Enabled = false;
        }
        public void HabilitarObjetos()
        {
            cmbEdificio.Enabled = true;
            //cmbMarca.Enabled = true;
            //cmbModelo.Enabled = true;
            txtHostName.Enabled = true;
            cmbSSID.Enabled = true;
            //txtSerie.Enabled = true;
            //txtMac.Enabled = true;
            txtIp.Enabled = true;
            txtMascara.Enabled = true;
            txtGateway.Enabled = true;
            cmbSeguridad.Enabled = true;
            cmbModo.Enabled = true;
        }
        public void LimpiarObjetos()
        {
            cmbEdificio.Text = "";
            //cmbMarca.Text = "";
            //cmbModelo.Text = "";
            txtHostName.Text = "";
            cmbSSID.Text = "";
            //txtSerie.Text = "";
            //txtMac.Text = "";
            txtIp.Text = "";
            txtMascara.Text = "";
            txtGateway.Text = "";
            cmbSeguridad.Text = "";
            cmbModo.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            HabilitarObjetos();
            LimpiarObjetos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            negRadios negradios = new negRadios();
            entRadio entradio = new entRadio();
            entradio.Edificio = Convert.ToInt32(cmbEdificio.SelectedValue);
            //entradio.Marca = Convert.ToInt32(cmbMarca.SelectedValue);
            //entradio.Modelo = Convert.ToInt32(cmbModelo.SelectedValue);
            entradio.HostName = txtHostName.Text;
            entradio.SSID = Convert.ToInt32(cmbSSID.SelectedValue);
            //entradio.Serie = txtSerie.Text;
            //entradio.Mac = txtMac.Text;
            entradio.Ip = txtIp.Text;
            entradio.Mascara = txtMascara.Text;
            entradio.Gateway = txtGateway.Text;
            entradio.Seguridad = Convert.ToInt32(cmbSeguridad.SelectedValue);
            entradio.Modo = Convert.ToInt32(cmbModo.SelectedValue);
            if (Nuevo)
            {
                negradios.InsertarDato(entradio);
            }
            else
            {
                //entradio.idRadio = Convert.ToInt32(dgvRadios.CurrentRow.Cells["Clave"].Value.ToString());
                negradios.ActualizaDato(entradio);
            }
            InhabilitarObjetos();
            LimpiarObjetos();
            CargarDGV();
        }

        private void dgvRadios_SelectionChanged(object sender, EventArgs e)
        {
            LimpiarObjetos();
            //cmbEdificio.Text = dgvRadios.CurrentRow.Cells["Edificio"].Value.ToString();
            //cmbMarca.Text = dgvRadios.CurrentRow.Cells["Marca"].Value.ToString();
            //cmbModelo.Text = dgvRadios.CurrentRow.Cells["Modelo"].Value.ToString();
            //txtHostName.Text = dgvRadios.CurrentRow.Cells["HostName"].Value.ToString();
            //cmbSSID.Text = dgvRadios.CurrentRow.Cells["SSID"].Value.ToString();
            //txtSerie.Text = dgvRadios.CurrentRow.Cells["Serie"].Value.ToString();
            //txtMac.Text = dgvRadios.CurrentRow.Cells["Mac"].Value.ToString();
            //txtIp.Text = dgvRadios.CurrentRow.Cells["Ip"].Value.ToString();
            //txtMascara.Text = dgvRadios.CurrentRow.Cells["Mascara"].Value.ToString();
            //txtGateway.Text = dgvRadios.CurrentRow.Cells["Gateway"].Value.ToString();
            //cmbSeguridad.Text = dgvRadios.CurrentRow.Cells["Seguridad"].Value.ToString();
            //cmbModo.Text = dgvRadios.CurrentRow.Cells["Modo"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            HabilitarObjetos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            negRadios negradios = new negRadios();
            entRadio entradio = new entRadio();
            //entradio.idRadio = Convert.ToInt32(dgvRadios.CurrentRow.Cells["Clave"].Value.ToString());
            negradios.EliminaDato(entradio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_Marca form = new MiniVentanas.Min_Marca();
            form.Show();
        }

        private void cmbMarca_MouseClick(object sender, MouseEventArgs e)
        {
            LlenarCombos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
