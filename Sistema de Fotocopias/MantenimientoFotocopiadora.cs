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
    public partial class MantenimientoFotocopiadora : Form
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

        public MantenimientoFotocopiadora()
        {
            InitializeComponent();
            rellenar_datos();
        }

        //Cargar datos
        public void rellenar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "Select idfotocopiadora as ID, nombrefotocopiadora as 'Nombre Fotocopiadora', cantidadhojas as 'Cantidad de Hojas', estadofotocopiadora as Estado from Fotocopiadora";
            res = x.selectData(sql);
            dgvbusquedafotocopiadora.DataSource = res;
        }

        //Limpiar textbox 
        public void limpiar_campos()
        {
            txtnombrefotocopiadora.Clear();
            txtcantidadhojas.Text = "0";
            txtestado.ValueMember="";
            txtestado.DisplayMember = "";
            txtnombrefotocopiadora.Focus();
            codigo = 0;
        }

        //Boton guardar al crear una fotocopiadora nueva o actualizar una fotocopiadora existente
        private void btnguardarfotocpiadora_Click(object sender, EventArgs e)
        {
            if (txtnombrefotocopiadora.Text.Equals(""))
            {
                MessageBox.Show("El Nombre es Obligatorio", "ADVERTENCIA");
                txtnombrefotocopiadora.Focus();
            }
            else if (txtcantidadhojas.Text.Equals(""))
            {
                MessageBox.Show("La cantidad de hojas es Obligatorio", "ADVERTENCIA");
                txtcantidadhojas.Focus();
            }
            else if (txtestado.Text.Equals(""))
            {
                MessageBox.Show("El estado es Obligatorio", "ADVERTENCIA");
                txtestado.Focus();
            }
            else
            {
                string sql = "";
                if (x.verExiste(codigo, "Fotocopiadora", "idfotocopiadora") == 0)
                {
                    sql = "INSERT INTO Fotocopiadora (nombrefotocopiadora, cantidadhojas, estadofotocopiadora) VALUES ('" + txtnombrefotocopiadora.Text + "', '" + txtcantidadhojas.Text + "', '" + txtestado.Text + "')";
                    MessageBox.Show("Equipo Guardado Exitosamente", "ADVERTENCIA");
                }
                else
                {
                    sql = "UPDATE Fotocopiadora SET nombrefotocopiadora='" + txtnombrefotocopiadora.Text + "', cantidadhojas='" + txtcantidadhojas.Text + "', estadofotocopiadora='" + txtestado.Text + "'  where  idfotocopiadora=" + codigo;
                    MessageBox.Show("Equipo Actualizado Exitosamente", "ADVERTENCIA");
                }
                x.sendData(sql).ToString();
                limpiar_campos();
            }
        }

        //Boton para buscar una fotocopiadora ya sea por el id o por el nombre
        private void btnbuscarfotocopiadora_Click(object sender, EventArgs e)
        {
            if (rbtnidfotocopiadora .Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                int id = Convert.ToInt32(rbtnidfotocopiadora.Text);
                string sql = "Select idfotocopiadora as ID, nombrefotocopiadora as 'Nombre Fotocopiadora', cantidadhojas as 'Cantidad de Hojas', estadofotocopiadora as Estado from Fotocopiadora where idfotocopiadora=" + id;
                res = x.selectData(sql);
                dgvbusquedafotocopiadora.DataSource = res;
            }
            if (rbtnnombrefotocopiadora.Checked == true)
            {
                System.Data.DataTable res = new System.Data.DataTable();
                string nombre = "%" + txtnombrefotocopiadora.Text + "%";
                string sql = "Select idfotocopiadora as ID, nombrefotocopiadora as 'Nombre Fotocopiadora', cantidadhojas as 'Cantidad de Hojas', estadofotocopiadora as Estado from Fotocopiadora where nombrefotocopiadora like '" + nombre + "'";
                res = x.selectData(sql);
                dgvbusquedafotocopiadora.DataSource = res;
            }
        }

        //Boton para llenar textbox al crear una fotocopiadora nueva
        private void btnnuevafotocopiadora_Click(object sender, EventArgs e)
        {
            txtnombrefotocopiadora.Focus();
            txtnombrefotocopiadora.Clear();
            txtcantidadhojas.Clear();
            txtestado.SelectedIndex = -1;
        }

        //Evento del datagridview para seleccionar una fotocopiadora 
        private void dgvbusquedafotocopiadora_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                codigo = Convert.ToInt32(dgvbusquedafotocopiadora.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                string sql = "Select idfotocopiadora as ID, nombrefotocopiadora as 'Nombre Fotocopiadora', cantidadhojas as 'Cantidad de Hojas', estadofotocopiadora as Estado from Fotocopiadora where idfotocopiadora=" + codigo;

                DataTable res = new DataTable();
                res = x.selectData(sql);

                txtnombrefotocopiadora.Text = res.Rows[0]["Nombre Fotocopiadora"].ToString();
                txtcantidadhojas.Text = res.Rows[0]["Cantidad de Hojas"].ToString();
                txtestado.Text = res.Rows[0]["Estado"].ToString();
            }
        }

        //Timer para cargar datos al Datagridview
         private void timer1_Tick(object sender, EventArgs e)
        {
            rellenar_datos();
        }

        //Salir del formulario
        private void btnsalirfotocopiadora_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
