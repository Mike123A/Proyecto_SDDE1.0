namespace Capa_Vista1
{
    partial class Form_bitacora_agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_bitacora_agregar));
            this.rtxtProblema = new System.Windows.Forms.RichTextBox();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.rdbR = new System.Windows.Forms.RadioButton();
            this.cmbDispositivos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtRecomendacion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtProblema
            // 
            this.rtxtProblema.Location = new System.Drawing.Point(48, 173);
            this.rtxtProblema.Name = "rtxtProblema";
            this.rtxtProblema.Size = new System.Drawing.Size(423, 39);
            this.rtxtProblema.TabIndex = 72;
            this.rtxtProblema.Text = "";
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbE.Location = new System.Drawing.Point(295, 105);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(103, 22);
            this.rdbE.TabIndex = 71;
            this.rdbE.TabStop = true;
            this.rdbE.Text = "En proceso";
            this.rdbE.UseVisualStyleBackColor = true;
            // 
            // rdbR
            // 
            this.rdbR.AutoSize = true;
            this.rdbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbR.Location = new System.Drawing.Point(203, 105);
            this.rdbR.Name = "rdbR";
            this.rdbR.Size = new System.Drawing.Size(85, 22);
            this.rdbR.TabIndex = 70;
            this.rdbR.TabStop = true;
            this.rdbR.Text = "Resuelto";
            this.rdbR.UseVisualStyleBackColor = true;
            // 
            // cmbDispositivos
            // 
            this.cmbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivos.FormattingEnabled = true;
            this.cmbDispositivos.Items.AddRange(new object[] {
            "Switch",
            "Radio",
            "AccesPoint"});
            this.cmbDispositivos.Location = new System.Drawing.Point(203, 65);
            this.cmbDispositivos.Name = "cmbDispositivos";
            this.cmbDispositivos.Size = new System.Drawing.Size(121, 21);
            this.cmbDispositivos.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Problema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Estatus de problema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Dispositivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Agregar";
            // 
            // rtxtRecomendacion
            // 
            this.rtxtRecomendacion.Location = new System.Drawing.Point(48, 257);
            this.rtxtRecomendacion.Name = "rtxtRecomendacion";
            this.rtxtRecomendacion.Size = new System.Drawing.Size(423, 129);
            this.rtxtRecomendacion.TabIndex = 74;
            this.rtxtRecomendacion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 73;
            this.label5.Text = "Recomendacion:";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(391, 420);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 34);
            this.button5.TabIndex = 96;
            this.button5.Text = "Guardar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form_bitacora_agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 466);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rtxtRecomendacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtProblema);
            this.Controls.Add(this.rdbE);
            this.Controls.Add(this.rdbR);
            this.Controls.Add(this.cmbDispositivos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_bitacora_agregar";
            this.Text = "form_vivencia_agreg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtProblema;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.RadioButton rdbR;
        private System.Windows.Forms.ComboBox cmbDispositivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtRecomendacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
    }
}