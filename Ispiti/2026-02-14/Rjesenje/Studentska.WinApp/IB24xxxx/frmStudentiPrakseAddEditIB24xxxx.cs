using DocumentFormat.OpenXml.Drawing.Charts;
using Studentska.Data.Entiteti;
using Studentska.Data.Modeli.IB24xxxx;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IB24xxxx;
using Studentska.WinApp.Helpers;
using System;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Windows.Forms;

namespace Studentska.WinApp.IB24xxxx
{
    public partial class frmStudentiPrakseAddEditIB24xxxx : Form
    {
        int? praksaId;
        public frmStudentiPrakseAddEditIB24xxxx(int? praksaId = null)
        {
            InitializeComponent();
            this.praksaId = praksaId;
        }
        private void frmStudentiPrakseAddEditIB24xxxx_Load(object sender, EventArgs e)
        {
            UcitajPodatkeUCombo();

            if (praksaId.HasValue)
            {
                UcitajPraksuZaEdit();
            }
            else
            {
                cmbStatus.SelectedItem = StatusPrakse.PODNESENA;
                cmbStatus.Enabled = false;
            }
        }
        private void UcitajPodatkeUCombo()
        {
            using (var studentServis = new StudentServis())
            {
                Ekstenzije.UcitajPodatke(cmbStudent, studentServis.GetAll(), "Id", "IndeksImePrezime");
            }

            using (var kompanijeServis = new KompanijeServisIB24xxxx())
            {
                var kompanije = kompanijeServis.GetAll().Where(x => x.Aktivna).ToList();
                Ekstenzije.UcitajPodatke(cmbKompanija, kompanije);
            }

            cmbStatus.DataSource = Enum.GetValues(typeof(StatusPrakse));
        }
        private void UcitajPraksuZaEdit()
        {
            using (var s = new StudentiPrakseServisIB24xxxx())
            {
                var praksa = s.GetAll().FirstOrDefault(x => x.Id == praksaId);
                if (praksa != null)
                {
                    cmbStudent.SelectedValue = praksa.StudentId;
                    cmbKompanija.SelectedValue = praksa.KompanijaId;
                    dtpDatumPrijave.Value = praksa.DatumPrijave;
                    cmbStatus.SelectedItem = praksa.Status;
                    cmbStatus.Enabled = true;
                }
            }
        }
        private bool Validno()
        {
            bool validno = Validator.ValidanUnos(cmbStudent, err) &&
                           Validator.ValidanUnos(cmbKompanija, err);

            if (!validno) return false;

            var student = cmbStudent.SelectedItem as Student;
            var kompanija = cmbKompanija.SelectedItem as KompanijeIB24xxxx;
            var status = (StatusPrakse)cmbStatus.SelectedItem!;

            using (var s = new StudentiPrakseServisIB24xxxx())
            {
                var svePrakse = s.GetAll();

                if (status == StatusPrakse.PRIHVACENA)
                {
                    var brojPrihvacenih = svePrakse.Count(x => x.KompanijaId == kompanija.Id &&
                                                           x.Status == StatusPrakse.PRIHVACENA &&
                                                           x.Id != praksaId);

                    if (brojPrihvacenih >= kompanija.MaxStudenata)
                    {
                        MessageBox.Show("Kapacitet kompanije je popunjen");
                        return false;
                    }
                }

                if (!praksaId.HasValue)
                {
                    if (svePrakse.Any(x => x.StudentId == student.Id 
                    && x.KompanijaId == kompanija.Id && x.Status != StatusPrakse.ODBIJENA))
                    {
                        MessageBox.Show("Student je vec poslao zahtjev ovoj kompaniji.");
                        return false;
                    }

                    if (svePrakse.Any(x => x.StudentId == student.Id && x.Status == StatusPrakse.PRIHVACENA))
                    {
                        MessageBox.Show("Student vec ima jednu aktivnu praksu.");
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validno()) return;

            var student = cmbStudent.SelectedItem as Student;
            var kompanija = cmbKompanija.SelectedItem as KompanijeIB24xxxx;
            var status = (StatusPrakse)cmbStatus.SelectedItem!;

            using (var s = new StudentiPrakseServisIB24xxxx())
            {
                StudentiPrakseIB24xxxx objekt;

                if (praksaId.HasValue)
                {
                    objekt = s.GetAll().First(x => x.Id == praksaId);
                    if (objekt.Status != status)
                        objekt.DatumPromjeneStatusa = DateTime.Now;
                }
                else
                {
                    objekt = new StudentiPrakseIB24xxxx();
                }

                objekt.StudentId = student.Id;
                objekt.KompanijaId = kompanija.Id;
                objekt.Status = status;
                objekt.DatumPrijave = dtpDatumPrijave.Value;

                if (praksaId.HasValue) s.Update(objekt);
                else s.Add(objekt);
            }

            MessageBox.Show("Uspjesno sacuvano");
            this.DialogResult = DialogResult.OK;
        }
        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;

            Task.Run(() =>
            {
                using (var s = new StudentiPrakseServisIB24xxxx())
                using (var k = new KompanijeServisIB24xxxx())
                {
                    var sveKompanije = k.GetAll();
                    var postojecePrakseStudenta = s.GetAll().Where(x => x.StudentId == student.Id).ToList();

                    var kompanijeZaAplicirati = sveKompanije
                        .Where(komp => !postojecePrakseStudenta.Any(p => p.KompanijaId == komp.Id))
                        .ToList();

                    int brojac = 1;
                    foreach (var komp in kompanijeZaAplicirati)
                    {
                        var novaPraksa = new StudentiPrakseIB24xxxx
                        {
                            StudentId = student.Id,
                            KompanijaId = komp.Id,
                            DatumPrijave = DateTime.Now,
                            Status = StatusPrakse.PODNESENA
                        };

                        s.Add(novaPraksa);

                        string info = $"{brojac++}. -> {DateTime.Now} kreiran zahtjev za praksu " +
                        $"{student.IndeksImePrezime} u kompaniji {komp.Naziv}\n";

                        richTextBox1.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText(info);
                        }));

                        Thread.Sleep(300);
                    }

                    MessageBox.Show("Dodavanje podataka zavrseno!");

                    this.Invoke(new Action(() =>
                    {
                        this.DialogResult = DialogResult.OK;
                    }));
                }
            });
        }
    }
}