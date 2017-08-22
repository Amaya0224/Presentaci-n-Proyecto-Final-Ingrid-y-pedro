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
using CrystalDecisions.CrystalReports.Engine;


namespace Sistema_de_Fotocopias
{
    public partial class Generador_de_Reportes : Form
    {
        public int codigoUsuario = 0;
        public String nombreUsuario = "";
        public String tipo = "";
        public string imagen = "";
        public String departamento = "";
        ConexionDB x = new ConexionDB();

        public Generador_de_Reportes()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (radioconsumogerencia.Checked == true)
            {
           

            }
    
            else if (radiodepartamento.Checked == true)
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
            else if (radiosolicitante.Checked == true)
            {
                


                
            }
            else if (radiofecha.Checked == true)
            {


            }
            else if (radiocosto.Checked == true)
            {


            }
            else if (radiografico.Checked == true)
            {


            }
        }

        private void Generador_de_Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
