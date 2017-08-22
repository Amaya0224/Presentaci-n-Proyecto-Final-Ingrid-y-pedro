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
    public partial class Cambio_de_Contraseña : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public int iddep = 0;
        public String departamento = "";

        ConexionDB x = new ConexionDB();
        public Cambio_de_Contraseña()
        {
            InitializeComponent();
        }

        // Cambio de contraseña
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtcontraseñavieja.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar su Contraseña Vieja");
                txtcontraseñavieja.Focus();
            }
            else if (txtcontraseñanueva.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar su Contraseña Nueva");
                txtcontraseñanueva.Focus();
            }
            else if (txtrepetircontraseña.Text.Equals(""))
            {
                MessageBox.Show("Debe repetir la Contraseña Nueva", "ADVERTENCIA");
                txtrepetircontraseña.Focus();
            }
            else if (!txtcontraseñanueva.Text.Equals(txtrepetircontraseña.Text))
            {
                MessageBox.Show("La Contraseña Repetida y la Nueva no Coincinden, Vuelva a Escribirla", "ADVERTENCIA");
                txtcontraseñanueva.Clear();
                txtrepetircontraseña.Clear();
                txtcontraseñanueva.Focus();
            }
            else {
                DataTable res = new DataTable();
                string sql = "select * from usuarios WHERE idusuario='"+codigoUsuario+"' AND password='"+ x.encriptar(txtcontraseñavieja.Text) +"' AND estado_usuario='ACTIVO'";
                res = x.selectData(sql);
                if (res.Rows.Count != 0)
                {
                    sql = "update usuarios SET password='"+x.encriptar(txtcontraseñanueva.Text)+"' WHERE idusuario="+codigoUsuario;
                    x.sendData(sql);
                    txtcontraseñanueva.Clear();
                    txtrepetircontraseña.Clear();
                    txtcontraseñavieja.Clear();
                    txtcontraseñavieja.Focus();
                    MessageBox.Show("Su contraseña ha sido actualizada exitosamente", "ADVERTENCIA");
                    this.Close();
                }
                else {
                    MessageBox.Show("La Contraseña Actual Invalida", "ADVERTENCIA");
                    txtcontraseñavieja.Clear();
                    txtcontraseñavieja.Focus();
                }
            }
        }
    }
}
