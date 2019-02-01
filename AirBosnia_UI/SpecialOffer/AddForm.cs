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
    public partial class AddForm : Form
    {
        private WebApiHelper ponudaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.PosebnaPonudaRoute);
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.LetRoute);

        PosebnaPonuda novaPonuda = new PosebnaPonuda();
        Let letPolazak = new Let();
        Let letDolazak = new Let();
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            

            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;
            toolTip1.UseFading = true;
            toolTip1.UseAnimation = true;
            toolTip1.SetToolTip(txtCijena, "Cijena se odnosi na smještaj bez prevoza");

        }

        private void btnOdaberiPolazak_Click(object sender, EventArgs e)
        {
            ChooseFlight f = new ChooseFlight();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtBrLetaP.Text = f.odabraniLet.BrojLeta;
                txtPolazisteP.Text = f.odabraniLet.Grad1.Naziv+" "+ f.odabraniLet.Grad1.Oznaka;
                txtDolazisteP.Text = f.odabraniLet.Grad.Naziv + " " + f.odabraniLet.Grad.Oznaka;
                txtPolazakP.Text = f.odabraniLet.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm");
                txtDolazakP.Text = f.odabraniLet.DatumVrijemeDolaska.ToString("d MMM, yyyy HH:mm");

                novaPonuda.LetPolazakID = f.odabraniLet.LetID;

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
                txtPolazakD.Text = f.odabraniLet.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm");
                txtDolazakD.Text = f.odabraniLet.DatumVrijemeDolaska.ToString("d MMM, yyyy HH:mm");
                novaPonuda.LetDolazakID = f.odabraniLet.LetID;

                letDolazak = f.odabraniLet;//potrebno za validaciju

            }
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                novaPonuda.Smjestaj = txtSmjestaj.Text;
                novaPonuda.CijenaBezKarte = Convert.ToDouble(txtCijena.Text);
                novaPonuda.BrojDana = txtBrDana.Text;
                novaPonuda.Napomena = txtNapomena.Text;
                novaPonuda.ZaposlenikID = Global.logirani.ZaposlenikID;

                HttpResponseMessage response = ponudaServis.PostResponse(novaPonuda);
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
            if (novaPonuda.LetPolazakID==0)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiPolazak, "Potrebno je odabrati let za polazak");
            }
            else if (novaPonuda.LetPolazakID == novaPonuda.LetDolazakID)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiPolazak, "Letovi za polazak i dolazak ne smiju biti isti");
            }
            else
            {
                errorProvider.SetError(btnOdaberiPolazak,null);
            }
        }

        private void btnOdaberiDolazak_Validating(object sender, CancelEventArgs e)
        {
            if (novaPonuda.LetDolazakID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(btnOdaberiDolazak, "Potrebno je odabrati let za dolazak");
            }
            else if (novaPonuda.LetPolazakID == novaPonuda.LetDolazakID)
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
            }else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrDana, "Obavezno koristiti brojeve");
            }
            else if ((letDolazak.DatumVrijemePolaska.Date- letPolazak.DatumVrijemePolaska.Date).Days!=Convert.ToInt32(txtBrDana.Text))
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
