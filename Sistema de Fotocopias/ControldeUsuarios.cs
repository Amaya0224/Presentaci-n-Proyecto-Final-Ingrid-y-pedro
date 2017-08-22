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
using System.Security.Cryptography;
using System.IO;



namespace Sistema_de_Fotocopias
{
    public partial class ControldeUsuarios : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        public int codigo = 0;
        string sql = "";
        string foto = "";

        // Conexion a la base de datos
        ConexionDB x = new ConexionDB();

        public ControldeUsuarios()
        {
            InitializeComponent();
            rellenar_datos();
        }

       //Cargar datos al Datagriedview
        public void rellenar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select idusuario as ID, nombreusuario as 'Nombre Completo', cuenta as 'Nombre de Usuario', tipo as Tipo, estado_usuario as Estado, nombre as Departamento from usuarios inner join departamento on usuarios.iddep = departamento.iddep";
            res = x.selectData(sql);
            dgvbusqueda.DataSource = res;

            System.Data.DataTable res1 = new System.Data.DataTable();
            sql = "select iddep, nombre from departamento";
            res1 = x.selectData(sql);

            txtdepartamento.DataSource = res1;
            txtdepartamento.DisplayMember = "nombre";
            txtdepartamento.ValueMember = "iddep";

            System.Data.DataTable res2 = new System.Data.DataTable();
            sql = "select tipo from tipousuario";
            res2 = x.selectData(sql);

