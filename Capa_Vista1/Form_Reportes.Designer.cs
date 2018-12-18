namespace Capa_Vista1
{
    partial class Form_Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Combo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_Ordenes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Combo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reportes";
            // 
            // Panel_Combo
            // 
            this.Panel_Combo.Controls.Add(this.dataGridView1);
            this.Panel_Combo.Controls.Add(this.button1);
            this.Panel_Combo.Controls.Add(this.CB_Ordenes);
            this.Panel_Combo.Controls.Add(this.label1);
            this.Panel_Combo.Location = new System.Drawing.Point(12, 59);
            this.Panel_Combo.Name = "Panel_Combo";
            this.Panel_Combo.Size = new System.Drawing.Size(761, 452);
            this.Panel_Combo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReporte,
            this.Equipo,
            this.Edificio,
            this.Marca,
            this.N_Serie});
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 393);
            this.dataGridView1.TabIndex = 3;
            // 
            // idReporte
            // 
            this.idReporte.HeaderText = "idReporte";
            this.idReporte.Name = "idReporte";
            this.idReporte.Width = 120;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 150;
            // 
            // Edificio
            // 
            this.Edificio.HeaderText = "Edificio";
            this.Edificio.MinimumWidth = 120;
            this.Edificio.Name = "Edificio";
            this.Edificio.Width = 150;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 150;
            // 
            // N_Serie
            // 
            this.N_Serie.HeaderText = "N_Serie";
            this.N_Serie.Name = "N_Serie";
            this.N_Serie.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(519, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CB_Ordenes
            // 
            this.CB_Ordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ordenes.FormattingEnabled = true;
            this.CB_Ordenes.Items.AddRange(new object[] {
            "Switches",
            "Radios",
            "Acces Point",
            "Usuarios",
            "Edificios",
            "Ordenes",
            "Reportes"});
            this.CB_Ordenes.Location = new System.Drawing.Point(289, 12);
            this.CB_Ordenes.Name = "CB_Ordenes";
            this.CB_Ordenes.Size = new System.Drawing.Size(204, 24);
            this.CB_Ordenes.TabIndex = 1;
            this.CB_Ordenes.Text = "Seleccione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de reporte";
            // 
            // Form_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel_Combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Reportes";
            this.Text = "Form_Reportes";
            this.Panel_Combo.ResumeLayout(false);
            this.Panel_Combo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_Ordenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Serie;
    }
}