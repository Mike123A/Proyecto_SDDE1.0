namespace Capa_Vista1
{
    partial class Form_Ordenes
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
            this.Panel_Combo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Ordenes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Ordenes_Add = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_Combo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Combo
            // 
            this.Panel_Combo.Controls.Add(this.button1);
            this.Panel_Combo.Controls.Add(this.CB_Ordenes);
            this.Panel_Combo.Controls.Add(this.label1);
            this.Panel_Combo.Location = new System.Drawing.Point(12, 66);
            this.Panel_Combo.Name = "Panel_Combo";
            this.Panel_Combo.Size = new System.Drawing.Size(761, 53);
            this.Panel_Combo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de orden";
            // 
            // CB_Ordenes
            // 
            this.CB_Ordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Ordenes.FormattingEnabled = true;
            this.CB_Ordenes.Items.AddRange(new object[] {
            "Altas",
            "Bajas",
            "Diagnostico"});
            this.CB_Ordenes.Location = new System.Drawing.Point(289, 12);
            this.CB_Ordenes.Name = "CB_Ordenes";
            this.CB_Ordenes.Size = new System.Drawing.Size(204, 24);
            this.CB_Ordenes.TabIndex = 1;
            this.CB_Ordenes.Text = "Seleccione...";
            this.CB_Ordenes.SelectedIndexChanged += new System.EventHandler(this.CB_Ordenes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordenes";
            // 
            // Panel_Ordenes_Add
            // 
            this.Panel_Ordenes_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Ordenes_Add.Location = new System.Drawing.Point(12, 125);
            this.Panel_Ordenes_Add.Name = "Panel_Ordenes_Add";
            this.Panel_Ordenes_Add.Size = new System.Drawing.Size(761, 386);
            this.Panel_Ordenes_Add.TabIndex = 3;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 523);
            this.Controls.Add(this.Panel_Ordenes_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel_Combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ordenes";
            this.Text = "Form_Ordenes";
            this.Panel_Combo.ResumeLayout(false);
            this.Panel_Combo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Combo;
        private System.Windows.Forms.ComboBox CB_Ordenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Ordenes_Add;
        private System.Windows.Forms.Button button1;
    }
}