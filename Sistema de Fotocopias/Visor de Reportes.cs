using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Sistema_de_Fotocopias
{
    public partial class Visor_de_Reportes : Form
    {
        public Visor_de_Reportes()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public CrystalReport1 CrystalReport1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public CrystalReport2 CrystalReport2
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public CrystalReport3 CrystalReport3
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public CrystalReport4 CrystalReport4
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //Botón que llama el reporte por departamentos guardado en la localidad del proyecto, con manejadores de errores y refresca del Viewer del Crystal Report
        private void btnverreportedepartamentos_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\Sistema de Fotocopias\Sistema de Fotocopias\CrystalReport1.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón que llama el reporte por usuarios guardado en la localidad del proyecto, con manejadores de errores y refresca del Viewer del Crystal Report
        private void btnporsolicitante_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\Sistema de Fotocopias\Sistema de Fotocopias\CrystalReport2.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón que llama el reporte por fecha guardado en la localidad del proyecto, con manejadores de errores y refresca del Viewer del Crystal Report
        private void btnporfecha_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\Sistema de Fotocopias\Sistema de Fotocopias\CrystalReport3.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botón que llama el reporte por costo guardado en la localidad del proyecto, con manejadores de errores y refresca del Viewer del Crystal Report
        private void btncosto_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Ingrid\Desktop\VISUAL STUDIO\Sistema de Fotocopias\Sistema de Fotocopias\CrystalReport4.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Salir del formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
