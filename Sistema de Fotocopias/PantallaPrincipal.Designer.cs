namespace Sistema_de_Fotocopias
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mANTENIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mncrearusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mncreardepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mncambiocontraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.mncrearfotocopiadora = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsolicitarcopias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnaprobarsolicitudes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnservidor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeConsumoGerenciaNorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRDELSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Usuario = new System.Windows.Forms.ToolStripLabel();
            this.barmantenimientousuarios = new System.Windows.Forms.ToolStripButton();
            this.barmantenimientodepartamentos = new System.Windows.Forms.ToolStripButton();
            this.barcambiocontraseña = new System.Windows.Forms.ToolStripButton();
            this.barsolicitarcopias = new System.Windows.Forms.ToolStripButton();
            this.baraprobarcopias = new System.Windows.Forms.ToolStripButton();
            this.barservidor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOSToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.mnreportes,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mANTENIMIENTOSToolStripMenuItem
            // 
            this.mANTENIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mncrearusuarios,
            this.mncreardepartamentos,
            this.mncambiocontraseña,
            this.mncrearfotocopiadora});
            this.mANTENIMIENTOSToolStripMenuItem.Name = "mANTENIMIENTOSToolStripMenuItem";
            this.mANTENIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mANTENIMIENTOSToolStripMenuItem.Text = "MANTENIMIENTOS";
            // 
            // mncrearusuarios
            // 
            this.mncrearusuarios.Image = ((System.Drawing.Image)(resources.GetObject("mncrearusuarios.Image")));
            this.mncrearusuarios.Name = "mncrearusuarios";
            this.mncrearusuarios.Size = new System.Drawing.Size(209, 22);
            this.mncrearusuarios.Text = "CREAR USUARIOS";
            this.mncrearusuarios.Click += new System.EventHandler(this.cREARUSUARIOSToolStripMenuItem_Click);
            // 
            // mncreardepartamentos
            // 
            this.mncreardepartamentos.Image = ((System.Drawing.Image)(resources.GetObject("mncreardepartamentos.Image")));
            this.mncreardepartamentos.Name = "mncreardepartamentos";
            this.mncreardepartamentos.Size = new System.Drawing.Size(209, 22);
            this.mncreardepartamentos.Text = "CREAR DEPARTAMENTOS";
            this.mncreardepartamentos.Click += new System.EventHandler(this.mncreardepartamentos_Click);
            // 
            // mncambiocontraseña
            // 
            this.mncambiocontraseña.Image = ((System.Drawing.Image)(resources.GetObject("mncambiocontraseña.Image")));
            this.mncambiocontraseña.Name = "mncambiocontraseña";
            this.mncambiocontraseña.Size = new System.Drawing.Size(209, 22);
            this.mncambiocontraseña.Text = "CAMBIO CONTRASEÑA";
            this.mncambiocontraseña.Click += new System.EventHandler(this.mncambiocontraseña_Click);
            // 
            // mncrearfotocopiadora
            // 
            this.mncrearfotocopiadora.Name = "mncrearfotocopiadora";
            this.mncrearfotocopiadora.Size = new System.Drawing.Size(209, 22);
            this.mncrearfotocopiadora.Text = "CREAR FOTOCOPIADORA";
            this.mncrearfotocopiadora.Click += new System.EventHandler(this.cREARDEPARTAMENTOToolStripMenuItem_Click);
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsolicitarcopias,
            this.mnaprobarsolicitudes,
            this.mnservidor});
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // mnsolicitarcopias
            // 
            this.mnsolicitarcopias.Image = ((System.Drawing.Image)(resources.GetObject("mnsolicitarcopias.Image")));
            this.mnsolicitarcopias.Name = "mnsolicitarcopias";
            this.mnsolicitarcopias.Size = new System.Drawing.Size(200, 22);
            this.mnsolicitarcopias.Text = "SOLICITAR COPIAS";
            this.mnsolicitarcopias.Click += new System.EventHandler(this.mnsolicitarcopias_Click);
            // 
            // mnaprobarsolicitudes
            // 
            this.mnaprobarsolicitudes.Image = ((System.Drawing.Image)(resources.GetObject("mnaprobarsolicitudes.Image")));
            this.mnaprobarsolicitudes.Name = "mnaprobarsolicitudes";
            this.mnaprobarsolicitudes.Size = new System.Drawing.Size(200, 22);
            this.mnaprobarsolicitudes.Text = "APROBAR SOLICITUDES";
            this.mnaprobarsolicitudes.Click += new System.EventHandler(this.mnaprobarsolicitudes_Click);
            // 
            // mnservidor
            // 
            this.mnservidor.Image = ((System.Drawing.Image)(resources.GetObject("mnservidor.Image")));
            this.mnservidor.Name = "mnservidor";
            this.mnservidor.Size = new System.Drawing.Size(200, 22);
            this.mnservidor.Text = "SERVIDOR";
            this.mnservidor.Click += new System.EventHandler(this.mnservidor_Click);
            // 
            // mnreportes
            // 
            this.mnreportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeConsumoGerenciaNorteToolStripMenuItem});
            this.mnreportes.Name = "mnreportes";
            this.mnreportes.Size = new System.Drawing.Size(73, 20);
            this.mnreportes.Text = "REPORTES";
            // 
            // reporteDeConsumoGerenciaNorteToolStripMenuItem
            // 
            this.reporteDeConsumoGerenciaNorteToolStripMenuItem.Name = "reporteDeConsumoGerenciaNorteToolStripMenuItem";
            this.reporteDeConsumoGerenciaNorteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reporteDeConsumoGerenciaNorteToolStripMenuItem.Text = "GENERAR REPORTES";
            this.reporteDeConsumoGerenciaNorteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeConsumoGerenciaNorteToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRDELSISTEMAToolStripMenuItem});
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // sALIRDELSISTEMAToolStripMenuItem
            // 
            this.sALIRDELSISTEMAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sALIRDELSISTEMAToolStripMenuItem.Image")));
            this.sALIRDELSISTEMAToolStripMenuItem.Name = "sALIRDELSISTEMAToolStripMenuItem";
            this.sALIRDELSISTEMAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.sALIRDELSISTEMAToolStripMenuItem.Text = "SALIR DEL SISTEMA";
            this.sALIRDELSISTEMAToolStripMenuItem.Click += new System.EventHandler(this.sALIRDELSISTEMAToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Usuario,
            this.barmantenimientousuarios,
            this.barmantenimientodepartamentos,
            this.barcambiocontraseña,
            this.barsolicitarcopias,
            this.baraprobarcopias,
            this.barservidor,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1098, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "SALIR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Usuario
            // 
            this.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Usuario.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(140, 22);
            this.Usuario.Text = "Nombre Usuario";
            // 
            // barmantenimientousuarios
            // 
            this.barmantenimientousuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barmantenimientousuarios.Image = ((System.Drawing.Image)(resources.GetObject("barmantenimientousuarios.Image")));
            this.barmantenimientousuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barmantenimientousuarios.Name = "barmantenimientousuarios";
            this.barmantenimientousuarios.Size = new System.Drawing.Size(23, 22);
            this.barmantenimientousuarios.Text = "Mantenimiento Usuarios";
            this.barmantenimientousuarios.Click += new System.EventHandler(this.barmantenimientousuarios_Click);
            // 
            // barmantenimientodepartamentos
            // 
            this.barmantenimientodepartamentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barmantenimientodepartamentos.Image = ((System.Drawing.Image)(resources.GetObject("barmantenimientodepartamentos.Image")));
            this.barmantenimientodepartamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barmantenimientodepartamentos.Name = "barmantenimientodepartamentos";
            this.barmantenimientodepartamentos.Size = new System.Drawing.Size(23, 22);
            this.barmantenimientodepartamentos.Text = "Mantenimiento Departamentos";
            this.barmantenimientodepartamentos.Click += new System.EventHandler(this.barmantenimientodepartamentos_Click);
            // 
            // barcambiocontraseña
            // 
            this.barcambiocontraseña.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barcambiocontraseña.Image = ((System.Drawing.Image)(resources.GetObject("barcambiocontraseña.Image")));
            this.barcambiocontraseña.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barcambiocontraseña.Name = "barcambiocontraseña";
            this.barcambiocontraseña.Size = new System.Drawing.Size(23, 22);
            this.barcambiocontraseña.Text = "Cambio Contraseña";
            this.barcambiocontraseña.Click += new System.EventHandler(this.barcambiocontraseña_Click);
            // 
            // barsolicitarcopias
            // 
            this.barsolicitarcopias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barsolicitarcopias.Image = ((System.Drawing.Image)(resources.GetObject("barsolicitarcopias.Image")));
            this.barsolicitarcopias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barsolicitarcopias.Name = "barsolicitarcopias";
            this.barsolicitarcopias.Size = new System.Drawing.Size(23, 22);
            this.barsolicitarcopias.Text = "Solicitar Copias";
            this.barsolicitarcopias.Click += new System.EventHandler(this.barsolicitarcopias_Click);
            // 
            // baraprobarcopias
            // 
            this.baraprobarcopias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.baraprobarcopias.Image = ((System.Drawing.Image)(resources.GetObject("baraprobarcopias.Image")));
            this.baraprobarcopias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.baraprobarcopias.Name = "baraprobarcopias";
            this.baraprobarcopias.Size = new System.Drawing.Size(23, 22);
            this.baraprobarcopias.Text = "Aprobar Copias";
            this.baraprobarcopias.Click += new System.EventHandler(this.baraprobarcopias_Click);
            // 
            // barservidor
            // 
            this.barservidor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barservidor.Image = ((System.Drawing.Image)(resources.GetObject("barservidor.Image")));
            this.barservidor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barservidor.Name = "barservidor";
            this.barservidor.Size = new System.Drawing.Size(23, 22);
            this.barservidor.Text = "Servidor";
            this.barservidor.Click += new System.EventHandler(this.barservidor_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1098, 477);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mncrearusuarios;
        private System.Windows.Forms.ToolStripMenuItem mncreardepartamentos;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsolicitarcopias;
        private System.Windows.Forms.ToolStripMenuItem mnaprobarsolicitudes;
        private System.Windows.Forms.ToolStripMenuItem mnservidor;
        private System.Windows.Forms.ToolStripMenuItem mncambiocontraseña;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRDELSISTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Usuario;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton barmantenimientousuarios;
        private System.Windows.Forms.ToolStripButton barmantenimientodepartamentos;
        private System.Windows.Forms.ToolStripButton barcambiocontraseña;
        private System.Windows.Forms.ToolStripButton barsolicitarcopias;
        private System.Windows.Forms.ToolStripButton baraprobarcopias;
        private System.Windows.Forms.ToolStripButton barservidor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnreportes;
        private System.Windows.Forms.ToolStripMenuItem reporteDeConsumoGerenciaNorteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mncrearfotocopiadora;
    }
}

