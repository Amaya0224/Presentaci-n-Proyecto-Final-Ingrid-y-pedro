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
    public partial class Solicitud_Fotocopias : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        public int iddep = 0;
        int codigo = 0;

        //Conexión a la base de datos
        ConexionDB x = new ConexionDB();
        public Solicitud_Fotocopias()
        {
            InitializeComponent();
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

        //Cargar datos 
        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No Visto' when a.aprobado=1 then 'Aprobado' else 'No aprobado' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and a.idusuario='" + codigoUsuario + "' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvbusquedacopias.DataSource = res;
        }

        //Limpiar textbox
        public void limpiar_campos()
        {
            txtTituloDocumento.Clear();
            txtCopias.Text = "0";
            txtNota.Clear();
            txtaprobacion.Clear();
            txtTituloDocumento.Focus();
            codigo = 0;
        }

        //Rellenar datos al inicio del formulario
        private void Solicitud_Fotocopias_Load(object sender, EventArgs e)
        {
            txtDepartamento.Text = departamento;
            txtSolicitante.Text = nombreUsuario;
            pictureBox2.Load(procesar(imagen));
            label9.Text = nombreUsuario;
            txtDepartamento.Enabled = false;
            txtSolicitante.Enabled=false;
            cargar_datos();
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

        //Botón buscar por el titulo de la solicitud de copia
        private void btnbuscar_Click(object sender, EventArgs e)
        {         
            System.Data.DataTable res = new System.Data.DataTable();
            string Titulo = "%" + txtbuscar.Text + "%";
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No Visto' when a.aprobado=1 then 'Aprobado' else 'No aprobado' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep+"' and a.idusuario='"+codigoUsuario+"' and a.titulo like '" + Titulo+"' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvbusquedacopias.DataSource = res;
        }

        //Botón para enviar solicitud de copias luego de llenar datos en los textbox o actualizar una solicitud antes de ser aprobada
         private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTituloDocumento.Text.Equals(""))
            {
                MessageBox.Show("El Titulo del Documento es Obligatorio", "ADVERTENCIA");
                txtTituloDocumento.Focus();
            }
            else if (txtCopias.Text.Equals(""))
            {
                MessageBox.Show("La cantidad de Copias es Obligatorio", "ADVERTENCIA");
                txtCopias.Focus();
            }
            else if (Convert.ToInt32(txtCopias.Text) <= 0)
            {
                MessageBox.Show("La cantidad no puede ser menor o igual a 0", "ADVERTENCIA");
                txtCopias.Focus();
            }
            else
            {
                //DateTime fechaHoy = DateTime.Now;
                string fechaHoy = Convert.ToDateTime((dtfecha.Value)).ToString("dd/MM/yyyy");

                string sql = "";
                int cara = 0;
                if (rbtn1Cara.Checked==true)
                    {
                        cara = 1;
                    }
                    else
                    {
                        cara = 2;
                    }
                if (codigo == 0)
                {
                   
                    sql = "insert into copias (fecha, iddep, idusuario, titulo, cantidad, cara, nota, aprobado, terminado, del, hojas_danadas, idfotocopiadora) values ('"+ fechaHoy + "', '"+iddep+"', '"+codigoUsuario+"', '"+txtTituloDocumento.Text+"', '"+Convert.ToInt32(txtCopias.Text)+"', '"+cara+"', '"+txtNota.Text+"', 0, 0, 1, 0, 0)";
                }
                else
                {
                    sql = "update copias set fecha='"+fechaHoy+"', iddep= '"+iddep+"', idusuario='"+codigoUsuario+"', titulo='"+txtTituloDocumento.Text+"', cantidad='"+Convert.ToInt32(txtCopias.Text)+"', cara='"+cara+"', nota='"+txtNota.Text+"' where idcopia="+codigo;
                }
                x.sendData(sql);
                cargar_datos();
                limpiar_campos();
              
            }
        }

        //Botón para limpiar datos de una solicitud que no deseo procesar antes de ser aprobada
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Seguro que deseas limpiar los datos", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
            {
                limpiar_campos();
            }
        }
        
        //Evento del datagridview busqueda de copias para seleccionar solicitud 
        private void dgvbusquedacopias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            if (e.RowIndex != -1)
            {
                codigo = Convert.ToInt32(dgvbusquedacopias.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.nota as Nota, a.cantidad as 'Cantidad de Copias', a.cara as Cara, a.notaaprobar as 'Nota Aprobar', b.nombreusuario as Usuario, case when a.aprobado=0 then 'No Visto' when a.aprobado=1 then 'Aprobado' else 'No aprobado' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and a.idusuario='" + codigoUsuario + "' and a.idcopia=" + codigo;

                DataTable res = new DataTable();
                res = x.selectData(sql);

                txtTituloDocumento.Text = res.Rows[0]["Título del Documento"].ToString();
                txtCopias.Text = res.Rows[0]["Cantidad de Copias"].ToString();
                txtNota.Text = res.Rows[0]["Nota"].ToString();
                txtaprobacion.Text = res.Rows[0]["Nota Aprobar"].ToString();

                if (Convert.ToInt32(res.Rows[0]["Cara"].ToString()) == 1)
                {
                    rbtn1Cara.Checked = true;
                }
                else
                {
                    rbtn2Cara.Checked = true;
                }
            }
        }

        private void fecha1_ValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string f1 = fecha1.Text;
            string f2 = fecha2.Text;
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No Visto' when a.aprobado=1 then 'Aprobado' else 'No aprobado' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and a.idusuario='" + codigoUsuario + "' and  a.fecha between '" + f1+ "' and '"+f2+"' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvbusquedacopias.DataSource = res;
        }

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string f1 = fecha1.Text;
            string f2 = fecha2.Text;
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No Visto' when a.aprobado=1 then 'Aprobado' else 'No aprobado' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and a.idusuario='" + codigoUsuario + "' and  a.fecha between '" + f1 + "' and '" + f2 + "' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvbusquedacopias.DataSource = res;
        }
        
        //Evento del Datagridview para borrar una solicitud
        private void dgvbusquedacopias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codigo = Convert.ToInt32(dgvbusquedacopias.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            DialogResult limpiar = MessageBox.Show("Seguro que deseas borrar la solicitud", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
            {
                string sql = "Update copias set del=0 where idcopia=" + codigo;
                x.sendData(sql);
                cargar_datos();
                limpiar_campos();
            }
        }

        private void txtCopias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Salir del formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
