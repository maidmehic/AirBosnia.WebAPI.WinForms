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
    public partial class EditForm : Form
    {
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.LetRoute);
        private WebApiHelper posadaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PosadaLetaRoute);
        private WebApiHelper gradServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.GradRoute);
        Let let;
        bool postojiBussiness = false;
        public EditForm(int id)
        {
            InitializeComponent();
            dgvPosada.AutoGenerateColumns = false;
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = letServis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                let = response.Content.ReadAsAsync<Let>().Result;
                if (let.Avion.BrojSjedistaBuss == 0)
                {
                    postojiBussiness = false;
                }
                else
                {
                    postojiBussiness = true;

                }

                FillForm();
            }
            else
            {
                let= null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool tempOtkazan = false;
        private void FillForm()
        {
            txtNazivA.Text = let.Avion.Naziv;
            txtOznakaA.Text = let.Avion.Oznaka;
            txtBrSjedistaA.Text = (let.Avion.BrojSjedistaBuss+let.Avion.BrojSjedistaEco).ToString();
            txtBrojLeta.Text = let.BrojLeta;
            txtDatumPolaska.Value = let.DatumVrijemePolaska;
            txtDatumDolaska.Value = let.DatumVrijemeDolaska;
            cbPosPonuda.Checked = let.isPosebnaPonuda??false;

            if (postojiBussiness)
            {
                txtBussDjeca.Text = let.CijenaBussDjeca.ToString();
                txtBussOdrasli.Text = let.CijenaBussOdrasli.ToString();
            }
            else
            {
                txtBussDjeca.Text = "Bussiness klasa nedostupna";
                txtBussOdrasli.Text = "Bussiness klasa nedostupna";
                txtBussDjeca.Enabled = false;
                txtBussOdrasli.Enabled = false;
            }


            txtEkoDjeca.Text = let.CijenaEcoDjeca.ToString();
            txtEkoOdrasli.Text = let.CijenaEcoOdrasli.ToString();
            tempOtkazan = let.StatusLeta;
            cbOtkazi.Checked = let.StatusLeta;
        }

        int brojClanova = 0;
        private void BindPosada()
        {
            HttpResponseMessage response = posadaServis.GetActionResponse("SearchPosadaLeta", let.LetID.ToString());
            if (response.IsSuccessStatusCode)
            {
               
                dgvPosada.DataSource = response.Content.ReadAsAsync<List<PosadaLeta>>().Result;
                dgvPosada.ClearSelection();
                brojClanova = dgvPosada.RowCount;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindOdrediste()
        {
            HttpResponseMessage response = gradServis.GetActionResponse("GetPolazisteOdrediste", "parametar");
            if (response.IsSuccessStatusCode)
            {
                List<Grad> gradovi = response.Content.ReadAsAsync<List<Grad>>().Result;
                gradovi.Insert(0, new Grad("*Odaberite odredište*"));
                cmbOdrediste.DataSource = gradovi;
                cmbOdrediste.ValueMember = "GradID";
                cmbOdrediste.DisplayMember = "Naziv";
                cmbOdrediste.SelectedValue = let.OdredisteID;
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
                cmbPolaziste.DataSource = gradovi;
                cmbPolaziste.ValueMember = "GradID";
                cmbPolaziste.DisplayMember = "Naziv";
                cmbPolaziste.SelectedValue = let.PolazisteID;

            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            BindPolaziste();
            BindOdrediste();
            BindPosada();
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

        private void btnOdabirAviona_Click(object sender, EventArgs e)
        {
            ChoosePlane f = new ChoosePlane();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtNazivA.Text = f.odabraniAvion.Naziv;
                txtOznakaA.Text = f.odabraniAvion.Oznaka;
                txtBrSjedistaA.Text = (f.odabraniAvion.BrojSjedistaBuss + f.odabraniAvion.BrojSjedistaEco).ToString();

                let.AvionID = f.odabraniAvion.AvionID;

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

                HttpResponseMessage responseMessage = posadaServis.GetActionResponse("SearchPosadaLeta",let.LetID.ToString());
                if (responseMessage.IsSuccessStatusCode)
                {
                    List<PosadaLeta> posada = responseMessage.Content.ReadAsAsync<List<PosadaLeta>>().Result;
                    foreach (PosadaLeta pl in posada)
                    {
                        if (pl.ClanPosadeID == f.odabraniZaposlenik.ZaposlenikID)
                            pronadenDuplikat = true;
                    }
                }
                else
                {
                    pronadenDuplikat = false;
                }

                if (pronadenDuplikat == false)
                {
                    PosadaLeta p = new PosadaLeta();
                    p.ClanPosadeID = f.odabraniZaposlenik.ZaposlenikID;
                    p.LetID = let.LetID;

                    HttpResponseMessage response = posadaServis.PostResponse(p);
                    if (response.IsSuccessStatusCode)
                    {
                        BindPosada();
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Odabrani zaposlenik je već dodan", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUkloniClana_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvPosada.SelectedRows[0].Cells[0].Value);

                HttpResponseMessage response = posadaServis.DeleteResponse(id);
                if (response.IsSuccessStatusCode)
                {
                    BindPosada();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                if (let != null)
                {
                    let.PolazisteID = Convert.ToInt32(cmbPolaziste.SelectedValue);
                    let.OdredisteID = Convert.ToInt32(cmbOdrediste.SelectedValue);
                    let.BrojLeta = txtBrojLeta.Text;
                    let.DatumVrijemePolaska = txtDatumPolaska.Value;
                    let.DatumVrijemeDolaska = txtDatumDolaska.Value;
                    let.StatusLeta = cbOtkazi.Checked;//isOtkazan
                    let.isPosebnaPonuda = cbPosPonuda.Checked;
                    if (postojiBussiness)
                    {
                        let.CijenaBussOdrasli = Convert.ToDouble(txtBussOdrasli.Text);
                        let.CijenaBussDjeca = Convert.ToDouble(txtBussDjeca.Text);
                    }
                    else
                    {
                        let.CijenaBussOdrasli = 0;
                        let.CijenaBussDjeca = 0;
                    }
                    let.CijenaEcoDjeca = Convert.ToDouble(txtEkoDjeca.Text);
                    let.CijenaEcoOdrasli = Convert.ToDouble(txtEkoOdrasli.Text);

                    HttpResponseMessage response = letServis.PutResponse(let.LetID, let);
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

        private void cbOtkazi_CheckedChanged(object sender, EventArgs e)
        {

            if (cbOtkazi.Checked == true && tempOtkazan!=true)
            {
               DialogResult dialogResult= MessageBox.Show("Da li ste sigurni da želite otkazati let", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    cbOtkazi.Checked = false;
                }
            }
        }

        private void btnOdabirAviona_Validating(object sender, CancelEventArgs e)
        {
            if (let.AvionID == 0)
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
            if (cmbPolaziste.SelectedIndex == 0)
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

        private void txtBrojLeta_Validating(object sender, CancelEventArgs e)
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

        private void txtDatumPolaska_Validating(object sender, CancelEventArgs e)
        {
            DateTime polazak = txtDatumPolaska.Value;
            DateTime dolazak = txtDatumDolaska.Value;

            if (polazak < DateTime.Now)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumPolaska, "Datum i vrijeme polaska ne smiju biti manji od trenutnog vremena");
            }
            else if (polazak == dolazak)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDatumPolaska, "Termini polaska i dolaska ne smiju biti isti");
            }
            else
            {
                errorProvider.SetError(txtDatumPolaska, null);
            }
        }

        private void txtDatumDolaska_Validating(object sender, CancelEventArgs e)
        {
            DateTime polazak = txtDatumPolaska.Value;
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
            else if (dolazak < polazak)
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
            if (brojClanova==0)
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