            txttipo.DataSource = res2;
            txttipo.DisplayMember = "tipo";
            txttipo.ValueMember = "tipo";
        }    

        // Guardar usuarios nuevos y actualizar usuarios existentes
         private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombrecompleto.Text.Equals(""))
            {
                MessageBox.Show("El Nombre es Obligatorio");
                txtnombrecompleto.Focus();
            }
            else if (txtdepartamento.Text.Equals(""))
            {
                MessageBox.Show("El Departamento es Obligatorio");
                txtdepartamento.Focus();
            }
            else if (txtusuario.Text.Equals(""))
            {
                MessageBox.Show("El Usuario es Obligatorio");
                txtusuario.Focus();
            }
            else if (txtcontraseña.Text.Equals(""))
            {
                MessageBox.Show("La Contraseña es Obligatoria");
                txtcontraseña.Focus();
            }
            else if (txttipo.Text.Equals(""))
            {
                MessageBox.Show("Campo Tipo no debe estar vacio");
                txttipo.Focus();
            }
            else if (txtestado.Text.Equals(""))
            {
                MessageBox.Show("Campo Estado no debe estar vacio");
                txtestado.Focus();
            }
            else if (txtrutaimagen.Text.Equals(""))
            {
                MessageBox.Show("Campo Fotografía no debe estar vacio");
                txtrutaimagen.Focus();
            }
            else
            {
                if (foto != "")
                {
                    byte[] imagen = null;
                    FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imagen = br.ReadBytes((int)fs.Length);                
                }
                int prueba = txtdepartamento.SelectedIndex + 1;
                string sql = "";
                if (x.verExiste(codigo, "usuarios", "idusuario") == 0)
                {
                    sql = "INSERT INTO usuarios (nombreusuario, cuenta, password, estado_usuario, tipo, foto, iddep) VALUES ('" + txtnombrecompleto.Text + "', '" + txtusuario.Text + "', '" +x.encriptar(txtcontraseña.Text) + "', '" + txtestado.Text + "', '" + txttipo.Text + "', '" + txtrutaimagen.Text + "', '"+prueba+"')";
                    MessageBox.Show("Usuario Guardado Exitosamente");
                }
                else
                {
                    sql = "UPDATE usuarios SET nombreusuario='" + txtnombrecompleto.Text + "', cuenta='" + txtusuario.Text + "', password='" + x.encriptar(txtcontraseña.Text) + "' , estado_usuario= '" + txtestado.Text + "', tipo= '" + txttipo.Text + "', foto='" + txtrutaimagen.Text + "', iddep='" + prueba + "' where  idusuario=" + codigo;
                    MessageBox.Show("Usuario Actualizado Exitosamente");
                }
                x.sendData(sql).ToString();
                rellenar_datos();
                codigo = 0;
                txtnombrecompleto.Focus();
                txtnombrecompleto.Clear();
                txtdepartamento.SelectedIndex = -1;
                txtcontraseña.Clear();
                txtusuario.Clear();
                txttipo.SelectedIndex = -1;
                txtestado.SelectedIndex = -1;
                txtrutaimagen.Clear();
                pictureBox1.Image = null;
            }
        }

        //Cargar foto 
        private void btncargarfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\sistemas\\imagenes";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImage.FileName;
                txtrutaimagen.Text = getImage.FileName;
                foto = procesar(getImage.FileName.ToString());

                pictureBox1.Load(foto);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna imagen", "Sin seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Metodo para guardar la ruta de la imagen 
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

        // Al seleccionar el boton nuevo usuario, posicionar el cursor en el textbox nombre y limpiar todos los campos de los textbox
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            codigo = 0;
            txtnombrecompleto.Focus();
            txtnombrecompleto.Clear();
            txtdepartamento.SelectedIndex = -1;
            txtcontraseña.Clear();
            txtusuario.Clear();
            txttipo.SelectedIndex = -1;
            txtestado.SelectedIndex = -1;
            txtrutaimagen.Clear();
            pictureBox1.Image = null;
        }

        //Evento del Datagriedview para seleccionar un usuario ya creado y que cargue los textbox
        private void dgvbusqueda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codigo = Convert.ToInt32(dgvbusqueda.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            string sql = "select idusuario as ID, nombreusuario as Nombre, password, cuenta as 'Nombre de Usuario', tipo as 'Tipo', estado_usuario as 'Estado', nombre as 'Departamento' from usuarios inner join departamento on usuarios.iddep = departamento.iddep where idusuario=" + codigo;

            DataTable res = new DataTable();
            res = x.selectData(sql);

            txtdepartamento.Text = res.Rows[0]["Departamento"].ToString();
            txtnombrecompleto.Text = res.Rows[0]["Nombre"].ToString();
            txtusuario.Text = res.Rows[0]["Nombre de Usuario"].ToString();
            txttipo.Text = res.Rows[0]["Tipo"].ToString();
            txtestado.Text = res.Rows[0]["Estado"].ToString();
            txtcontraseña.Text = res.Rows[0]["password"].ToString();

            string imagen = "select foto from usuarios where idusuario = " + dgvbusqueda.CurrentRow.Cells[0].Value;
            DataTable fotografia = new DataTable();
            fotografia = x.selectData(imagen);
            txtrutaimagen.Text = fotografia.Rows[0]["foto"].ToString();
            foto = procesar(txtrutaimagen.Text);
            pictureBox1.Load(foto);
        }

        //Busqueda de usuarios por id o nombre
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnid.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                int id = Convert.ToInt32(txtbusquedausuario.Text);
                string sql = "Select idusuario as ID, nombreusuario as Nombre, cuenta as 'User Name', estado_usuario as Estado, tipo as 'Tipo' from usuarios where idusuario=" + id;
                res = x.selectData(sql);
                dgvbusqueda.DataSource = res;
            }
            if (rbtnnombre.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string nombre = "%" + txtbusquedausuario.Text + "%";
                string sql = "Select idusuario as ID, nombreusuario as Nombre, cuenta as 'User Name', tipo as 'Tipo', estado_usuario as Estado from usuarios where nombre like '" + nombre + "'";
                res = x.selectData(sql);
                dgvbusqueda.DataSource = res;
            }
        }

        private void txtbusquedausuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtbusquedausuario.Text == "")
            {
                rellenar_datos();
            }
        }

        //Salir del formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

