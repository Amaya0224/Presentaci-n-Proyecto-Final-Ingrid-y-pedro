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
    public partial class Aprobaciones : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        public int iddep = 0;
        public int codigo = 0;

        ConexionDB x = new ConexionDB();

        public Aprobaciones()
        {
            InitializeComponent();
        }

        //*********************************************************************************
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

        // Cargar datos al DatagriedView de aprobaciones
        public void cargar_datos()
        {
            System.Data.DataTable res = new System.Data.DataTable();

            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and a.aprobado=0 order by a.idcopia desc";
            res = x.selectData(sql);
            dgvaprobaciones.DataSource = res;
        }

        //Carga foto y nombre de usuario que inicio seccion y tambien carga datos al Datagriedview de aprobaciones, 
        private void Aprobaciones_Load(object sender, EventArgs e)
        {
            txtusuario.Text = nombreUsuario;
            foto1.Load(procesar(imagen));
            cargar_datos();
        }
        // Metodo para cargar foto del usuario logeado
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

        //Salir del formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         //Busqueda de solicitudes, según titulo del documento a copiar
        private void btnbusquedaaprobacion_Click(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string Titulo = "%" + txtbusquedaaprobacion.Text + "%";
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and a.titulo like '" + Titulo + "' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvaprobaciones.DataSource = res;
        }

        //Parametros de fechas para inicar la busqueda, fecha 1 fecha inicial y fecha2 fecha final
        private void fecha1_ValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string f1 = fecha1.Text;
            string f2 = fecha2.Text;
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and  a.fecha between '" + f1 + "' and '" + f2 + "' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvaprobaciones.DataSource = res;
        }

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable res = new System.Data.DataTable();
            string f1 = fecha1.Text;
            string f2 = fecha2.Text;
            string sql = "select a.idcopia as ID, a.titulo as 'Título del Documento', a.cantidad as 'Cantidad de Copias', a.cara as Cara, b.nombreusuario as Usuario, case when a.aprobado=0 then 'No' else 'Si' end as Aprobado, case when a.terminado=0 then 'No' else 'Si' end as Terminado from copias a inner join usuarios b on a.idusuario=b.idusuario where a.del=1 and a.iddep='" + iddep + "' and  a.fecha between '" + f1 + "' and '" + f2 + "' order by a.idcopia desc";
            res = x.selectData(sql);
            dgvaprobaciones.DataSource = res;
        }

        //Timer para recargar los datos del Datagriedview
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Actualizar.Checked == true)
            {
                cargar_datos();
            }
        }

       //Al hacer click en una fila del Datagriedview de aprobaciones, seleccionar para aprobar o noaprobar 
       private void dgvaprobaciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            codigo = Convert.ToInt32(dgvaprobaciones.Rows[e.RowIndex].Cells["ID"].Value.ToString());        
        }

        // Botón de aprobado actualiza la tabla copias en la base de datos, quita el contenido de la fila selecionada en el Datagriedview y carga los datos nuevamente o que de lo contrario active un mensaje que debe seleccionar una fila para poder ser aprobada
        private void btnaprobado_Click(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                DialogResult limpiar = MessageBox.Show("Deseas aprobar esta solicitud", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (limpiar == DialogResult.Yes)
                {
                    string sql = "Update copias set aprobadopor='"+codigoUsuario+"', aprobado=1 where idcopia=" + codigo;
                    x.sendData(sql);
                    cargar_datos();
                    codigo = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una solicitud para aprobar", "ADVERTENCIA");
            }
        }

        //Botón de noaprobado, el usuario debe seleccionar la fila del Datagriedview de aprobaciones que no desea aprobar, pero debe indicar porque no procede la aprobacion de dicha solicitud.
        private void btnnoaprobado_Click(object sender, EventArgs e)
        {
            if (codigo != 0)
            { 
                if (txtnotaaprobacion.Text.Equals(""))
            {
                MessageBox.Show("Debes justificar la no aprobación de la solicitud", "ADVERTENCIA");
                txtnotaaprobacion.Focus();
            }
            else
            {
                DialogResult limpiar = MessageBox.Show("Seguro que no deseas aprobar la solicitud", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (limpiar == DialogResult.Yes)
            {
                string sql = "Update copias set aprobadopor='" + codigoUsuario + "', aprobado=2, notaaprobar='" + txtnotaaprobacion.Text+"' where idcopia=" + codigo;
                x.sendData(sql);
                cargar_datos();
                txtnotaaprobacion.Clear();
                codigo = 0;
            }
            }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una solicitud para No aprobar", "ADVERTENCIA");
            }
        }
    }
    }
