﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Vista1.MiniVentanas
{
    public partial class Min_Proveedor : Form
    {
        public Min_Proveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            negCatComunes negcatcomunes = new negCatComunes();
            negcatcomunes.InsertarProveedor(txtProveedor.Text);
            this.Close();
        }
    }
}
