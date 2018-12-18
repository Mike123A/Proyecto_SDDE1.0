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
    public partial class Form_Usuarios : Form
    {
        bool Nuevo;
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDGV();
            LimpiaObjetos();
            InhabilitaObjetos();
            txtContra.UseSystemPasswordChar = true;
            txtConContra.UseSystemPasswordChar = true;
        }

        public void CargarDGV()
        {
            negUsuarios negusuarios = new negUsuarios();
            dgvUsuarios.DataSource = negusuarios.CargarDatos();
        }
        public void InhabilitaObjetos()
        {
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            txtTelefono.Enabled = false;
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            txtConContra.Enabled = false;
        }
        public void HabilitaObjetos()
        {
            txtNombre.Enabled = true;
            txtCorreo.Enabled = true;
            txtTelefono.Enabled = true;
            txtUsuario.Enabled = true;
            txtContra.Enabled = true;
            txtConContra.Enabled = true;
        }
        public void LimpiaObjetos()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtConContra.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            LimpiaObjetos();
            HabilitaObjetos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == txtConContra.Text)
            {
                negUsuarios negusuarios = new negUsuarios();
                entUsuario entusuario = new entUsuario();
                entusuario.Nombre = txtNombre.Text;
                entusuario.Correo = txtCorreo.Text;
                entusuario.Telefono = txtTelefono.Text;
                entusuario.Usuario = txtUsuario.Text;
                entusuario.Contraseña = txtContra.Text;
                if (Nuevo)
                {
                    negusuarios.InsertarDato(entusuario);
                }
                else
                {
                    entusuario.idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString());
                    negusuarios.ActualizaDato(entusuario);

                }
                CargarDGV();
                LimpiaObjetos();
                InhabilitaObjetos();
            }
            else
            {
                MessageBox.Show("Las contraseñas deben coincidir");
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            HabilitaObjetos();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            negUsuarios negusuarios = new negUsuarios();
            entUsuario entusuario = new entUsuario();
            entusuario.idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString());
            negusuarios.EliminaDato(entusuario);
            CargarDGV();
            LimpiaObjetos();
            InhabilitaObjetos();
        }
    }
}
