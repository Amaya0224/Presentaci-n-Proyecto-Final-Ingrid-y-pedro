namespace Sistema_de_Fotocopias
{
    partial class Aprobaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aprobaciones));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnoaprobado = new System.Windows.Forms.Button();
            this.btnaprobado = new System.Windows.Forms.Button();
            this.txtnotaaprobacion = new System.Windows.Forms.TextBox();
            this.Actualizar = new System.Windows.Forms.CheckBox();
            this.dgvaprobaciones = new System.Windows.Forms.DataGridView();
            this.btnbusquedaaprobacion = new System.Windows.Forms.Button();
            this.txtbusquedaaprobacion = new System.Windows.Forms.TextBox();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.Label();
            this.foto1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaprobaciones)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnnoaprobado);
            this.panel4.Controls.Add(this.btnaprobado);
            this.panel4.Controls.Add(this.txtnotaaprobacion);
            this.panel4.Controls.Add(this.Actualizar);
            this.panel4.Controls.Add(this.dgvaprobaciones);
            this.panel4.Controls.Add(this.btnbusquedaaprobacion);
            this.panel4.Controls.Add(this.txtbusquedaaprobacion);
            this.panel4.Controls.Add(this.fecha2);
            this.panel4.Controls.Add(this.fecha1);
            this.panel4.Location = new System.Drawing.Point(17, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 346);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 32;
            this.label2.Tag = "";
            this.label2.Text = "Nota";
            // 
            // btnnoaprobado
            // 
            this.btnnoaprobado.Location = new System.Drawing.Point(400, 309);
            this.btnnoaprobado.Name = "btnnoaprobado";
            this.btnnoaprobado.Size = new System.Drawing.Size(75, 23);
            this.btnnoaprobado.TabIndex = 31;
            this.btnnoaprobado.Text = "No Aprobar";
            this.btnnoaprobado.UseVisualStyleBackColor = true;
            this.btnnoaprobado.Click += new System.EventHandler(this.btnnoaprobado_Click);
            // 
            // btnaprobado
            // 
            this.btnaprobado.Location = new System.Drawing.Point(314, 309);
            this.btnaprobado.Name = "btnaprobado";
            this.btnaprobado.Size = new System.Drawing.Size(75, 23);
            this.btnaprobado.TabIndex = 30;
            this.btnaprobado.Text = "Aprobar";
            this.btnaprobado.UseVisualStyleBackColor = true;
            this.btnaprobado.Click += new System.EventHandler(this.btnaprobado_Click);
            // 
            // txtnotaaprobacion
            // 
            this.txtnotaaprobacion.Location = new System.Drawing.Point(196, 223);
            this.txtnotaaprobacion.Multiline = true;
            this.txtnotaaprobacion.Name = "txtnotaaprobacion";
            this.txtnotaaprobacion.Size = new System.Drawing.Size(494, 80);
            this.txtnotaaprobacion.TabIndex = 29;
            // 
            // Actualizar
            // 
            this.Actualizar.AutoSize = true;
            this.Actualizar.Checked = true;
            this.Actualizar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Actualizar.Location = new System.Drawing.Point(606, 16);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(72, 17);
            this.Actualizar.TabIndex = 28;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            // 
            // dgvaprobaciones
            // 
            this.dgvaprobaciones.AllowUserToAddRows = false;
            this.dgvaprobaciones.AllowUserToDeleteRows = false;
            this.dgvaprobaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvaprobaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaprobaciones.Location = new System.Drawing.Point(19, 43);
            this.dgvaprobaciones.Name = "dgvaprobaciones";
            this.dgvaprobaciones.ReadOnly = true;
            this.dgvaprobaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvaprobaciones.Size = new System.Drawing.Size(954, 174);
            this.dgvaprobaciones.TabIndex = 27;
            this.dgvaprobaciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvaprobaciones_CellMouseClick);
            // 
            // btnbusquedaaprobacion
            // 
            this.btnbusquedaaprobacion.BackColor = System.Drawing.Color.LightBlue;
            this.btnbusquedaaprobacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbusquedaaprobacion.FlatAppearance.BorderSize = 2;
            this.btnbusquedaaprobacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusquedaaprobacion.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusquedaaprobacion.Image = ((System.Drawing.Image)(resources.GetObject("btnbusquedaaprobacion.Image")));
            this.btnbusquedaaprobacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbusquedaaprobacion.Location = new System.Drawing.Point(314, 13);
            this.btnbusquedaaprobacion.Name = "btnbusquedaaprobacion";
            this.btnbusquedaaprobacion.Size = new System.Drawing.Size(31, 23);
            this.btnbusquedaaprobacion.TabIndex = 23;
            this.btnbusquedaaprobacion.UseVisualStyleBackColor = false;
            this.btnbusquedaaprobacion.Click += new System.EventHandler(this.btnbusquedaaprobacion_Click);
            // 
            // txtbusquedaaprobacion
            // 
            this.txtbusquedaaprobacion.Location = new System.Drawing.Point(19, 13);
            this.txtbusquedaaprobacion.Multiline = true;
            this.txtbusquedaaprobacion.Name = "txtbusquedaaprobacion";
            this.txtbusquedaaprobacion.Size = new System.Drawing.Size(289, 23);
            this.txtbusquedaaprobacion.TabIndex = 21;
            // 
            // fecha2
            // 
            this.fecha2.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha2.Location = new System.Drawing.Point(481, 15);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(105, 20);
            this.fecha2.TabIndex = 24;
            this.fecha2.Value = new System.DateTime(2017, 8, 18, 0, 0, 0, 0);
            this.fecha2.ValueChanged += new System.EventHandler(this.fecha2_ValueChanged);
            // 
            // fecha1
            // 
            this.fecha1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha1.Location = new System.Drawing.Point(370, 15);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(105, 20);
            this.fecha1.TabIndex = 22;
            this.fecha1.Value = new System.DateTime(2017, 8, 18, 0, 0, 0, 0);
            this.fecha1.ValueChanged += new System.EventHandler(this.fecha1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtusuario);
            this.panel3.Controls.Add(this.foto1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(36, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 104);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aprobación";
            // 
            // txtusuario
            // 
            this.txtusuario.AutoSize = true;
            this.txtusuario.Location = new System.Drawing.Point(902, 33);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(63, 13);
            this.txtusuario.TabIndex = 7;
            this.txtusuario.Text = "Ingrid Perez";
            // 
            // foto1
            // 
            this.foto1.Image = ((System.Drawing.Image)(resources.GetObject("foto1.Image")));
            this.foto1.Location = new System.Drawing.Point(847, 8);
            this.foto1.Name = "foto1";
            this.foto1.Size = new System.Drawing.Size(49, 56);
            this.foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto1.TabIndex = 7;
            this.foto1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(677, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sistema de Envío y Recepción de Fotocopias";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightBlue;
            this.btnsalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(901, 485);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(104, 43);
            this.btnsalir.TabIndex = 18;
            this.btnsalir.Text = "    Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Aprobaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1044, 557);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Aprobaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprobaciones";
            this.Load += new System.EventHandler(this.Aprobaciones_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaprobaciones)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvaprobaciones;
        private System.Windows.Forms.Button btnbusquedaaprobacion;
        private System.Windows.Forms.TextBox txtbusquedaaprobacion;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtusuario;
        private System.Windows.Forms.PictureBox foto1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.CheckBox Actualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnoaprobado;
        private System.Windows.Forms.Button btnaprobado;
        private System.Windows.Forms.TextBox txtnotaaprobacion;
    }
}