using Microsoft.Reporting.WinForms;
using Studentska.Data.Modeli.IB24xxxx;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        List<ViewModelIB24xxxx> podaci;
        public frmIzvjestaji(List<ViewModelIB24xxxx> podaci = null)
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
               "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
            this.podaci = podaci;
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            if (podaci != null)
            {
                var brojac = 0;
                var dt = podaci.Select(x => new
                {
                    Rb = ++brojac,
                    Student = x.Student,
                    Kompanija = x.Kompanija,
                    Status = x.Status,
                    DatumPromjene = x.DatumPromjeneStatusa

                }).ToList();

                var p = new ReportParameter("brojac",brojac.ToString());

                reportViewer1.LocalReport.SetParameters(p);

                var rds = new ReportDataSource();

                rds.Name = "DataSet1";
                rds.Value = dt;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            reportViewer1.RefreshReport();
        }
    }
}
