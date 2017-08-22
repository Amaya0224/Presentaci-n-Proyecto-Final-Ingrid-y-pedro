namespace Sistema_de_Fotocopias
{
    partial class ControldeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControldeUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbusquedausuario = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrutaimagen = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncargarfoto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.txtdepartamento = new System.Windows.Forms.ComboBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgvbusqueda = new System.Windows.Forms.DataGridView();
            this.btnsalirusuarios = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rbtnid = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label5);
            this.panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtbusquedausuario
            // 
            resources.ApplyResources(this.txtbusquedausuario, "txtbusquedausuario");
            this.txtbusquedausuario.Name = "txtbusquedausuario";
            this.txtbusquedausuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbusquedausuario_KeyUp);
            // 
            // btnbuscar
            // 
            resources.ApplyResources(this.btnbuscar, "btnbuscar");
            this.btnbuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txttipo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtrutaimagen);
            this.panel2.Controls.Add(this.btnimprimir);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.btncargarfoto);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtestado);
            this.panel2.Controls.Add(this.txtdepartamento);
            this.panel2.Controls.Add(this.txtcontraseña);
            this.panel2.Controls.Add(this.txtusuario);
            this.panel2.Controls.Add(this.txtnombrecompleto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnnuevo);
            this.panel2.Controls.Add(this.dgvbusqueda);
            this.panel2.Name = "panel2";
            // 
            // txttipo
            // 
            resources.ApplyResources(this.txttipo, "txttipo");
            this.txttipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttipo.FormattingEnabled = true;
            this.txttipo.Name = "txttipo";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtrutaimagen
            // 
            resources.ApplyResources(this.txtrutaimagen, "txtrutaimagen");
            this.txtrutaimagen.Name = "txtrutaimagen";
            // 
            // btnimprimir
            // 
            resources.ApplyResources(this.btnimprimir, "btnimprimir");
            this.btnimprimir.BackColor = System.Drawing.Color.LightBlue;
            this.btnimprimir.ForeColor = System.Drawing.Color.Black;
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            resources.ApplyResources(this.btnguardar, "btnguardar");
            this.btnguardar.BackColor = System.Drawing.Color.LightBlue;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncargarfoto
            // 
            resources.ApplyResources(this.btncargarfoto, "btncargarfoto");
            this.btncargarfoto.BackColor = System.Drawing.Color.LightBlue;
            this.btncargarfoto.Name = "btncargarfoto";
            this.btncargarfoto.UseVisualStyleBackColor = false;
            this.btncargarfoto.Click += new System.EventHandler(this.btncargarfoto_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtestado
            // 
            resources.ApplyResources(this.txtestado, "txtestado");
            this.txtestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            resources.GetString("txtestado.Items"),
            resources.GetString("txtestado.Items1")});
            this.txtestado.Name = "txtestado";
            // 
            // txtdepartamento
            // 
            resources.ApplyResources(this.txtdepartamento, "txtdepartamento");
            this.txtdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdepartamento.FormattingEnabled = true;
            this.txtdepartamento.Name = "txtdepartamento";
            // 
            // txtcontraseña
            // 
            resources.ApplyResources(this.txtcontraseña, "txtcontraseña");
            this.txtcontraseña.Name = "txtcontraseña";
            // 
            // txtusuario
            // 
            resources.ApplyResources(this.txtusuario, "txtusuario");
            this.txtusuario.Name = "txtusuario";
            // 
            // txtnombrecompleto
            // 
            resources.ApplyResources(this.txtnombrecompleto, "txtnombrecompleto");
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnnuevo
            // 
            resources.ApplyResources(this.btnnuevo, "btnnuevo");
            this.btnnuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dgvbusqueda
            // 
            resources.ApplyResources(this.dgvbusqueda, "dgvbusqueda");
            this.dgvbusqueda.AllowUserToAddRows = false;
            this.dgvbusqueda.AllowUserToDeleteRows = false;
            this.dgvbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbusqueda.Name = "dgvbusqueda";
            this.dgvbusqueda.ReadOnly = true;
            this.dgvbusqueda.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbusqueda_CellMouseClick);
            // 
            // btnsalirusuarios
            // 
            resources.ApplyResources(this.btnsalirusuarios, "btnsalirusuarios");
            this.btnsalirusuarios.BackColor = System.Drawing.Color.LightBlue;
            this.btnsalirusuarios.ForeColor = System.Drawing.Color.Black;
            this.btnsalirusuarios.Name = "btnsalirusuarios";
            this.btnsalirusuarios.UseVisualStyleBackColor = false;
            this.btnsalirusuarios.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnsalirusuarios);
            this.panel4.Controls.Add(this.rbtnnombre);
            this.panel4.Controls.Add(this.rbtnid);
            this.panel4.Controls.Add(this.txtbusquedausuario);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Name = "panel4";
            // 
            // rbtnnombre
            // 
            resources.ApplyResources(this.rbtnnombre, "rbtnnombre");
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rbtnid
            // 
            resources.ApplyResources(this.rbtnid, "rbtnid");
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.TabStop = true;
            this.rbtnid.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // ControldeUsuarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControldeUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbusqueda)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbusquedausuario;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnsalirusuarios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rbtnid;
        private System.Windows.Forms.DataGridView dgvbusqueda;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.ComboBox txtdepartamento;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncargarfoto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtrutaimagen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox txttipo;
    }
}