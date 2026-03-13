using Studentska.Data.Modeli.IB24xxxx;
using Studentska.Servis.Servisi.IB24xxxx;
using Studentska.WinApp.Helpers;
using Studentska.WinApp.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IB24xxxx
{
    public partial class frmPretragaIB24xxxx : Form
    {
        public frmPretragaIB24xxxx()
        {
            InitializeComponent();
        }
        void UcitajPodatke(Func<StudentiPrakseIB24xxxx, bool> filter = null)
        {
            var servis = new StudentiPrakseServisIB24xxxx();
            var svePrakse = servis.GetAll();

            dgvPodaci.DataSource = null;
            dgvPodaci.Columns.Clear();

            IEnumerable<StudentiPrakseIB24xxxx> filtrirani;

            if (filter != null)
            {
                filtrirani = svePrakse.Where(filter);
            }
            else { filtrirani = svePrakse; }

            var podaci = filtrirani.Select(x => new ViewModelIB24xxxx {
                Id = x.Id,
                Student = x.Student.IndeksImePrezime,
                Kompanija = x.Kompanija.Naziv,
                Grad = x.Kompanija.Grad.Naziv,
                Status = x.Status.ToString(),
                DatumPromjeneStatusa = x.DatumPromjeneStatusa
            }).ToList();

            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = podaci;

            var obrisi = new DataGridViewButtonColumn
            {
                Name = "Obrisi",
                HeaderText = string.Empty,
                Text = "Obrisi",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            dgvPodaci.Columns.Add(obrisi);
            dgvPodaci.Columns["Id"].Visible = false;
        }
        private void UcitajStatuse()
        {
            var statusi = Enum.GetValues(typeof(StatusPrakse)).Cast<object>().ToList();
            statusi.Insert(0, "(Svi statusi)");
            cmbStatus.DataSource = statusi;
        }
        private void frmPretragaIB24xxxx_Load(object sender, EventArgs e)
        {
            UcitajStatuse();
            UcitajPodatke();
        }
        private void btnKompanijaAdd_Click(object sender, EventArgs e) => 
            new frmKompanijaAddIB24xxxx().PrikaziFormu(() => UcitajPodatke());
        private void btnPraksaAdd_Click(object sender, EventArgs e) =>
            new frmStudentiPrakseAddEditIB24xxxx().PrikaziFormu(() => UcitajPodatke());
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var podaci = dgvPodaci.DataSource as List<ViewModelIB24xxxx>;

            if (podaci != null && podaci.Count > 0)
            {
                new frmIzvjestaji(podaci).PrikaziFormu();
            }
            else
            {
                MessageBox.Show("Nema podataka za ispis!");
            }
        }
        private void Filtriraj()
        {
            var tekst = txtPretraga.Text.ToLower();

            var odabraniIndex = cmbStatus.SelectedIndex;

            UcitajPodatke(x =>
                (string.IsNullOrEmpty(tekst) ||
                 x.Student.Ime.ToLower().Contains(tekst) ||
                 x.Student.Prezime.ToLower().Contains(tekst) ||
                 x.Kompanija.Naziv.ToLower().Contains(tekst))
                &&
                (odabraniIndex == 0 || x.Status.ToString() == cmbStatus.SelectedItem?.ToString())
            );
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }
        private void dgvPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPodaci.Columns[e.ColumnIndex].Name == "Obrisi")
            {
                var odabranaPraksa = dgvPodaci.Rows[e.RowIndex].DataBoundItem as ViewModelIB24xxxx;

                if(odabranaPraksa!=null)
                {
                    if(MessageBox.Show("Da li ste sigurni da zelite nastaviti?"
                                        ,"Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        var servis = new StudentiPrakseServisIB24xxxx();
                        var zaObrisat = servis.GetAll().FirstOrDefault(x=>x.Id == odabranaPraksa.Id);

                        if (zaObrisat != null)
                        {
                            servis.Delete(zaObrisat.Id);
                            UcitajPodatke();
                        }
                    }
                }
            }
        }
        private void dgvPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var odabranaPraksa = dgvPodaci.Rows[e.RowIndex].DataBoundItem as ViewModelIB24xxxx;

            if (odabranaPraksa != null)
            {
                var servis = new StudentiPrakseServisIB24xxxx();
                var odabran = servis.GetAll().FirstOrDefault(x => x.Id == odabranaPraksa.Id);

                new frmStudentiPrakseAddEditIB24xxxx(odabran?.Id).PrikaziFormu(() => UcitajPodatke());
            }
        }
    }
}
