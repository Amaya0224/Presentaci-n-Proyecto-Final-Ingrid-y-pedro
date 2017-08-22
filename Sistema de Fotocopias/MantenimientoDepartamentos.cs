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

    public partial class MantenimientoDepartamentos : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        public int codigo = 0;
        string sql = "";
        
        //Conexion a la base de datos
        ConexionDB x = new ConexionDB();

        public MantenimientoDepartamentos()
        {
            InitializeComponent();
            rellenar_datos();
        }

        //Cargar datos
        public void rellenar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select iddep as ID, nombre as 'Nombre del Departamento', email as 'Correo del Encargado', estado_departamento as Estado from departamento";
            res = x.selectData(sql);
            dgvbusquedadepartamento.DataSource = res;
        }

        //Boton para buscar un departamento ya sea por el id o por el nombre del departamento
        private void btnbuscardepartamento_Click(object sender, EventArgs e)
        {
            if (rbtniddepartamento.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                int id = Convert.ToInt32(txtbusquedadepartamento.Text);
                string sql = "Select iddep as ID, nombre as 'Nombre del Departamento', email as 'Correo del Encargado', estado_departamento as Estado from departamento where iddep=" + id;
                res = x.selectData(sql);
                dgvbusquedadepartamento.DataSource = res;
            }
            if (rbtnnombredepartamento.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string nombre = "%" + txtbusquedadepartamento.Text + "%";
                string sql = "Select iddep as ID, nombre as 'Nombre del Departamento', email as 'Correo del Encargado', estado_departamento as Estado from departamento where nombre like '" + nombre + "'";
                res = x.selectData(sql);
                dgvbusquedadepartamento.DataSource = res;
            }
        }

        //Evento del Datagridview para seleccionar un departamento existente
        private void dgvbusquedadepartamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        if (e.RowIndex!=-1)
            { 
        codigo = Convert.ToInt32(dgvbusquedadepartamento.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            string sql = "Select iddep as ID, nombre as 'Nombre del Departamento', email as 'Correo del Encargado', estado_departamento as Estado from departamento where iddep=" + codigo;

            DataTable res = new DataTable();
            res = x.selectData(sql);

            txtnombredepartamento.Text = res.Rows[0]["Nombre del Departamento"].ToString();
            txtestado.Text = res.Rows[0]["Estado"].ToString();
            txtcorreo.Text = res.Rows[0]["Correo del Encargado"].ToString();
            }
        }

        //Boton para crear un nuevo departamento
        private void btnnuevodepartamento_Click(object sender, EventArgs e)
        {
            txtnombredepartamento.Focus();
            txtnombredepartamento.Clear();
            txtcorreo.Clear();
            txtestado.SelectedIndex = -1;      
        }

        //Boton guardar para guardar un departamento nuevo o actualizar un departamento existente
        private void btnguardardepartamento_Click(object sender, EventArgs e)
        {
            if (txtnombredepartamento.Text.Equals(""))
            {
                MessageBox.Show("El Nombre es Obligatorio", "ADVERTENCIA");
                txtnombredepartamento.Focus();
            }

            else if (txtestado.Text.Equals(""))
            {
                MessageBox.Show("El Estado es Obligatorio", "ADVERTENCIA");
                txtestado.Focus();
            }
            else if (txtcorreo.Text.Equals(""))
            {
                MessageBox.Show("El Correo es Obligatorio", "ADVERTENCIA");
                txtcorreo.Focus();
            }
            else
            {
                string sql = "";
                if (x.verExiste(codigo, "departamento", "iddep") == 0)
                {
                    sql = "INSERT INTO departamento (nombre, email, estado_departamento) VALUES ('" + txtnombredepartamento.Text + "', '" + txtcorreo.Text + "', '" + txtestado.Text + "')";
                    MessageBox.Show("Usuario Guardado Exitosamente", "ADVERTENCIA");
                }
                else
                {
                    sql = "UPDATE departamento SET nombre='" + txtnombredepartamento.Text + "', email='" + txtcorreo.Text + "', estado_departamento='" + txtestado.Text + "'  where  iddep=" + codigo;
                    MessageBox.Show("Usuario Actualizado Exitosamente", "ADVERTENCIA");
                }
                x.sendData(sql).ToString();
            }
        }

        // Timer para cargar datos
        private void timer1_Tick(object sender, EventArgs e)
        {
            rellenar_datos();
        }

        //Boton salir del formulario
        private void btnsalirdepartamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MantenimientoDepartamentos_Load(object sender, EventArgs e)
        {

        }
    }
}