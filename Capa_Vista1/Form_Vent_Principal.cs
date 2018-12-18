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
    public partial class Form_Vent_Principal : Form
    {
        public Form_Vent_Principal()
        {
            InitializeComponent();
        }

        private void pbMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void IconoMinMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoMinMax.Visible = false;
            IconoMaximizar.Visible = true;

        }

        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoMinMax.Visible = true;
            IconoMaximizar.Visible = false;
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form_Vent_Principal_Load(object sender, EventArgs e)
        {
            OcultarSubMenus();
            AbrirVentana(new Form_Home());
            lbl_Identificador_Apartado.Text = "Inicio";
        }
        public void OcultarSubMenus()
        {
            btn_AP.Visible = false;
            btn_radio.Visible = false;
            btn_SW.Visible = false;

            btn_reportes.Visible = false;
            btn_Bitacora.Visible = false;
            btn_Ordenes.Visible = false;
        }
        public void ConfiguracionBotones(string Opcion)
        {

            switch (Opcion)
            {
                case "Equipos":
                    if (btn_AP.Visible == true)
                    {
                        OcultarSubMenus();
                    }
                    else
                    {
                        OcultarSubMenus();

                        btn_AP.Visible = true;
                        btn_radio.Visible = true;
                        btn_SW.Visible = true;
                    }
                    break;
                case "Documentos":
                    if (btn_Ordenes.Visible == true)
                    {
                        OcultarSubMenus();
                    }
                    else
                    {
                        OcultarSubMenus();
                        btn_Ordenes.Visible = true;
                        btn_reportes.Visible = true;
                        btn_Bitacora.Visible = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_Equipos_Click(object sender, EventArgs e)
        {
            ConfiguracionBotones("Equipos");
        }

        private void btn_Documentos_Click(object sender, EventArgs e)
        {
            ConfiguracionBotones("Documentos");

        }

        private void btn_SW_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Switches";


            AbrirVentana(new Form_Altas());

            RegrasarBotones();

            btn_SW.BackColor = Color.DeepSkyBlue;

        }

        private void btn_radio_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Radios";

            AbrirVentana(new Form_Radio2());

            RegrasarBotones();

            btn_radio.BackColor = Color.DeepSkyBlue;
        }

        private void btn_AP_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Acces Point";

            AbrirVentana(new Form_Aps());
     
            RegrasarBotones();

            btn_AP.BackColor = Color.DeepSkyBlue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Edificios";

            AbrirVentana(new Form_Edificios());

            OcultarSubMenus();
            RegrasarBotones();

            button9.BackColor = Color.DeepSkyBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Usuarios";

            AbrirVentana(new Form_Usuarios());

            OcultarSubMenus();
            RegrasarBotones();

            button4.BackColor = Color.DeepSkyBlue;
        }

        private void btn_Ordenes_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Ordenes";

            AbrirVentana(new Form_Ordenes());


            RegrasarBotones();

            btn_Ordenes.BackColor = Color.DeepSkyBlue;
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Reportes";

            AbrirVentana(new Form_Reportes());


            RegrasarBotones();

            btn_reportes.BackColor = Color.DeepSkyBlue;
        }

        private void btn_Bitacora_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Bitacora";

            AbrirVentana(new Form_Bitacora());

            RegrasarBotones();
            btn_reportes.BackColor = Color.DeepSkyBlue;
        }
        public void RegrasarBotones()
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Bitacora.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_Identificador_Apartado.Text = "Inicio";

            OcultarSubMenus();
            RegrasarBotones();
            AbrirVentana(new Form_Home());
        }
        public void AbrirVentana(object formhijo)
        {
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            this.Panel_Contenedor.Controls.Clear();
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.Show();
            fh.WindowState = FormWindowState.Maximized;
        }
    }
}
