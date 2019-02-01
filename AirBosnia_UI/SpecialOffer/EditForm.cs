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

namespace AirBosnia_UI.SpecialOffer
{
    public partial class EditForm : Form
    {
        private WebApiHelper ponudaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PosebnaPonudaRoute);
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.LetRoute);

        PosebnaPonuda ponuda;

        Let letPolazak = new Let();
        Let letDolazak = new Let();
        public EditForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.UseFading = true;
            toolTip1.UseAnimation = true;
            toolTip1.SetToolTip(txtCijena, "Cijena se odnosi na smještaj bez prevoza");

            HttpResponseMessage response = ponudaServis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                ponuda = response.Content.ReadAsAsync<PosebnaPonuda>().Result;
                FillForm();
            }
            else
            {
                ponuda = null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillForm()
        {
            txtBrLetaP.Text = ponuda.Let1.BrojLeta;
            txtPolazisteP.Text = ponuda.Let1.Grad1.Naziv+" "+ ponuda.Let1.Grad1.Oznaka;
            txtDolazisteP.Text = ponuda.Let1.Grad.Naziv + " " + ponuda.Let1.Grad.Oznaka;
            txtPolazakP.Text = ponuda.Let1.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm");
            txtDolazakP.Text = ponuda.Let1.DatumVrijemeDolaska.ToString("d MMM, yyyy HH:mm");

            txtBrLetaD.Text = ponuda.Let.BrojLeta;
            txtPolazisteD.Text = ponuda.Let.Grad1.Naziv + " " + ponuda.Let.Grad1.Oznaka;
            txtDolazisteD.Text = ponuda.Let.Grad.Naziv + " " + ponuda.Let.Grad.Oznaka;
            txtPolazakD.Text = ponuda.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm");
            txtDolazakD.Text = ponuda.Let.DatumVrijemeDolaska.ToString("d MMM, yyyy HH:mm");

            txtSmjestaj.Text = ponuda.Smjestaj;
            txtNapomena.Text = ponuda.Napomena;
            txtBrDana.Text = ponuda.BrojDana;
            txtCijena.Text = ponuda.CijenaBezKarte.ToString();

            HttpResponseMessage response = letServis.GetResponse(ponuda.Let1.LetID.ToString());
            if (response.IsSuccessStatusCode)
            {
                letPolazak = response.Content.ReadAsAsync<Let>().Result;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HttpResponseMessage response1 = letServis.GetResponse(ponuda.Let.LetID.ToString());
            if (response1.IsSuccessStatusCode)
            {
                letDolazak = response1.Content.ReadAsAsync<Let>().Result;
            }
            else
            {
                MessageBox.Show(response1.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOdaberiPolazak_Click(object sender, EventArgs e)
        {
            ChooseFlight f = new ChooseFlight();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtBrLetaP.Text = f.odabraniLet.BrojLeta;
                txtPolazisteP.Text = f.odabraniLet.Grad1.Naziv + " " + f.odabraniLet.Grad1.Oznaka;
                txtDolazisteP.Text = f.odabraniLet.Grad.Naziv + " " + f.odabraniLet.Grad.Oznaka;
                txtPolazakP.Text = f.odabraniLet.DatumVrijemePolaska.ToString();
                txtDolazakP.Text = f.odabraniLet.DatumVrijemeDolaska.ToString();

                ponuda.LetPolazakID = f.odabraniLet.LetID;
                letPolazak = f.odabraniLet;//potrebno za validaciju
            }
        }

        private void btnOdaberiDolazak_Click(object sender, EventArgs e)
        {
            ChooseFlight f = new ChooseFlight();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtBrLetaD.Text = f.odabraniLet.BrojLeta;
                txtPolazisteD.Text = f.odabraniLet.Grad1.Naziv + " " + f.odabraniLet.Grad1.Oznaka;
                txtDolazisteD.Text = f.odabraniLet.Grad.Naziv + " " + f.odabraniLet.Grad.Oznaka;
                txtPolazakD.Text = f.odabraniLet.DatumVrijemePolaska.ToString();
                txtDolazakD.Text = f.odabraniLet.DatumVrijemeDolaska.ToString();

                ponuda.LetDolazakID = f.odabraniLet.LetID;
                letDolazak = f.odabraniLet;//potrebno za validaciju
            }
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                ponuda.Smjestaj = txtSmjestaj.Text;
                ponuda.CijenaBezKarte = Convert.ToDouble(txtCijena.Text);
                ponuda.BrojDana = txtBrDana.Text;
                ponuda.Napomena = txtNapomena.Text;

                HttpResponseMessage response = ponudaServis.PutResponse(ponuda.PosebnaPonudaID, ponuda);
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

        private void btnOdaberiPolazak_Validating(object sender, CancelEventArgs e)
        {
            if (ponuda.LetPolazakID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiPolazak, "Potrebno je odabrati let za polazak");
            }
            else if (ponuda.LetPolazakID == ponuda.LetDolazakID)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiPolazak, "Letovi za polazak i dolazak ne smiju biti isti");
            }
            else
            {
                errorProvider.SetError(btnOdaberiPolazak, null);
            }
        }

        private void btnOdaberiDolazak_Validating(object sender, CancelEventArgs e)
        {
            if (ponuda.LetDolazakID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiDolazak, "Potrebno je odabrati let za dolazak");
            }
            else if (ponuda.LetPolazakID == ponuda.LetDolazakID)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiDolazak, "Letovi za polazak i dolazak ne smiju biti isti");
            }
            else if (letDolazak.DatumVrijemePolaska <= letPolazak.DatumVrijemePolaska)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiDolazak, "Datum i vrijeme povratka ne odgovaraju datumu polaska");
            }
            else
            {
                errorProvider.SetError(btnOdaberiDolazak, null);
            }
        }

        private void txtSmjestaj_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSmjestaj.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSmjestaj, "Potrebno je unijeti informacije o smještaju");
            }
            else
            {
                errorProvider.SetError(txtSmjestaj, null);
            }
        }

        private void txtBrDana_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            Match match = regex.Match(txtBrDana.Text);

            if (String.IsNullOrEmpty(txtBrDana.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrDana, "Broj dana je obavezno polje");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrDana, "Obavezno koristiti brojeve");
            }
            else if ((letDolazak.DatumVrijemePolaska.Date - letPolazak.DatumVrijemePolaska.Date).Days != Convert.ToInt32(txtBrDana.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrDana, "Broj dana se ne podudara sa odabranim letovima");
            }
            else
            {
                errorProvider.SetError(txtBrDana, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^([0-9]{0,5}((.)[0-9]{0,2}))$");
            Match match = regex.Match(txtCijena.Text);

            if (String.IsNullOrEmpty(txtCijena.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijena, "Cijena je obavezno polje");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijena, "Unesena cijena mora imati format (00000.00)");
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }
    }
}
