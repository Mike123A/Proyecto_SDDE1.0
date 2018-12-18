namespace Capa_Vista1
{
    partial class Form_vivencias_principal
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
            this.panel_vivencias = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Combo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_vivencias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Combo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_vivencias
            // 
            this.panel_vivencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_vivencias.Location = new System.Drawing.Point(12, 118);
            this.panel_vivencias.Name = "panel_vivencias";
            this.panel_vivencias.Size = new System.Drawing.Size(724, 508);
            this.panel_vivencias.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitácora";
            // 
            // Panel_Combo
            // 
            this.Panel_Combo.Controls.Add(this.button1);
            this.Panel_Combo.Controls.Add(this.CB_vivencias);
            this.Panel_Combo.Controls.Add(this.label1);
            this.Panel_Combo.Location = new System.Drawing.Point(12, 59);
            this.Panel_Combo.Name = "Panel_Combo";
            this.Panel_Combo.Size = new System.Drawing.Size(761, 53);
            this.Panel_Combo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(379, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_vivencias
            // 
            this.CB_vivencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_vivencias.FormattingEnabled = true;
            this.CB_vivencias.Items.AddRange(new object[] {
            "Buscar",
            "Agregar"});
            this.CB_vivencias.Location = new System.Drawing.Point(149, 12);
            this.CB_vivencias.Name = "CB_vivencias";
            this.CB_vivencias.Size = new System.Drawing.Size(204, 24);
            this.CB_vivencias.TabIndex = 1;
            this.CB_vivencias.Text = "Seleccione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione ";
            // 
            // Form_vivencias_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 705);
            this.Controls.Add(this.panel_vivencias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel_Combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_vivencias_principal";
            this.Text = "Form_vivencias_principal";
            this.Panel_Combo.ResumeLayout(false);
            this.Panel_Combo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_vivencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_vivencias;
        private System.Windows.Forms.Label label1;
    }
}