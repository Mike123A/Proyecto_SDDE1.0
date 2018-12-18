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
    public partial class Form_Aps : Form
    {
        bool Nuevo;
        public Form_Aps()
        {
            InitializeComponent();
        }


        private void Form_Aps_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            InhabilitarObjetos();
            LimpiarObjetos();
            CargarDGV();
        }
        public void LlenarCombos()
        {
            negCatComunes negcatcomunes = new negCatComunes();
            cmbEdificios.DataSource = negcatcomunes.CargarDatosEdificios();
            cmbEdificios.ValueMember = "idEdificios";
            cmbEdificios.DisplayMember = "Nombre_Edificio";
            cmbMarca.DataSource = negcatcomunes.CargarDatosMarcas();
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.DisplayMember = "Marca";
            cmbModelo.DataSource = negcatcomunes.CargarDatosModelos();
            cmbModelo.ValueMember = "idModelo";
            cmbModelo.DisplayMember = "Modelo";
            cmbSSID.DataSource = negcatcomunes.CargarDatosSSID();
            cmbSSID.ValueMember = "idSSID";
            cmbSSID.DisplayMember = "SSID";
            cmbSeguridad.DataSource = negcatcomunes.CargarDatosSeguridad();
            cmbSeguridad.ValueMember = "idSeguridad";
            cmbSeguridad.DisplayMember = "Seguridad";
            cmbUser.DataSource = negcatcomunes.CargarDatosUser();
            cmbUser.ValueMember = "idUsers";
            cmbUser.DisplayMember = "Users";
        }


        public void InhabilitarObjetos()
        {
            cmbEdificios.Enabled = false;
            cmbMarca.Enabled = false;
            cmbModelo.Enabled = false;
            txtHostName.Enabled = false;
            cmbSSID.Enabled = false;
            txtSerie.Enabled = false;
            txtMac.Enabled = false;
            txtIp.Enabled = false;
            cmbUser.Enabled = false;
            txtPass.Enabled = false;
            txtKey.Enabled = false;
            cmbSeguridad.Enabled = false;
            rdbA.Enabled = false;
            rdbI.Enabled = false;
        }
        public void HabilitarObjetos()
        {
            cmbEdificios.Enabled = true;
            cmbMarca.Enabled = true;
            cmbModelo.Enabled = true;
            txtHostName.Enabled = true;
            cmbSSID.Enabled = true;
            txtSerie.Enabled = true;
            txtMac.Enabled = true;
            txtIp.Enabled = true;
            cmbUser.Enabled = true;
            txtPass.Enabled = true;
            txtKey.Enabled = true;
            cmbSeguridad.Enabled = true;
            rdbA.Enabled = true;
            rdbI.Enabled = true;
        }
        public void LimpiarObjetos()
        {
            cmbEdificios.Text = "";
            cmbMarca.Text = "";
            cmbModelo.Text = "";
            txtHostName.Text = "";
            cmbSSID.Text = "";
            txtSerie.Text = "";
            txtMac.Text = "";
            txtIp.Text = "";
            cmbUser.Text = "";
            txtPass.Text = "";
            txtKey.Text = "";
            cmbSeguridad.Text = "";
            rdbA.Checked = false;
            rdbI.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            HabilitarObjetos();
            LimpiarObjetos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            HabilitarObjetos();
        }
        public void CargarDGV()
        {
            negAccesPoint negaccespoint = new negAccesPoint();
            dgvAPs.DataSource = negaccespoint.CargarDatos();
        }

        private void dgvAPs_SelectionChanged(object sender, EventArgs e)
        {
            cmbEdificios.Text = dgvAPs.CurrentRow.Cells["Edificio"].Value.ToString();
            cmbMarca.Text = dgvAPs.CurrentRow.Cells["Marca"].Value.ToString();
            cmbModelo.Text = dgvAPs.CurrentRow.Cells["Modelo"].Value.ToString();
            txtHostName.Text = dgvAPs.CurrentRow.Cells["HostName"].Value.ToString();
            cmbSSID.Text = dgvAPs.CurrentRow.Cells["SSID"].Value.ToString();
            txtSerie.Text = dgvAPs.CurrentRow.Cells["Serie"].Value.ToString();
            txtMac.Text = dgvAPs.CurrentRow.Cells["Mac"].Value.ToString();
            txtIp.Text = dgvAPs.CurrentRow.Cells["Ip"].Value.ToString();
            cmbUser.Text = dgvAPs.CurrentRow.Cells["Users"].Value.ToString();
            txtPass.Text = dgvAPs.CurrentRow.Cells["Pass"].Value.ToString();
            txtKey.Text = dgvAPs.CurrentRow.Cells["keys"].Value.ToString();
            cmbSeguridad.Text = dgvAPs.CurrentRow.Cells["Seguridad"].Value.ToString();
            if (dgvAPs.CurrentRow.Cells["Estado"].Value.ToString() == "Activo")
            {
                rdbA.Checked = true;
            }
            else
            {
                rdbI.Checked = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            negAccesPoint negaccespoint = new negAccesPoint();
            entAccesPoint entaccespoint = new entAccesPoint();
            entaccespoint.Edificio = Convert.ToInt32(cmbEdificios.SelectedValue);
            entaccespoint.Marca = Convert.ToInt32(cmbEdificios.SelectedValue);
            entaccespoint.Modelo = Convert.ToInt32(cmbEdificios.SelectedValue);
            entaccespoint.HostName = txtHostName.Text;
            entaccespoint.SSID = Convert.ToInt32(cmbEdificios.SelectedValue);
            entaccespoint.Serie = txtSerie.Text;
            entaccespoint.Mac = txtMac.Text;
            entaccespoint.Ip = txtIp.Text;
            entaccespoint.User = Convert.ToInt32(cmbEdificios.SelectedValue);
            entaccespoint.Pass = txtPass.Text;
            entaccespoint.Key = txtKey.Text;
            entaccespoint.Seguridad = Convert.ToInt32(cmbEdificios.SelectedValue);
            if (rdbA.Checked)
            {
                entaccespoint.Estado = "Activo";
            }
            else
            {
                entaccespoint.Estado = "Inactivo";
            }
            if (Nuevo)
            {
                negaccespoint.InsertarDato(entaccespoint);
            }
            else
            {
                entaccespoint.idAccesPoint = Convert.ToInt32(dgvAPs.CurrentRow.Cells["Clave"].Value.ToString());
                negaccespoint.ActualizaDato(entaccespoint);
            }
            CargarDGV();
            InhabilitarObjetos();
            LimpiarObjetos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            negAccesPoint negaccespoint = new negAccesPoint();
            entAccesPoint entaccespoint = new entAccesPoint();
            entaccespoint.idAccesPoint = Convert.ToInt32(dgvAPs.CurrentRow.Cells["Clave"].Value.ToString());
            negaccespoint.EliminaDato(entaccespoint);
            CargarDGV();
            InhabilitarObjetos();
            LimpiarObjetos();
        }
    }
}
