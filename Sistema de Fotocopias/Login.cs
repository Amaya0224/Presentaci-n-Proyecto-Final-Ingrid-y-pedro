using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Sistema_de_Fotocopias
{
    public partial class Login : Form
    {
        //Conexión a la base de datos
        ConexionDB x = new ConexionDB();

        public Login()
        {
            InitializeComponent();
        }

        //Botón entrar para autenticar usuario y contraseña en la base de datos y pasar al formulario principal
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtxUsuario.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar su Nombre de Usuario");
                txtxUsuario.Focus();
            }
            else if (txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar su Contraseña");
                txtContraseña.Focus();
            }         
            string sql = "Select a.*, b.nombre from usuarios a inner join departamento b on a.iddep=b.iddep where cuenta='" + txtxUsuario.Text + "' and password='" + x.encriptar(txtContraseña.Text) + "' and estado_usuario='ACTIVO'";
            DataTable re = new DataTable();
            re = x.selectData(sql);
            if (re.Rows.Count==1)
            {
            PantallaPrincipal r = new PantallaPrincipal();
                r.codigoUsuario = Convert.ToInt32(re.Rows[0]["idusuario"].ToString());
                r.nombreUsuario = re.Rows[0]["nombreusuario"].ToString();
                r.departamento = re.Rows[0]["nombre"].ToString();
                r.tipo = re.Rows[0]["tipo"].ToString();
                r.imagen = re.Rows[0]["foto"].ToString();
                r.iddep=Convert.ToInt32(re.Rows[0]["iddep"].ToString());
                r.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invalido");
                txtxUsuario.Clear();
                txtContraseña.Clear();
                txtxUsuario.Focus();
            }        
        }

        //Botón salir del formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
