namespace Sistema_de_Fotocopias
{
    partial class MantenimientoFotocopiadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoFotocopiadora));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnimprimirfotocopiadora = new System.Windows.Forms.Button();
            this.rbtnnombrefotocopiadora = new System.Windows.Forms.RadioButton();
            this.rbtnidfotocopiadora = new System.Windows.Forms.RadioButton();
            this.txtbusquedafotocopiadora = new System.Windows.Forms.TextBox();
            this.btnbuscarfotocopiadora = new System.Windows.Forms.Button();
            this.btnnuevafotocopiadora = new System.Windows.Forms.Button();
            this.dgvbusquedafotocopiadora = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcantidadhojas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.btnguardarfotocpiadora = new System.Windows.Forms.Button();
            this.txtnombrefotocopiadora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalirfotocopiadora = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedafotocopiadora)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnimprimirfotocopiadora);
            this.panel4.Controls.Add(this.rbtnnombrefotocopiadora);
            this.panel4.Controls.Add(this.rbtnidfotocopiadora);
            this.panel4.Controls.Add(this.txtbusquedafotocopiadora);
            this.panel4.Controls.Add(this.btnbuscarfotocopiadora);
            this.panel4.Controls.Add(this.btnnuevafotocopiadora);
            this.panel4.Controls.Add(this.dgvbusquedafotocopiadora);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(14, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(910, 485);
            this.panel4.TabIndex = 22;
            // 
            // btnimprimirfotocopiadora
            // 
            this.btnimprimirfotocopiadora.BackColor = System.Drawing.Color.LightBlue;
            this.btnimprimirfotocopiadora.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimirfotocopiadora.ForeColor = System.Drawing.Color.Black;
            this.btnimprimirfotocopiadora.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimirfotocopiadora.Image")));
            this.btnimprimirfotocopiadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimirfotocopiadora.Location = new System.Drawing.Point(731, 247);
            this.btnimprimirfotocopiadora.Name = "btnimprimirfotocopiadora";
            this.btnimprimirfotocopiadora.Size = new System.Drawing.Size(103, 35);
            this.btnimprimirfotocopiadora.TabIndex = 24;
            this.btnimprimirfotocopiadora.Text = "     Imprimir";
            this.btnimprimirfotocopiadora.UseVisualStyleBackColor = false;
            // 
            // rbtnnombrefotocopiadora
            // 
            this.rbtnnombrefotocopiadora.AutoSize = true;
            this.rbtnnombrefotocopiadora.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnnombrefotocopiadora.Location = new System.Drawing.Point(132, 246);
            this.rbtnnombrefotocopiadora.Name = "rbtnnombrefotocopiadora";
            this.rbtnnombrefotocopiadora.Size = new System.Drawing.Size(82, 22);
            this.rbtnnombrefotocopiadora.TabIndex = 28;
            this.rbtnnombrefotocopiadora.TabStop = true;
            this.rbtnnombrefotocopiadora.Text = "Nombre";
            this.rbtnnombrefotocopiadora.UseVisualStyleBackColor = true;
            // 
            // rbtnidfotocopiadora
            // 
            this.rbtnidfotocopiadora.AutoSize = true;
            this.rbtnidfotocopiadora.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnidfotocopiadora.Location = new System.Drawing.Point(50, 245);
            this.rbtnidfotocopiadora.Name = "rbtnidfotocopiadora";
            this.rbtnidfotocopiadora.Size = new System.Drawing.Size(47, 22);
            this.rbtnidfotocopiadora.TabIndex = 27;
            this.rbtnidfotocopiadora.TabStop = true;
            this.rbtnidfotocopiadora.Text = "ID";
            this.rbtnidfotocopiadora.UseVisualStyleBackColor = true;
            // 
            // txtbusquedafotocopiadora
            // 
            this.txtbusquedafotocopiadora.Location = new System.Drawing.Point(221, 249);
            this.txtbusquedafotocopiadora.Name = "txtbusquedafotocopiadora";
            this.txtbusquedafotocopiadora.Size = new System.Drawing.Size(228, 20);
            this.txtbusquedafotocopiadora.TabIndex = 22;
            // 
            // btnbuscarfotocopiadora
            // 
            this.btnbuscarfotocopiadora.BackColor = System.Drawing.Color.LightBlue;
            this.btnbuscarfotocopiadora.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarfotocopiadora.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarfotocopiadora.Image")));
            this.btnbuscarfotocopiadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscarfotocopiadora.Location = new System.Drawing.Point(486, 245);
            this.btnbuscarfotocopiadora.Name = "btnbuscarfotocopiadora";
            this.btnbuscarfotocopiadora.Size = new System.Drawing.Size(81, 35);
            this.btnbuscarfotocopiadora.TabIndex = 23;
            this.btnbuscarfotocopiadora.Text = "   Buscar";
            this.btnbuscarfotocopiadora.UseVisualStyleBackColor = false;
            this.btnbuscarfotocopiadora.Click += new System.EventHandler(this.btnbuscarfotocopiadora_Click);
            // 
            // btnnuevafotocopiadora
            // 
            this.btnnuevafotocopiadora.BackColor = System.Drawing.Color.LightBlue;
            this.btnnuevafotocopiadora.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevafotocopiadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevafotocopiadora.Location = new System.Drawing.Point(573, 245);
            this.btnnuevafotocopiadora.Name = "btnnuevafotocopiadora";
            this.btnnuevafotocopiadora.Size = new System.Drawing.Size(149, 35);
            this.btnnuevafotocopiadora.TabIndex = 25;
            this.btnnuevafotocopiadora.Text = "Nueva Fotocopiadora";
            this.btnnuevafotocopiadora.UseVisualStyleBackColor = false;
            this.btnnuevafotocopiadora.Click += new System.EventHandler(this.btnnuevafotocopiadora_Click);
            // 
            // dgvbusquedafotocopiadora
            // 
            this.dgvbusquedafotocopiadora.AllowUserToAddRows = false;
            this.dgvbusquedafotocopiadora.AllowUserToDeleteRows = false;
            this.dgvbusquedafotocopiadora.AllowUserToOrderColumns = true;
            this.dgvbusquedafotocopiadora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbusquedafotocopiadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusquedafotocopiadora.Location = new System.Drawing.Point(32, 288);
            this.dgvbusquedafotocopiadora.Name = "dgvbusquedafotocopiadora";
            this.dgvbusquedafotocopiadora.ReadOnly = true;
            this.dgvbusquedafotocopiadora.Size = new System.Drawing.Size(847, 177);
            this.dgvbusquedafotocopiadora.TabIndex = 26;
            this.dgvbusquedafotocopiadora.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbusquedafotocopiadora_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(156, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 58);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mantenimiento Fotocopiadoras";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtcantidadhojas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtestado);
            this.panel2.Controls.Add(this.btnguardarfotocpiadora);
            this.panel2.Controls.Add(this.txtnombrefotocopiadora);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 146);
            this.panel2.TabIndex = 17;
            // 
            // txtcantidadhojas
            // 
            this.txtcantidadhojas.Location = new System.Drawing.Point(177, 57);
            this.txtcantidadhojas.Name = "txtcantidadhojas";
            this.txtcantidadhojas.Size = new System.Drawing.Size(253, 20);
            this.txtcantidadhojas.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cantidad de Hojas:";
            // 
            // txtestado
            // 
            this.txtestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.txtestado.Location = new System.Drawing.Point(177, 82);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(253, 21);
            this.txtestado.TabIndex = 36;
            // 
            // btnguardarfotocpiadora
            // 
            this.btnguardarfotocpiadora.BackColor = System.Drawing.Color.LightBlue;
            this.btnguardarfotocpiadora.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarfotocpiadora.Location = new System.Drawing.Point(467, 39);
            this.btnguardarfotocpiadora.Name = "btnguardarfotocpiadora";
            this.btnguardarfotocpiadora.Size = new System.Drawing.Size(110, 33);
            this.btnguardarfotocpiadora.TabIndex = 35;
            this.btnguardarfotocpiadora.Text = "Guardar";
            this.btnguardarfotocpiadora.UseVisualStyleBackColor = false;
            this.btnguardarfotocpiadora.Click += new System.EventHandler(this.btnguardarfotocpiadora_Click);
            // 
            // txtnombrefotocopiadora
            // 
            this.txtnombrefotocopiadora.Location = new System.Drawing.Point(177, 31);
            this.txtnombrefotocopiadora.Name = "txtnombrefotocopiadora";
            this.txtnombrefotocopiadora.Size = new System.Drawing.Size(253, 20);
            this.txtnombrefotocopiadora.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fotocopiadora:";
            // 
            // btnsalirfotocopiadora
            // 
            this.btnsalirfotocopiadora.BackColor = System.Drawing.Color.LightBlue;
            this.btnsalirfotocopiadora.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirfotocopiadora.ForeColor = System.Drawing.Color.Black;
            this.btnsalirfotocopiadora.Image = ((System.Drawing.Image)(resources.GetObject("btnsalirfotocopiadora.Image")));
            this.btnsalirfotocopiadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirfotocopiadora.Location = new System.Drawing.Point(780, 530);
            this.btnsalirfotocopiadora.Name = "btnsalirfotocopiadora";
            this.btnsalirfotocopiadora.Size = new System.Drawing.Size(104, 43);
            this.btnsalirfotocopiadora.TabIndex = 17;
            this.btnsalirfotocopiadora.Text = "    Salir";
            this.btnsalirfotocopiadora.UseVisualStyleBackColor = false;
            this.btnsalirfotocopiadora.Click += new System.EventHandler(this.btnsalirfotocopiadora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MantenimientoFotocopiadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(938, 585);
            this.Controls.Add(this.btnsalirfotocopiadora);
            this.Controls.Add(this.panel4);
            this.Name = "MantenimientoFotocopiadora";
            this.Text = "MantenimientoFotocopiadora";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusquedafotocopiadora)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnsalirfotocopiadora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcantidadhojas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.Button btnguardarfotocpiadora;
        private System.Windows.Forms.TextBox txtnombrefotocopiadora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnimprimirfotocopiadora;
        private System.Windows.Forms.RadioButton rbtnnombrefotocopiadora;
        private System.Windows.Forms.RadioButton rbtnidfotocopiadora;
        private System.Windows.Forms.TextBox txtbusquedafotocopiadora;
        private System.Windows.Forms.Button btnbuscarfotocopiadora;
        private System.Windows.Forms.Button btnnuevafotocopiadora;
        private System.Windows.Forms.DataGridView dgvbusquedafotocopiadora;
        private System.Windows.Forms.Timer timer1;
    }
}