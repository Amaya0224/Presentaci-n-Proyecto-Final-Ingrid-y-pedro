namespace Sistema_de_Fotocopias
{
    partial class Visor_de_Reportes
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnverreportedepartamentos = new System.Windows.Forms.Button();
            this.btnporsolicitante = new System.Windows.Forms.Button();
            this.btnporfecha = new System.Windows.Forms.Button();
            this.btncosto = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1107, 741);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnverreportedepartamentos
            // 
            this.btnverreportedepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverreportedepartamentos.Location = new System.Drawing.Point(22, 133);
            this.btnverreportedepartamentos.Name = "btnverreportedepartamentos";
            this.btnverreportedepartamentos.Size = new System.Drawing.Size(141, 23);
            this.btnverreportedepartamentos.TabIndex = 1;
            this.btnverreportedepartamentos.Text = "Por Departamentos";
            this.btnverreportedepartamentos.UseVisualStyleBackColor = true;
            this.btnverreportedepartamentos.Click += new System.EventHandler(this.btnverreportedepartamentos_Click);
            // 
            // btnporsolicitante
            // 
            this.btnporsolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporsolicitante.Location = new System.Drawing.Point(22, 179);
            this.btnporsolicitante.Name = "btnporsolicitante";
            this.btnporsolicitante.Size = new System.Drawing.Size(141, 23);
            this.btnporsolicitante.TabIndex = 42;
            this.btnporsolicitante.Text = "Por Solicitante";
            this.btnporsolicitante.UseVisualStyleBackColor = true;
            this.btnporsolicitante.Click += new System.EventHandler(this.btnporsolicitante_Click);
            // 
            // btnporfecha
            // 
            this.btnporfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporfecha.Location = new System.Drawing.Point(22, 228);
            this.btnporfecha.Name = "btnporfecha";
            this.btnporfecha.Size = new System.Drawing.Size(141, 23);
            this.btnporfecha.TabIndex = 43;
            this.btnporfecha.Text = "Por Fecha";
            this.btnporfecha.UseVisualStyleBackColor = true;
            this.btnporfecha.Click += new System.EventHandler(this.btnporfecha_Click);
            // 
            // btncosto
            // 
            this.btncosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncosto.Location = new System.Drawing.Point(22, 281);
            this.btncosto.Name = "btncosto";
            this.btncosto.Size = new System.Drawing.Size(141, 23);
            this.btncosto.TabIndex = 44;
            this.btncosto.Text = "Por Costo por Copia";
            this.btncosto.UseVisualStyleBackColor = true;
            this.btncosto.Click += new System.EventHandler(this.btncosto_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(22, 364);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(141, 23);
            this.btnsalir.TabIndex = 46;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Visor_de_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 741);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncosto);
            this.Controls.Add(this.btnporfecha);
            this.Controls.Add(this.btnporsolicitante);
            this.Controls.Add(this.btnverreportedepartamentos);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Visor_de_Reportes";
            this.Text = "Visor_de_Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnverreportedepartamentos;
        private System.Windows.Forms.Button btnporsolicitante;
        private System.Windows.Forms.Button btnporfecha;
        private System.Windows.Forms.Button btncosto;
        private System.Windows.Forms.Button btnsalir;
    }
}