using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Studentska.Data.Modeli.IB24xxxx;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IB24xxxx;
using Studentska.WinApp.Helpers;

namespace Studentska.WinApp.IB24xxxx
{
    public partial class frmKompanijaAddIB24xxxx : Form
    {
        string urlPattern = @"^www\.[a-zA-Z]{2,}\.[a-zA-Z]{2,}$";

        public frmKompanijaAddIB24xxxx()
        {
            InitializeComponent();
        }
        private void frmKompanijaAddIB24xxxx_Load(object sender, EventArgs e)
        {
            using (var gradoviServis = new GradServis())
            {
                Ekstenzije.UcitajPodatke(cmbGrad, gradoviServis.GetAll());
            }
            cbAktivna.Checked = true;
        }
        bool ValidnaForma()
        {
            bool validno = Validator.ValidanUnos(txtNaziv, err) &&
                           Validator.ValidanUnos(txtAdresa, err) &&
                           Validator.ValidanUnos(txtURL, err) &&
                           Validator.ValidanUnos(cmbGrad, err) &&
                           Validator.ValidanUnos(txtMaxStudenata, err);
            if (!validno) return false;

            if (!Regex.IsMatch(txtURL.Text, urlPattern))
            {
                err.SetError(txtURL, "Format mora biti www.xx.xx");
                MessageBox.Show("Format URL-a mora biti www.xx.xx");
                validno = false;
            }

            if (int.TryParse(txtMaxStudenata.Text, out int max) && max < 0)
            {
                err.SetError(txtMaxStudenata, "Broj studenata ne moze bit negativan");
                MessageBox.Show("Broj studenata ne moze bit negativan");
                validno = false;
            }

            var naziv = txtNaziv.Text;
            var gradId = (int)cmbGrad.SelectedValue;
            using (var servis = new KompanijeServisIB24xxxx())
            {
                if (servis.GetAll().Any(x => x.Naziv.ToLower() == naziv.ToLower() && x.GradId == gradId))
                {
                    MessageBox.Show($"Kompanija '{naziv}' je vec dodana za odabrani grad");
                    validno = false;
                }
            }
            return validno;
        }
        private void Dodaj()
        {
            if (!ValidnaForma()) return;

            using (var servis = new KompanijeServisIB24xxxx())
            {
                var nova = new KompanijeIB24xxxx
                {
                    Naziv = txtNaziv.Text,
                    Adresa = txtAdresa.Text,
                    URL = txtURL.Text,
                    GradId = (int)cmbGrad.SelectedValue,
                    MaxStudenata = int.Parse(txtMaxStudenata.Text),
                    Logo = ImageHelper.ImageToByte(pbSlika.Image),
                    Aktivna = cbAktivna.Checked ? true : false
                };

                servis.Add(nova);

                MessageBox.Show("Kompanija uspjesno dodana");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }
        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}