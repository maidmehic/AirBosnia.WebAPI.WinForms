using AirBosnia_API.ViewModels;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI.Reports
{
    public partial class reportForm : Form
    {
        Rezervacija_ReportVM Rezervacije;
        public reportForm(Rezervacija_ReportVM rezervacije)
        {
            InitializeComponent();
            Rezervacije = rezervacije;
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("rezervacije", Rezervacije.podaci);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Polaziste",Rezervacije.Polaziste));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Odrediste",Rezervacije.Odrediste));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumLeta",Rezervacije.DatumLeta));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VrijemePolaska",Rezervacije.VrijemePolaska));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojLeta",Rezervacije.BrojLeta));
            this.reportViewer1.RefreshReport();
        }
    }
}
