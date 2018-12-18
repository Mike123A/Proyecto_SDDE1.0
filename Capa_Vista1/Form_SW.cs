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
using Capa_Entidades;

namespace Capa_Vista1
{
    public partial class Form_SW : Form
    {
        bool Nuevo;
        public Form_SW()
        {
            InitializeComponent();
        }

        private void Form_SW_Load(object sender, EventArgs e)
        {
            LlenarCombos();
            CargarDGV();
            limpiarobjetos();
            //hinabilitarrobjetos();
        }
        public void LlenarCombos()
        {
            negCatComunes negcatcomunes = new negCatComunes();
            //cmbMarca.DataSource = negcatcomunes.CargarDatosMarcas();
            //cmbMarca.ValueMember = "idMarca";
            //cmbMarca.DisplayMember = "Marca";
            //cmbModelo.DataSource = negcatcomunes.CargarDatosModelos();
            //cmbModelo.ValueMember = "idModelo";
            //cmbModelo.DisplayMember = "Modelo";
            cmbEdificios.DataSource = negcatcomunes.CargarDatosEdificios();
            cmbEdificios.ValueMember = "idEdificios";
            cmbEdificios.DisplayMember = "Nombre_Edificio";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            negSwitches negswitches = new negSwitches();
            entSwitches entswitch = new entSwitches();
            if (Nuevo)
            {
                entswitch.Edificio = Convert.ToInt32(cmbEdificios.SelectedValue);
                //entswitch.Marca = Convert.ToInt32(cmbMarca.SelectedValue);
                //entswitch.Modelo = Convert.ToInt32(cmbModelo.SelectedValue);
                //entswitch.Serie = txtSerie.Text;
                if (rdbSSH.Checked)
                {
                    entswitch.TConexion = "SSH";
                }
                if (rdbTelnet.Checked)
                {
                    entswitch.TConexion = "Telnet";
                }
                //entswitch.Mac = txtMac.Text;
                entswitch.Ip = txtIp.Text;
                entswitch.Mascara = txtMascara.Text;
                entswitch.Gateway = txtGateway.Text;
                entswitch.Site = Convert.ToInt32(cmbSite.SelectedValue);
                negswitches.InsertarDato(entswitch);
            }
            else
            {
                //entswitch.idSwitch= Convert.ToInt32(dgvSwitches.CurrentRow.Cells["Clave"].Value.ToString());
                entswitch.Edificio = Convert.ToInt32(cmbEdificios.SelectedValue);
                //entswitch.Marca = Convert.ToInt32(cmbMarca.SelectedValue);
                //entswitch.Modelo = Convert.ToInt32(cmbModelo.SelectedValue);
                //entswitch.Serie = txtSerie.Text;
                if (rdbSSH.Checked)
                {
                    entswitch.TConexion = "SSH";
                }
                if (rdbTelnet.Checked)
                {
                    entswitch.TConexion = "Telnet";
                }
                //entswitch.Mac = txtMac.Text;
                entswitch.Ip = txtIp.Text;
                entswitch.Mascara = txtMascara.Text;
                entswitch.Gateway = txtGateway.Text;
                entswitch.Site = Convert.ToInt32(cmbSite.SelectedValue);
                negswitches.ActualizaDato(entswitch);
            }
            CargarDGV();
            limpiarobjetos();
            hinabilitarrobjetos();
        }
        public void CargarDGV()
        {
            negSwitches negswitches = new negSwitches();

            //dgvSwitches.DataSource = negswitches.CargarDatos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            habilitarrobjetos();
        }
        public void limpiarobjetos()
        {
            cmbEdificios.Text = "";
            //cmbMarca.Text = "";
            //cmbModelo.Text = "";
            //txtSerie.Text = "";
            rdbSSH.Checked = false;
            rdbTelnet.Checked = false;
            //txtMac.Text = "";
            txtIp.Text = "";
            txtMascara.Text = "";
            txtGateway.Text = "";
            cmbSite.Text = "";
        }
        public void hinabilitarrobjetos()
        {
            cmbEdificios.Enabled = false;
            //cmbMarca.Enabled = false;
            //cmbModelo.Enabled = false;
            //txtSerie.Enabled = false;
            rdbSSH.Enabled = false;
            rdbTelnet.Enabled = false;
            //txtMac.Enabled = false;
            txtIp.Enabled = false;
            txtMascara.Enabled = false;
            txtGateway.Enabled = false;
            cmbSite.Enabled = false;
        }
        public void habilitarrobjetos()
        {
            cmbEdificios.Enabled = true;
            //cmbMarca.Enabled = true;
            //cmbModelo.Enabled = true;
            //txtSerie.Enabled = true;
            rdbSSH.Enabled = true;
            rdbTelnet.Enabled = true;
            //txtMac.Enabled = true;
            txtIp.Enabled = true;
            txtMascara.Enabled = true;
            txtGateway.Enabled = true;
            cmbSite.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSwitches_SelectionChanged(object sender, EventArgs e)
        {
            //    limpiarobjetos();
            //    cmbEdificios.Text = dgvSwitches.CurrentRow.Cells["Edificio"].Value.ToString();
            //    cmbMarca.Text = dgvSwitches.CurrentRow.Cells["Marca"].Value.ToString();
            //    cmbModelo.Text = dgvSwitches.CurrentRow.Cells["Modelo"].Value.ToString();
            //    txtSerie.Text = dgvSwitches.CurrentRow.Cells["Serie"].Value.ToString();
            //    if (dgvSwitches.CurrentRow.Cells["Conexion"].Value.ToString() == "SSH")
            //        rdbSSH.Checked = true;
            //    if (dgvSwitches.CurrentRow.Cells["Conexion"].Value.ToString() == "Telnet")
            //        rdbTelnet.Checked = true;
            //    txtMac.Text = dgvSwitches.CurrentRow.Cells["Mac"].Value.ToString();
            //    txtIp.Text = dgvSwitches.CurrentRow.Cells["Ip"].Value.ToString();
            //    txtMascara.Text = dgvSwitches.CurrentRow.Cells["Mascara"].Value.ToString();
            //    txtGateway.Text = dgvSwitches.CurrentRow.Cells["Gateway"].Value.ToString();
            //    cmbSite.Text = dgvSwitches.CurrentRow.Cells["Site"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            negSwitches negswitches = new negSwitches();
            entSwitches entswitches = new entSwitches();
            //entswitches.idSwitch = Convert.ToInt32(dgvSwitches.CurrentRow.Cells["Clave"].Value.ToString());
            negswitches.EliminaDato(entswitches);
            CargarDGV();
        }

        private void cmbEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbEdificios_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbSite_Click(object sender, EventArgs e)
        {
            negCatComunes negcatcomunes = new negCatComunes();
            int Ed = Convert.ToInt32(cmbEdificios.SelectedValue);
            //MessageBox.Show(Ed.ToString());
            cmbSite.DataSource = negcatcomunes.CargarDatosSite(Ed);
            cmbSite.ValueMember = "idSite";
            cmbSite.DisplayMember = "NSite";
        }
    }
}
