﻿using System;
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
    public partial class Altas_Radio : Form
    {
        public Altas_Radio()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agre_Conex_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_SSDI form = new MiniVentanas.Min_SSDI();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_Modo form = new MiniVentanas.Min_Modo();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniVentanas.Min_seguridad form = new MiniVentanas.Min_seguridad();
            form.Show();
        }
    }
}
