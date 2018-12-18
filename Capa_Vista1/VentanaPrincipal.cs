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
    public partial class VentanaPrincipal : Form
    {
       
        public VentanaPrincipal()
        {
            InitializeComponent();
            ocultardocumentos();
            ocultarequipos();
            
         
        }

      



        public void ocultarequipos()
        {
            btn_SW.Visible = false;
            btn_radio.Visible = false;
            btn_AP.Visible = false;

        }

        public void ocultardocumentos()
        {
            btn_Ordenes.Visible = false;
            btn_reportes.Visible = false;
            btn_Vivencias.Visible = false;
        }

        public void mostrarEquipos()
        {
            btn_SW.Visible = true;
            btn_radio.Visible = true;
            btn_AP.Visible = true;
        }
        public void mostrarDocumentos()
        {
            btn_Ordenes.Visible = true;
            btn_reportes.Visible = true;
            btn_Vivencias.Visible = true;
        }

        public void ConfiguracionBotones(string Opcion)
        {

            switch (Opcion)
            {
                case "Equipos":
                    if (btn_AP.Visible == true)
                    {
                        ocultarequipos();
                    }
                    else
                    {
                        ocultarequipos();
                        btn_AP.Visible = true;
                        btn_radio.Visible = true;
                        btn_SW.Visible = true;
                    }
                    break;
                case "Documentos":
                    if (btn_Ordenes.Visible == true)
                    {
                        ocultardocumentos();
                    }
                    else
                    {
                        ocultardocumentos();
                        btn_Ordenes.Visible = true;
                        btn_reportes.Visible = true;
                        btn_Vivencias.Visible = true;
                    }
                    break;
                default:
                    break;
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        public void AbrirVentana(object formhijo)
        {
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            this.panelcont2.Controls.Clear();
            this.panelcont2.Controls.Add(fh);
            this.panelcont2.Tag = fh;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.Show();
            fh.WindowState = FormWindowState.Maximized;
        }
        private void Panelcontenedor_Paint(object sender, PaintEventArgs e)
        {
            AbrirVentana(new Form_Home());
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
            Application.Exit();
            pictureBox1.Image = System.Drawing.Image.FromFile("C:/Users/Winniki Mendiburu/Desktop/Carpeta Escritorio 30-11-18/7 SEMESTRE/Sistema ordinario Paco/Proyecto_SDDE/iconos-tamaño/IconoCerrar.png");
        }

        private void btn_Equipos_Click_1(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.DeepSkyBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            ConfiguracionBotones("Equipos");
        }

        private void btn_SW_Click_1(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.DeepSkyBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Altas());
        }

        private void btn_Documentos_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.DeepSkyBlue;
            ConfiguracionBotones("Documentos");
        }

        private void btn_radio_Click_1(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.DeepSkyBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Radio());
        }

        private void btn_AP_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Aps());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.DeepSkyBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Usuarios());
        }

        private void btn_Ordenes_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.DeepSkyBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;

            AbrirVentana(new Form_Ordenes());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.DeepSkyBlue;
           
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Reportes());
        }

        private void btn_Vivencias_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.DeepSkyBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Bitacora());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.MidnightBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            button3.BackColor = Color.DeepSkyBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Home());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn_Equipos.BackColor = Color.MidnightBlue;
            btn_SW.BackColor = Color.MidnightBlue;
            btn_radio.BackColor = Color.MidnightBlue;
            btn_AP.BackColor = Color.MidnightBlue;
            button9.BackColor = Color.DeepSkyBlue;
            button4.BackColor = Color.MidnightBlue;
            btn_reportes.BackColor = Color.MidnightBlue;
            btn_Vivencias.BackColor = Color.MidnightBlue;
            btn_Ordenes.BackColor = Color.MidnightBlue;
            btn_Documentos.BackColor = Color.MidnightBlue;
            AbrirVentana(new Form_Edificios());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
