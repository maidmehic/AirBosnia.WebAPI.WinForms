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

namespace AirBosnia_UI.Flight
{
    public partial class AddForm : Form
    {
        private WebApiHelper gradServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.GradRoute);
        private WebApiHelper sjedisteServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.SjedisteRoute);
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.LetRoute);
        private WebApiHelper avionServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.AvionRoute);

        Let noviLet = new Let();

        public AddForm()
        {
            InitializeComponent();
            dgvPosada.AutoGenerateColumns = false;
            this.AutoValidate = AutoValidate.Disable;

        }

        private void BindOdrediste()
        {
            HttpResponseMessage response = gradServis.GetActionResponse("GetPolazisteOdrediste", "parametar");
            if (response.IsSuccessStatusCode)
            {
                List<Grad> gradovi = response.Content.ReadAsAsync<List<Grad>>().Result;
                gradovi.Insert(0, new Grad("*Odaberite odredište*"));
                cmbOdrediste.DataSource = gradovi.OrderBy(x=>x.Naziv).ToList();
                cmbOdrediste.ValueMember = "GradID";
                cmbOdrediste.DisplayMember = "Naziv";
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void BindPolaziste()
        {
            HttpResponseMessage response = gradServis.GetActionResponse("GetPolazisteOdrediste", "parametar");
            if (response.IsSuccessStatusCode)
            {
                List<Grad> gradovi = response.Content.ReadAsAsync<List<Grad>>().Result;
                gradovi.Insert(0, new Grad("*Odaberite polazište*"));
                cmbPolaziste.DataSource = gradovi.OrderBy(x => x.Naziv).ToList();
                cmbPolaziste.ValueMember = "GradID";
                cmbPolaziste.DisplayMember = "Naziv";
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
        bool postojiBussiness = false;
        private void btnOdabirAviona_Click(object sender, EventArgs e)
        {
            ChoosePlane f = new ChoosePlane();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtNazivA.Text = f.odabraniAvion.Naziv;
                txtOznakaA.Text = f.odabraniAvion.Oznaka;
                txtBrSjedistaA.Text =(f.odabraniAvion.BrojSjedistaBuss+f.odabraniAvion.BrojSjedistaEco).ToString();

                noviLet.AvionID = f.odabraniAvion.AvionID;

                if (f.odabraniAvion.BrojSjedistaBuss == 0)
                {
                    txtBussOdrasli.Enabled = false;
                    txtBussDjeca.Enabled = false;
                    txtBussOdrasli.Text = "Bussiness klasa nedostupna";
                    txtBussDjeca.Text = "Bussiness klasa nedostupna";
                    postojiBussiness = false;

                }
                else
                {
                    txtBussOdrasli.Enabled = true;
                    txtBussDjeca.Enabled = true;
                    txtBussOdrasli.Text = "";
                    txtBussDjeca.Text = "";
                    postojiBussiness = true;
                }
            }
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            AddCrewMember f = new AddCrewMember();
            if (f.ShowDialog() == DialogResult.OK)
            {
                bool pronadenDuplikat = false;

                foreach (PosadaLeta posada in noviLet.PosadaLeta.ToList())
                {
                    if (posada.ClanPosadeID == f.odabraniZaposlenik.ZaposlenikID)
                        pronadenDuplikat = true;
                }

                if (pronadenDuplikat == false)
                {
                    PosadaLeta p = new PosadaLeta();
                    p.ClanPosadeID = f.odabraniZaposlenik.ZaposlenikID;
                    p.DatumRodenja = f.odabraniZaposlenik.DatumRodenja;
                    p.Ime = f.odabraniZaposlenik.Ime;
                    p.Prezime = f.odabraniZaposlenik.Prezime;
                    p.Pozicija = f.odabraniZaposlenik.Pozicija;
                    p.Telefon = f.odabraniZaposlenik.Telefon;

                    noviLet.PosadaLeta.Add(p);
                    dgvPosada.DataSource = noviLet.PosadaLeta.ToList();
                    dgvPosada.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Odabrani zaposlenik je već dodan", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            BindPolaziste();
            BindOdrediste();
        }

        private void cmbPolaziste_Format(object sender, ListControlConvertEventArgs e)
        {
            string naziv = ((Grad)e.ListItem).Naziv;
            string oznaka = ((Grad)e.ListItem).Oznaka;
            e.Value = naziv + "  " + oznaka;
        }

        private void cmbOdrediste_Format(object sender, ListControlConvertEventArgs e)
        {
            string naziv = ((Grad)e.ListItem).Naziv;
            string oznaka = ((Grad)e.ListItem).Oznaka;
            e.Value = naziv + "  " + oznaka;
        }

        private void btnUkloniClana_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvPosada.SelectedRows[0].Cells[0].Value);
                foreach (PosadaLeta p in noviLet.PosadaLeta.ToList())
                {
                    if (p.ClanPosadeID == id)
                        noviLet.PosadaLeta.Remove(p);
                }
                dgvPosada.DataSource = noviLet.PosadaLeta.ToList();
                dgvPosada.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati člana posade", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnProcesiraj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                noviLet.PolazisteID = Convert.ToInt32(cmbPolaziste.SelectedValue);
                noviLet.OdredisteID = Convert.ToInt32(cmbOdrediste.SelectedValue);
                noviLet.BrojLeta = txtBrojLeta.Text;
                noviLet.DatumVrijemePolaska = txtDatumPolaska1.Value;
                noviLet.DatumVrijemeDolaska = txtDatumDolaska.Value;
                noviLet.ZaposlenikID = Global.logirani.ZaposlenikID;
                noviLet.StatusLeta = false;//isOtkazan
                noviLet.isPosebnaPonuda = cbPosPonuda.Checked;
                if (postojiBussiness)
                {
                    try
                    {
                        noviLet.CijenaBussOdrasli = Convert.ToDouble(txtBussOdrasli.Text);
                        noviLet.CijenaBussDjeca = Convert.ToDouble(txtBussDjeca.Text);
                    } catch (Exception)
                    {
                        MessageBox.Show("Unesena cijena nije validna", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    noviLet.CijenaBussOdrasli = 0;
                    noviLet.CijenaBussDjeca = 0;
                }

                try
                {
                    noviLet.CijenaEcoDjeca = Convert.ToDouble(txtEkoDjeca.Text);
                    noviLet.CijenaEcoOdrasli = Convert.ToDouble(txtEkoOdrasli.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unesena cijena nije validna", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               

                HttpResponseMessage response = letServis.PostResponse(noviLet);
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

        private void btnOdabirAviona_Validating(object sender, CancelEventArgs e)
        {
            if (noviLet.AvionID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdabirAviona, "Potrebno je odabrati avion");
            }
            else
            {
                errorProvider.SetError(btnOdabirAviona, null);
            }
        }

        private void cmbPolaziste_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPolaziste.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbPolaziste, "Potrebno je odabrati polazište");
            }
            else if (Convert.ToInt32(cmbPolaziste.SelectedValue) == Convert.ToInt32(cmbOdrediste.SelectedValue))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbPolaziste, "Polazište i odredište ne smiju biti isti");
            }
            else
            {
                errorProvider.SetError(cmbPolaziste, null);
            }
        }

        private void cmbOdrediste_Validating(object sender, CancelEventArgs e)
        {
            if (cmbOdrediste.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbOdrediste, "Potrebno je odabrati odredište");
            }
            else if (Convert.ToInt32(cmbPolaziste.SelectedValue) == Convert.ToInt32(cmbOdrediste.SelectedValue))
            {
                e.Cancel = true;
                errorProvider.SetError(cmbPolaziste, "Polazište i odredište ne smiju biti isti");
            }
            else
            {
                errorProvider.SetError(cmbOdrediste, null);
            }
        }

        private void txtBrojLeta_Validating_1(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-Z0-9 ]*[A-Z0-9][A-Z0-9 ]*$");
            Match match = regex.Match(txtBrojLeta.Text);

            if (String.IsNullOrEmpty(txtBrojLeta.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojLeta, "Broj leta je obavezno polje");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojLeta, "Zabranjeno korištenje malih slova i specijalnih karaktera");
            }
            else
            {
                errorProvider.SetError(txtBrojLeta, null);
            }
        }

        private void txtDatumPolaska1_Validating(object sender, CancelEventArgs e)
        {
            DateTime polazak = txtDatumPolaska1.Value;
            DateTime dolazak = txtDatumDolaska.Value;

            if (polazak < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumPolaska1, "Datum i vrijeme polaska ne smiju biti manji od trenutnog vremena");
            }
            else if (polazak == dolazak)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumPolaska1, "Termini polaska i dolaska ne smiju biti isti");
            }
            else
            {
                errorProvider.SetError(txtDatumPolaska1, null);
            }
        }

        private void txtDatumDolaska_Validating(object sender, CancelEventArgs e)
        {
            DateTime polazak = txtDatumPolaska1.Value;
            DateTime dolazak = txtDatumDolaska.Value;

            if (dolazak < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumDolaska, "Datum i vrijeme dolaska ne smiju biti manji od trenutnog vremena");
            }
            else if (polazak == dolazak)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumDolaska, "Termini polaska i dolaska ne smiju biti isti");
            }
            else if (dolazak<polazak)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumDolaska, "Termin dolaska mora biti veći od termina polaska");
            }
            else
            {
                errorProvider.SetError(txtDatumDolaska, null);
            }
        }

        private void txtBussOdrasli_Validating(object sender, CancelEventArgs e)
        {
            if (postojiBussiness)
            {
                Regex regex = new Regex("^([0-9]{0,5}((.)[0-9]{0,2}))$");
                Match match = regex.Match(txtBussOdrasli.Text);

                if (String.IsNullOrEmpty(txtBussOdrasli.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBussOdrasli, "Cijena je obavezno polje");
                }
                else if (!match.Success)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBussOdrasli, "Unesena cijena mora imati format (00000.00)");
                }
                else
                {
                    errorProvider.SetError(txtBussOdrasli, null);
                }
            }
        }

        private void txtBussDjeca_Validating(object sender, CancelEventArgs e)
        {
            if (postojiBussiness)
            {
                Regex regex = new Regex("^([0-9]{0,5}((.)[0-9]{0,2}))$");
                Match match = regex.Match(txtBussDjeca.Text);

                if (String.IsNullOrEmpty(txtBussDjeca.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBussDjeca, "Cijena je obavezno polje");
                }
                else if (!match.Success)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtBussDjeca, "Unesena cijena mora imati format (00000.00)");
                }
                else
                {
                    errorProvider.SetError(txtBussDjeca, null);
                }
            }
        }

        private void txtEkoOdrasli_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^([0-9]{0,5}((.)[0-9]{0,2}))$");
            Match match = regex.Match(txtEkoOdrasli.Text);

            if (String.IsNullOrEmpty(txtEkoOdrasli.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEkoOdrasli, "Cijena je obavezno polje");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEkoOdrasli, "Unesena cijena mora imati format (00000.00)");
            }
            else
            {
                errorProvider.SetError(txtEkoOdrasli, null);
            }
        }

        private void txtEkoDjeca_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^([0-9]{0,5}((.)[0-9]{0,2}))$");
            Match match = regex.Match(txtEkoDjeca.Text);

            if (String.IsNullOrEmpty(txtEkoDjeca.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEkoDjeca, "Cijena je obavezno polje");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtEkoDjeca, "Unesena cijena mora imati format (00000.00)");
            }
            else
            {
                errorProvider.SetError(txtEkoDjeca, null);
            }
        }

        private void btnDodajClana_Validating(object sender, CancelEventArgs e)
        {
            if (noviLet.PosadaLeta.ToList().Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(btnDodajClana, "Potrebno je dodati posadu na letu");
            }
            else
            {
                errorProvider.SetError(btnDodajClana, null);
            }
        }

       
    }
}
