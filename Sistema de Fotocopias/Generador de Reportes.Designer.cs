namespace Sistema_de_Fotocopias
{
    partial class Generador_de_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generador_de_Reportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiografico = new System.Windows.Forms.RadioButton();
            this.radiocosto = new System.Windows.Forms.RadioButton();
            this.radiofecha = new System.Windows.Forms.RadioButton();
            this.radiosolicitante = new System.Windows.Forms.RadioButton();
            this.radiodepartamento = new System.Windows.Forms.RadioButton();
            this.radioconsumogerencia = new System.Windows.Forms.RadioButton();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 56);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(902, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(834, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Envio y Recepción de Fotocopias";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radiografico);
            this.panel2.Controls.Add(this.radiocosto);
            this.panel2.Controls.Add(this.radiofecha);
            this.panel2.Controls.Add(this.radiosolicitante);
            this.panel2.Controls.Add(this.radiodepartamento);
            this.panel2.Controls.Add(this.radioconsumogerencia);
            this.panel2.Controls.Add(this.btngenerar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 553);
            this.panel2.TabIndex = 7;
            // 
            // radiografico
            // 
            this.radiografico.AutoSize = true;
            this.radiografico.Location = new System.Drawing.Point(358, 172);
            this.radiografico.Name = "radiografico";
            this.radiografico.Size = new System.Drawing.Size(175, 17);
            this.radiografico.TabIndex = 35;
            this.radiografico.TabStop = true;
            this.radiografico.Text = "Reporte Estadistico con Grafico";
            this.radiografico.UseVisualStyleBackColor = true;
            // 
            // radiocosto
            // 
            this.radiocosto.AutoSize = true;
            this.radiocosto.Location = new System.Drawing.Point(358, 149);
            this.radiocosto.Name = "radiocosto";
            this.radiocosto.Size = new System.Drawing.Size(141, 17);
            this.radiocosto.TabIndex = 34;
            this.radiocosto.TabStop = true;
            this.radiocosto.Text = "Reporte por Costo Copia";
            this.radiocosto.UseVisualStyleBackColor = true;
            // 
            // radiofecha
            // 
            this.radiofecha.AutoSize = true;
            this.radiofecha.Location = new System.Drawing.Point(358, 126);
            this.radiofecha.Name = "radiofecha";
            this.radiofecha.Size = new System.Drawing.Size(114, 17);
            this.radiofecha.TabIndex = 33;
            this.radiofecha.TabStop = true;
            this.radiofecha.Text = "Reporte por Fecha";
            this.radiofecha.UseVisualStyleBackColor = true;
            // 
            // radiosolicitante
            // 
            this.radiosolicitante.AutoSize = true;
            this.radiosolicitante.Location = new System.Drawing.Point(358, 103);
            this.radiosolicitante.Name = "radiosolicitante";
            this.radiosolicitante.Size = new System.Drawing.Size(133, 17);
            this.radiosolicitante.TabIndex = 32;
            this.radiosolicitante.TabStop = true;
            this.radiosolicitante.Text = "Reporte por Solicitante";
            this.radiosolicitante.UseVisualStyleBackColor = true;
            // 
            // radiodepartamento
            // 
            this.radiodepartamento.AutoSize = true;
            this.radiodepartamento.Location = new System.Drawing.Point(358, 80);
            this.radiodepartamento.Name = "radiodepartamento";
            this.radiodepartamento.Size = new System.Drawing.Size(151, 17);
            this.radiodepartamento.TabIndex = 31;
            this.radiodepartamento.TabStop = true;
            this.radiodepartamento.Text = "Reporte por Departamento";
            this.radiodepartamento.UseVisualStyleBackColor = true;
            // 
            // radioconsumogerencia
            // 
            this.radioconsumogerencia.AutoSize = true;
            this.radioconsumogerencia.Location = new System.Drawing.Point(358, 57);
            this.radioconsumogerencia.Name = "radioconsumogerencia";
            this.radioconsumogerencia.Size = new System.Drawing.Size(200, 17);
            this.radioconsumogerencia.TabIndex = 30;
            this.radioconsumogerencia.TabStop = true;
            this.radioconsumogerencia.Text = "Reporte de Consumo Gerencia Norte";
            this.radioconsumogerencia.UseVisualStyleBackColor = true;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(386, 233);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 23);
            this.btngenerar.TabIndex = 29;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "REPORTES";
            // 
            // Generador_de_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Generador_de_Reportes";
            this.Text = "Generador_de_Reportes";
            this.Load += new System.EventHandler(this.Generador_de_Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.RadioButton radiografico;
        private System.Windows.Forms.RadioButton radiocosto;
        private System.Windows.Forms.RadioButton radiofecha;
        private System.Windows.Forms.RadioButton radiosolicitante;
        private System.Windows.Forms.RadioButton radiodepartamento;
        private System.Windows.Forms.RadioButton radioconsumogerencia;
    }
}