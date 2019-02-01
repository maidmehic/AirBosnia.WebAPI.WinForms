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
    public partial class AddForm : Form
    {
        private WebApiHelper gradServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.GradRoute);
        private WebApiHelper pozicijaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.TipZaposlenjaRoute);
        private WebApiHelper zaposlenikServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZaposlenikRoute);
        private WebApiHelper nalogServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.KorisnickiNalogRoute);


        Zaposlenik novi = new Zaposlenik();
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                novi.Aktivan = true;
                novi.BrojUgovora = txtBrUgovora.Text;
                novi.DatumRodenja = txtDatumRodenja.Value;
                novi.Email = txtEmail.Text;
                novi.GradID = Convert.ToInt32(cmbGrad.SelectedValue);
                novi.Ime = txtIme.Text;
                novi.Prezime = txtPrezime.Text;
                novi.Telefon = txtTelefon.Text.Replace(" ",string.Empty);
                novi.TipZaposlenjaID = Convert.ToInt32(cmbPozicija.SelectedValue);
                if (rbMuski.Checked)
                    novi.Spol = "Muški";
                if (rbZenski.Checked)
                    novi.Spol = "Ženski";

                if (novi.TipZaposlenjaID == 1)
                {
                    KorisnickiNalog k = new KorisnickiNalog();
                    k.KorisnickoIme = txtusr.Text;
                    k.Lozinka = txtpass.Text;
                    k.Status = true;
                    novi.KorisnickiNalog.Add(k);
                }

                HttpResponseMessage response = zaposlenikServis.PostResponse(novi);
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindPozicije();
            BindGradovi();
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
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

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
            HttpResponseMessage response = zaposlenikServis.GetActionResponse("GetSearchByEmail", txtEmail.Text,0.ToString());
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, "Email je obavezno polje");
            }
            else if (txtEmail.Text.Length>50)
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
            HttpResponseMessage response = zaposlenikServis.GetActionResponse("SearchByTelefon", txtTelefon.Text.Substring(1).Replace(" ", string.Empty),0.ToString());

            
            if (String.IsNullOrEmpty(txtTelefon.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTelefon, "Telefon je obavezno polje");
            }
            else if (txtTelefon.Text.Replace(" ", string.Empty).Length <=9)
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
            if(cmbGrad.SelectedIndex == 0)
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
            else if (txtBrUgovora.Text.Length >20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrUgovora, "Broj ugovora mora sadržavati manje od 20 karaktera");
            }
            else if (txtBrUgovora.Text.Length <=2)
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
            if(!rbMuski.Checked && !rbZenski.Checked)
            {
                e.Cancel = true;
                errorProvider.SetError(rbZenski, "Spol je obavezno polje");
            }
            else
            {
                errorProvider.SetError(rbZenski, null);
            }
        }

        private void txtusr_Validating(object sender, CancelEventArgs e)
        {
            if(cmbPozicija.SelectedIndex == 1)
            {
                Regex regex = new Regex(@"^[a-z]+[_\.]?[a-z]+$");
                Match match = regex.Match(txtusr.Text);

                HttpResponseMessage response = nalogServis.GetActionResponse("GetNalogByUsername", txtusr.Text,0.ToString());

                if (String.IsNullOrEmpty(txtusr.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtusr, "Korisničko ime je obavezno polje");
                }
                else if (response.IsSuccessStatusCode)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtusr, "Korisničko ime je zauzeto");
                }
                else if (txtusr.Text.Length > 20)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtusr, "Korisničko ime mora sadržavati manje od 20 karaktera");
                }
                else if (txtusr.Text.Length <= 2)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtusr, "Korisničko ime mora sadržavati više od 2 karaktera");
                }
                else if (!match.Success)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtusr, "Potrebno je koristiti mala slova, '.' i '_'");
                }
                else
                {
                    errorProvider.SetError(txtusr, null);
                }
            }
            else
            {
                errorProvider.SetError(txtusr, null);
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPozicija.SelectedIndex == 1)
            {
                if (String.IsNullOrEmpty(txtpass.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtpass, "Lozinka je obavezno polje");
                }
                else if (txtpass.Text.Length <= 3)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtpass, "Lozinka mora sadržavati više od 3 karaktera");
                }
                else if (txtpass.Text.Length > 20)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtpass, "Lozinka mora sadržavati manje od 20 karaktera");
                }
                else
                {
                    errorProvider.SetError(txtpass, null);
                }
            }
            else
            {
                errorProvider.SetError(txtpass, null);
            }
        }

        private void cmbPozicija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPozicija.SelectedIndex == 1)
            {
                txtusr.Enabled = true;
                txtpass.Enabled = true;
            }
            else
            {
                txtusr.Enabled = false;
                txtpass.Enabled = false;
            }
        }

        
    }
}
