using AirBosnia_API.Models;
using AirBosnia_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI.Employee
{
    public partial class EditForm : Form
    {
        private WebApiHelper gradServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.GradRoute);
        private WebApiHelper pozicijaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.TipZaposlenjaRoute);
        private WebApiHelper zaposlenikServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZaposlenikRoute);
        private WebApiHelper nalogServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisnickiNalogRoute);

        Zaposlenik z;
        KorisnickiNalog nalog = null;


        int tipZaposlenjaTemp;
        public EditForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = zaposlenikServis.GetActionResponse("GetZaposlenikByID", id.ToString());
            if (response.IsSuccessStatusCode)
            {
                z = response.Content.ReadAsAsync<Zaposlenik>().Result;
                FillForm();
            }
            else
            {
                z = null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillForm()
        {

            txtIme.Text = z.Ime;
            txtPrezime.Text = z.Prezime;
            txtEmail.Text = z.Email;
            txtTelefon.Text = z.Telefon;
            txtBrUgovora.Text = z.BrojUgovora;
            txtDatumRodenja.Value = z.DatumRodenja;
            if (z.Spol == "Muški")
                rbMuski.Checked = true;
            if(z.Spol == "Ženski")
                rbZenski.Checked = true;
            cbAktivan.Checked = z.Aktivan;
            tipZaposlenjaTemp = z.TipZaposlenjaID;

          

        }

        private void BindGradovi()
        {
            HttpResponseMessage response = gradServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Grad> gradovi = response.Content.ReadAsAsync<List<Grad>>().Result;
                gradovi.Insert(0, new Grad("*Odaberite grad*"));
                cmbGrad.DataSource = gradovi;
                cmbGrad.ValueMember = "GradID";
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.SelectedIndex = z.GradID;


            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void BindPozicije()
        {
            HttpResponseMessage response = pozicijaServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<TipZaposlenja> pozicije = response.Content.ReadAsAsync<List<TipZaposlenja>>().Result;
                pozicije.Insert(0, new TipZaposlenja("*Odaberite poziciju*"));
                cmbPozicija.DataSource = pozicije;
                cmbPozicija.ValueMember = "TipZaposlenjaID";
                cmbPozicija.DisplayMember = "Naziv";
                cmbPozicija.SelectedIndex = z.TipZaposlenjaID;

            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            BindGradovi();
            BindPozicije();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (z != null)
                {
                    z.Aktivan = cbAktivan.Checked;
                    z.BrojUgovora = txtBrUgovora.Text;
                    z.DatumRodenja = txtDatumRodenja.Value;
                    z.Email = txtEmail.Text;
                    z.GradID = Convert.ToInt32(cmbGrad.SelectedValue);
                    z.Ime = txtIme.Text;
                    z.Prezime = txtPrezime.Text;
                    if (rbMuski.Checked)
                        z.Spol = "Muški";
                    if (rbZenski.Checked)
                        z.Spol = "Ženski";
                    z.Telefon = txtTelefon.Text.Replace(" ", string.Empty);
                    z.TipZaposlenjaID = Convert.ToInt32(cmbPozicija.SelectedValue);

                    if (tipZaposlenjaTemp == 1 && z.TipZaposlenjaID != 1)
                    {
                        KorisnickiNalog k = z.KorisnickiNalog.Where(x => x.Status == true).FirstOrDefault();
                        if (k != null)
                        {
                            k.Status = false;
                            HttpResponseMessage nalogResponse = nalogServis.PutResponse(k.KorisnickiNalogID, k);
                            if (nalogResponse.IsSuccessStatusCode)
                            {
                                nalog = k;
                            }
                            else
                            {
                                MessageBox.Show(nalogResponse.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    if(tipZaposlenjaTemp !=1 && z.TipZaposlenjaID == 1)//prvo doda nalog pa izmjeni korisnika
                    {
                        HttpResponseMessage responseNalog = nalogServis.PostResponse(nalog);
                        if (!responseNalog.IsSuccessStatusCode)
                        {
                            MessageBox.Show(responseNalog.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    HttpResponseMessage response = zaposlenikServis.PutResponse(z.ZaposlenikID, z);
                    if (response.IsSuccessStatusCode)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void cmbPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbPozicija.SelectedIndex) == 1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (z.TipZaposlenjaID == 1)
            {
                MessageBox.Show("Zaposlenik " + z.Ime + " " + z.Prezime + " posjeduje korisnički račun", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nalog != null)
            {

                Account.EditForm f = new Account.EditForm(nalog.KorisnickoIme, nalog.Lozinka);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    nalog.KorisnickoIme = f.username;
                    nalog.Lozinka = f.password;
                }
            }
            else
            {
                Account.AddForm f = new Account.AddForm();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    nalog = new KorisnickiNalog();
                    nalog.KorisnickoIme = f.k.KorisnickoIme;
                    nalog.Lozinka = f.k.Lozinka;
                    nalog.Status = true;
                    nalog.ZaposlenikID = z.ZaposlenikID;

                    errorProvider.SetError(button1, null);

                }
            }
        }

        #region validacija
        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[a-žA-Ž]+$");
            Match match = regex.Match(txtIme.Text);

            if (String.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Ime je obavezno polje");
            }
            else if (txtIme.Text.Length <= 1)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Ime mora sadržavati više od 1 karaktera");
            }
            else if (txtIme.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Ime mora sadržavati manje od 50 karaktera");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Ime se sastoji od slova");
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {

            Regex regex = new Regex(@"^[a-žA-Ž]+$");
            Match match = regex.Match(txtPrezime.Text);

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Prezime je obavezno polje");
            }
            else if (txtPrezime.Text.Length <= 1)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Prezime mora sadržavati više od 1 karaktera");
            }
            else if (txtPrezime.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Prezime mora sadržavati manje od 50 karaktera");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Prezime se sastoji od slova");
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(txtEmail.Text);
            HttpResponseMessage response = zaposlenikServis.GetActionResponse("GetSearchByEmail", txtEmail.Text,z.ZaposlenikID.ToString());
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email je obavezno polje");
            }
            else if (txtEmail.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email adresa mora sadržavati manje od 50 karaktera");
            }
            else if (response.IsSuccessStatusCode)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email adresa je zauzeta");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email adresa nije validna");
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating_1(object sender, CancelEventArgs e)
        {
            HttpResponseMessage response = zaposlenikServis.GetActionResponse("SearchByTelefon", txtTelefon.Text.Substring(1).Replace(" ", string.Empty),z.ZaposlenikID.ToString());


            if (String.IsNullOrEmpty(txtTelefon.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, "Telefon je obavezno polje");
            }
            else if (txtTelefon.Text.Replace(" ", string.Empty).Length <= 5)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, "Telefon je obavezno polje");
            }
            else if (txtTelefon.Text.Replace(" ", string.Empty).Length > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, "Telefon mora sadržavati manje od 20 brojeva");
            }
            else if (response.IsSuccessStatusCode)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, "Telefon je zauzet");
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void cmbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGrad.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbGrad, "Grad je obavezno polje");
            }
            else
            {
                errorProvider.SetError(cmbGrad, null);
            }
        }

        private void txtBrUgovora_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrUgovora.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrUgovora, "Broj ugovora je obavezno polje");
            }
            else if (txtBrUgovora.Text.Length > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrUgovora, "Broj ugovora mora sadržavati manje od 20 karaktera");
            }
            else if (txtBrUgovora.Text.Length <= 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrUgovora, "Broj ugovora mora sadržavati više od 2 karaktera");
            }
            else
            {
                errorProvider.SetError(txtBrUgovora, null);
            }
        }

        private void cmbPozicija_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPozicija.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbPozicija, "Pozicija je obavezno polje");
            }
            else
            {
                errorProvider.SetError(cmbPozicija, null);
            }
        }

        private void rbZenski_Validating(object sender, CancelEventArgs e)
        {
            if (!rbMuski.Checked && !rbZenski.Checked)
            {
                e.Cancel = true;
                errorProvider.SetError(rbZenski, "Spol je obavezno polje");
            }
            else
            {
                errorProvider.SetError(rbZenski, null);
            }
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            if(tipZaposlenjaTemp !=1 && (Convert.ToInt32(cmbPozicija.SelectedValue))==1)//ako je sada admin
            {
                if(nalog == null)
                {
                    e.Cancel = true;
                    errorProvider.SetError(button1, "Potrebno je unijeti korisnički nalog");
                }
                else
                {
                    errorProvider.SetError(button1, null);
                }
            }
            else
            {
                errorProvider.SetError(button1, null);
            }
        }
        #endregion

        
    }
}
