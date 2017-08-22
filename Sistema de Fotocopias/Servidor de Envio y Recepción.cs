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
    public partial class Servidor_de_Envio_y_Recepción : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        public int iddep = 0;
        public int codigo = 0;

        //Conexion a la base de datos
        ConexionDB x = new ConexionDB();

        public Servidor_de_Envio_y_Recepción()
        {
            InitializeComponent();
        }

        public Visor_de_Reportes Visor_de_Reportes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //Al abrir formulario cargar nombre de usurio, foto y cargar datos en el Datagridview
        private void Servidor_de_Envio_y_Recepción_Load(object sender, EventArgs e)
        {
            txtusuario.Text = nombreUsuario;
            foto1.Load(procesar(imagen));
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

        //Cargar datos al datagridview Servidor (Servidor es donde el fotocopista procesa las copias)
        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, c.nombre as Departamento, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario inner join departamento c on a.iddep=c.iddep where a.del=1 and a.aprobado=1 AND terminado=0 order by a.idcopia desc";
            res = x.selectData(sql);
            dgvservidor.DataSource = res;

            System.Data.DataTable res1 = new System.Data.DataTable();
            sql = "select idfotocopiadora, nombrefotocopiadora from Fotocopiadora";
            res1 = x.selectData(sql);

            cmbimpresoras.DataSource = res1;
            cmbimpresoras.DisplayMember = "nombrefotocopiadora";
            cmbimpresoras.ValueMember = "idfotocopiadora";

            System.Data.DataTable res2 = new System.Data.DataTable();
            sql = "select iddep, nombre from departamento";
            res2 = x.selectData(sql);

            cmbdepartamentos.DataSource = res2;
            cmbdepartamentos.DisplayMember = "nombre";
            cmbdepartamentos.ValueMember = "iddep";

            DataTable res3 = new DataTable();
            int idfoto = Convert.ToInt32(cmbimpresoras.SelectedValue.ToString());
            sql = "select cantidadhojas from Fotocopiadora where idfotocopiadora=" + idfoto;
            res3 = x.selectData(sql);

            txthojasimpresora.Text = res3.Rows[0]["cantidadhojas"].ToString();
        }

        //Boton buscar solicitud de copias
        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string Titulo = "%" + txtbusquedacopias.Text + "%";
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.titulo like '" + Titulo + "' AND terminado=0 order by a.idcopia desc";
            res = x.selectData(sql);
            dgvservidor.DataSource = res;
        }

        private void fecha1_ValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string f1 = fecha1.Text;
            string f2 = fecha2.Text;
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and  a.fecha between '" + f1 + "' and '" + f2 + "' AND terminado=0 order by a.idcopia desc";
            res = x.selectData(sql);
            dgvservidor.DataSource = res;
        }

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string f1 = fecha1.Text;
            string f2 = fecha2.Text;
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and  a.fecha between '" + f1 + "' and '" + f2 + "' AND terminado=0 order by a.idcopia desc";
            res = x.selectData(sql);
            dgvservidor.DataSource = res;
        }

        //Combobox para buscar solicitud de copias de los usuarios por el departamento al que pertenece dicho usuario
        private void cmbdepartamentos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            int de = Convert.ToInt32(cmbdepartamentos.SelectedValue.ToString());

            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + de + "' AND terminado=0 order by a.idcopia desc";
            res = x.selectData(sql);
            dgvservidor.DataSource = res;
        }

        //Seleccionar la fotocopiadora de donde se va a procesar la solicitud
        private void cmbimpresoras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable res = new DataTable();
            int idfoto = Convert.ToInt32(cmbimpresoras.SelectedValue.ToString());
            string sql = "select cantidadhojas from Fotocopiadora where idfotocopiadora=" + idfoto;
            res = x.selectData(sql);

            txthojasimpresora.Text = res.Rows[0]["cantidadhojas"].ToString();
        }

        //Boton para procesar solicitud de copias
        private void btnprocesado_Click(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
            if (Convert.ToInt32(txthojasimpresora.Text) > 0) {
                DataTable res = new DataTable();
                string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.idcopia='" + codigo + "' order by a.idcopia desc";
                res = x.selectData(sql);

             if (Convert.ToInt32(res.Rows[0]["Cantidad de Copias"].ToString()) <= Convert.ToInt32(txthojasimpresora.Text)) {
                 int hojas = Convert.ToInt32(res.Rows[0]["Cantidad de Copias"].ToString());
                 int idfotocopiadora = Convert.ToInt32(cmbimpresoras.SelectedValue.ToString());
                 int cantidaddanada = (!txthojasdanadas.Text.Equals("")) ? Convert.ToInt32(txthojasdanadas.Text) : 0;
                 sql = "update copias Set terminado=1,hojas_danadas='" + cantidaddanada + "',procesadopor='" + codigoUsuario + "' WHERE idcopia=" + codigo;
                 x.sendData(sql);
                 sql = "update Fotocopiadora set cantidadhojas=cantidadhojas-" + (hojas + cantidaddanada) + " WHERE idfotocopiadora=" + idfotocopiadora;
                 x.sendData(sql);
                 cargar_datos();
                 txthojasdanadas.Text = "0";
              }
              else
              {
                  MessageBox.Show("La Fotocopiadora que Elegiste no Tiene Hojas Suficientes para Procesar esta Solicitud");
              }
              }
              else
              {
                  MessageBox.Show("La Fotocopiadora que Elegiste no Tiene Hojas Suficientes para Procesar esta Solicitud");
              }
              }
              else
              {
                  MessageBox.Show("Selecciona una Solicitud para Procesar");
              }
           }

        //Evento del Datagridview para seleccionar solicitud 
        private void dgvservidor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
                codigo = Convert.ToInt32(dgvservidor.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }

        private void txthojasdanadas_KeyPress(object sender, KeyPressEventArgs e)
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

        //Timer para cargar datos al dar checked al button checked actualizar
         private void timer1_Tick(object sender, EventArgs e)
        {
            if (Actualizar.Checked == true)
            {
                cargar_datos();
            }
        }

        //Boton para visualizar reportes de solicitudes por departamentos
        private void btnverreportedepartamentos_Click(object sender, EventArgs e)
        {
            ConexionDB x = new ConexionDB();
            DataSet ds = new DataSet();
            DataTable dt = x.selectData("select a.nombre as Departamento, sum(b.cantidad) as Cantidad, sum(b.cantidad*2) as Costo from departamento a inner join copias b on a.iddep=b.iddep group by b.iddep, b.fecha between '01/08/2017' and '31/08/2017'");
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "departamento, copias";
            ds.WriteXml(@"C:\sistemas\ReportesCopias\ReporteporDepartamentos.xml");
            Visor_de_Reportes f = new Visor_de_Reportes();
            f.Show();
        }

        //Boton para visualizar reportes de solicitudes por usuarios
        private void btnporsolicitante_Click(object sender, EventArgs e)
        {
            ConexionDB x = new ConexionDB();
            DataSet ds1 = new DataSet();
            DataTable dt1 = x.selectData("select a.nombreusuario, b.cantidad, b.cantidad*2 as Costo from usuarios a inner join copias b on a.idusuario=b.idusuario");
            ds1.Tables.Add(dt1);
            ds1.Tables[0].TableName = "departamento, copias";
            ds1.WriteXml(@"C:\sistemas\ReportesCopias\ReporteporUsuarios.xml");
            Visor_de_Reportes f1 = new Visor_de_Reportes();
            f1.Show();
        }

        //Boton para visualizar reportes de solicitudes por fecha de solicitud
        private void btnporfecha_Click(object sender, EventArgs e)
        {
            ConexionDB x = new ConexionDB();
            DataSet ds2 = new DataSet();
            DataTable dt2 = x.selectData("select a.nombreusuario, b.fecha, b.cantidad, b.cantidad*2 as Costo from usuarios a inner join copias b on a.idusuario=b.idusuario");
            ds2.Tables.Add(dt2);
            ds2.Tables[0].TableName = "usuarios, copias";
            ds2.WriteXml(@"C:\sistemas\ReportesCopias\ReporteporFecha.xml");
            Visor_de_Reportes f1 = new Visor_de_Reportes();
            f1.Show();
        }

        //Boton para visualizar reportes de solicitudes por costo
        private void btncosto_Click(object sender, EventArgs e)
        {
            ConexionDB x = new ConexionDB();
            DataSet ds3 = new DataSet();
            DataTable dt3 = x.selectData("select a.nombre as Departamento, sum(b.cantidad) as Cantidad, sum(b.cantidad)*2 as Costo from departamento a inner join copias b on a.iddep=b.iddep group by b.iddep");
            ds3.Tables.Add(dt3);
            ds3.Tables[0].TableName = "usuarios, copias";
            ds3.WriteXml(@"C:\sistemas\ReportesCopias\ReporteporCosto.xml");
            Visor_de_Reportes f1 = new Visor_de_Reportes();
            f1.Show();
        }

        //Salir del formulario
         private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
