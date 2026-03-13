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
            using var gradoviServis = new GradServis();
            cmbGrad.UcitajPodatke(gradoviServis.GetAll());
            cbAktivna.Checked = true;
        }
        bool ValidnaForma()
        {
            bool validno = Validator.ValidanUnos(txtNaziv, err) &&
                           Validator.ValidanUnos(txtAdresa, err) &&
                           Validator.ValidanUnos(txtURL, err) &&
                           Validator.ValidanUnos(cmbGrad, err) &&
                           Validator.ValidanUnos(txtMaxStudenata, err) &&
                           Validator.ValidanUnos(pbSlika, err);

            if (!validno) { return false; }
            else if (!Regex.IsMatch(txtURL.Text, urlPattern))
            {
                err.SetError(txtURL, "Format mora biti www.xx.xx");
                return false;
            }
            else if (int.TryParse(txtMaxStudenata.Text, out int max) && max < 0)
            {
                err.SetError(txtMaxStudenata, "Broj studenata ne moze bit negativan");
                return false;
            }

            string nazivKompanije = txtNaziv.Text;
            int gradId = (int)cmbGrad.SelectedValue!;

            using var servis = new KompanijeServisIB24xxxx();

            if (servis.GetAll().Any(x => x.Naziv.ToLower() == nazivKompanije.ToLower() && x.GradId == gradId))
            {
                MessageBox.Show($"Kompanija '{nazivKompanije}' je vec dodana za odabrani grad");
                return false;
            }

            return true;
        }
        private void Dodaj()
        {
            if (!ValidnaForma()) return;

            using var servis = new KompanijeServisIB24xxxx();
            
                var nova = new KompanijeIB24xxxx
                {
                    Naziv = txtNaziv.Text,
                    Adresa = txtAdresa.Text,
                    URL = txtURL.Text,
                    GradId = (int)cmbGrad.SelectedValue,
                    MaxStudenata = int.Parse(txtMaxStudenata.Text),
                    Logo = ImageHelper.ImageToByte(pbSlika.Image),
                    Aktivna = cbAktivna.Checked
                };

                servis.Add(nova);
                MessageBox.Show("Kompanija uspjesno dodana");
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }
        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Slike|*.jpg;*.jpeg;*.png;*.bmp"; //opcionalno

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}