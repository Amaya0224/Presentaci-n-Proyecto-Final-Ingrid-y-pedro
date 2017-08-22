using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Fotocopias
{
    public partial class PantallaPrincipal : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        public int iddep = 0;
        Sistema_de_Fotocopias.ConexionDB x = new ConexionDB();

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        public ControldeUsuarios ControldeUsuarios
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public MantenimientoDepartamentos MantenimientoDepartamentos
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public MantenimientoFotocopiadora MantenimientoFotocopiadora
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Solicitud_Fotocopias Solicitud_Fotocopias
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Aprobaciones Aprobaciones
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Servidor_de_Envio_y_Recepción Servidor_de_Envio_y_Recepción
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

          //Instruccion de seleccion para activar o desactivar formularios dependiendo el nivel de acceso del usuario    
            Usuario.Text = nombreUsuario;

            switch (tipo)
            {
                case "Usuario":
                    mnsolicitarcopias.Enabled = true;
                    mnaprobarsolicitudes.Enabled = false;
                    mnservidor.Enabled = false;
                    mncreardepartamentos.Enabled = false;
                    mncrearusuarios.Enabled = false;
                    baraprobarcopias.Enabled = false;
                    barcambiocontraseña.Enabled = true;
                    barmantenimientodepartamentos.Enabled = false;
                    barmantenimientousuarios.Enabled = false;
                    barservidor.Enabled = false;
                    mnreportes.Enabled = false;
                    mncrearfotocopiadora.Enabled = false;
                    break;
                case "Encargado":
                    mnsolicitarcopias.Enabled = true;
                    mnaprobarsolicitudes.Enabled = true;
                    mnservidor.Enabled = false;
                    mncreardepartamentos.Enabled = false;
                    mncrearusuarios.Enabled = false;
                    barsolicitarcopias.Enabled = true;
                    baraprobarcopias.Enabled = true;
                    barcambiocontraseña.Enabled = true;
                    barmantenimientodepartamentos.Enabled = false;
                    barmantenimientousuarios.Enabled = false;
                    barservidor.Enabled = false;
                    mncrearfotocopiadora.Enabled = false;
                    break;
                case "Administrador":
                    mnsolicitarcopias.Enabled = true;
                    mnaprobarsolicitudes.Enabled = false;
                    mnservidor.Enabled = true;
                    mncreardepartamentos.Enabled = false;
                    mncrearusuarios.Enabled = true;
                    barsolicitarcopias.Enabled = true;
                    baraprobarcopias.Enabled = false;
                    barcambiocontraseña.Enabled = true;
                    barmantenimientodepartamentos.Enabled = false;
                    barmantenimientousuarios.Enabled = false;
                    barservidor.Enabled = true;
                    mncrearfotocopiadora.Enabled = true;
                    break;
                default:
                    mnsolicitarcopias.Enabled = true;
                    mnaprobarsolicitudes.Enabled = true;
                    mnservidor.Enabled = true;
                    mncreardepartamentos.Enabled = true;
                    mncrearusuarios.Enabled = true;
                    barsolicitarcopias.Enabled = true;
                    baraprobarcopias.Enabled = true;
                    barcambiocontraseña.Enabled = true;
                    barmantenimientodepartamentos.Enabled = true;
                    barmantenimientousuarios.Enabled = true;
                    barservidor.Enabled = true;
                    break;
            }
        }

        public string procesar(string x)
        {
            string[] separators = { "\\" };
            string[] palabras = x.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string texto = "";
            for (int a = 0; a < palabras.Length; a++)
            {
                texto += palabras[a];
                texto += (a < palabras.Length - 1) ? "\\\\" : "";
            }
            return texto;
        }

        public void cREARUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControldeUsuarios c = new ControldeUsuarios();
            c.TopMost = true;
            c.MdiParent = this;
            c.Show();  
        }

         private void barmantenimientousuarios_Click(object sender, EventArgs e)
        {
            ControldeUsuarios c = new ControldeUsuarios();
            c.TopMost = true;
            c.MdiParent = this;
            c.Show();
        }

        private void mncreardepartamentos_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamentos d = new MantenimientoDepartamentos();
            d.TopMost = true;
            d.MdiParent = this;
            d.Show();
        }

        private void barmantenimientodepartamentos_Click(object sender, EventArgs e)
        {
            MantenimientoDepartamentos d = new MantenimientoDepartamentos();
            d.TopMost = true;
            d.MdiParent = this;
            d.Show();
        }

        private void mncambiocontraseña_Click(object sender, EventArgs e)
        {
            Cambio_de_Contraseña con = new Cambio_de_Contraseña();
            con.TopMost = true;
            con.codigoUsuario = codigoUsuario;
            con.departamento = departamento;
            con.imagen = imagen;
            con.tipo = tipo;
            con.iddep = iddep;
            con.nombreUsuario = nombreUsuario;
            con.MdiParent = this;
            con.Show();
        }

        private void barcambiocontraseña_Click(object sender, EventArgs e)
        {
            Cambio_de_Contraseña con = new Cambio_de_Contraseña();
            con.TopMost = true;
            con.codigoUsuario = codigoUsuario;
            con.departamento = departamento;
            con.imagen = imagen;
            con.tipo = tipo;
            con.iddep = iddep;
            con.nombreUsuario = nombreUsuario;
            con.MdiParent = this;
            con.Show();
        }

        private void mnsolicitarcopias_Click(object sender, EventArgs e)
        {
            Solicitud_Fotocopias s = new Solicitud_Fotocopias();
            s.TopMost = true;
            s.codigoUsuario = codigoUsuario;
            s.departamento = departamento;
            s.imagen = imagen;
            s.tipo = tipo;
            s.iddep = iddep;
            s.nombreUsuario = nombreUsuario;
            s.MdiParent = this;
            s.Show();    
        }

        private void barsolicitarcopias_Click(object sender, EventArgs e)
        {
            Solicitud_Fotocopias s = new Solicitud_Fotocopias();
            s.TopMost = true;
            s.codigoUsuario = codigoUsuario;
            s.departamento = departamento;
            s.imagen = imagen;
            s.tipo = tipo;
            s.iddep = iddep;
            s.nombreUsuario = nombreUsuario;
            s.MdiParent = this;
            s.Show();
        }

        private void mnaprobarsolicitudes_Click(object sender, EventArgs e)
        {
            Aprobaciones a = new Aprobaciones();
            a.TopMost = true;
            a.MdiParent = this;
            a.codigoUsuario = codigoUsuario;
            a.departamento = departamento;
            a.imagen = imagen;
            a.tipo = tipo;
            a.iddep = iddep;
            a.nombreUsuario = nombreUsuario;
            a.MdiParent = this;
            a.Show();
        }

        private void baraprobarcopias_Click(object sender, EventArgs e)
        {
            Aprobaciones a = new Aprobaciones();
            a.MdiParent = this;
            a.codigoUsuario = codigoUsuario;
            a.departamento = departamento;
            a.imagen = imagen;
            a.tipo = tipo;
            a.iddep = iddep;
            a.nombreUsuario = nombreUsuario;
            a.MdiParent = this;
            a.Show();
        }

        private void mnservidor_Click(object sender, EventArgs e)
        {
            Servidor_de_Envio_y_Recepción ser = new Servidor_de_Envio_y_Recepción();
            ser.TopMost = true;
            ser.codigoUsuario = codigoUsuario;
            ser.departamento = departamento;
            ser.imagen = imagen;
            ser.tipo = tipo;
            ser.iddep = iddep;
            ser.nombreUsuario = nombreUsuario;
            ser.MdiParent = this;
            ser.Show();
        }

        private void barservidor_Click(object sender, EventArgs e)
        {
            Servidor_de_Envio_y_Recepción ser = new Servidor_de_Envio_y_Recepción();
            ser.TopMost = true;
            ser.codigoUsuario = codigoUsuario;
            ser.departamento = departamento;
            ser.imagen = imagen;
            ser.tipo = tipo;
            ser.iddep = iddep;
            ser.nombreUsuario = nombreUsuario;
            ser.MdiParent = this;
            ser.Show();
        }
      
 
        private void sALIRDELSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();      
        }

        private void cREARDEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoFotocopiadora ft = new MantenimientoFotocopiadora();
            ft.TopMost = true;
            ft.MdiParent = this;
            ft.Show();
        }

        private void reporteDeConsumoGerenciaNorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visor_de_Reportes gr = new Visor_de_Reportes();
            gr.TopMost = true;
            gr.MdiParent = this;
            gr.Show();
        }

        //Boton salir del formulario
        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
