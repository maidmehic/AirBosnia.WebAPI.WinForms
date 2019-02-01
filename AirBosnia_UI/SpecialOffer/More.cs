using AirBosnia_API.Models;
using AirBosnia_API.ViewModels;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI.SpecialOffer
{
    public partial class More : Form
    {

        private WebApiHelper ponudaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PosebnaPonudaRoute);
        private WebApiHelper sjedisteServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.SjedisteRoute);

        PosebnaPonuda ponuda;
        public More(int id)
        {
            InitializeComponent();

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
            txtPolazisteP.Text = ponuda.Let1.Grad1.Naziv + " " + ponuda.Let1.Grad1.Oznaka;
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

            txtTerminPolaska.Text = ponuda.Let1.DatumVrijemePolaska.ToString();
            txtTerminDolaska.Text = ponuda.Let.DatumVrijemePolaska.ToString();
            txtPonuduEvidentirao.Text = ponuda.Zaposlenik.Ime+" "+ponuda.Zaposlenik.Prezime;

            HttpResponseMessage response = sjedisteServis.GetActionResponse("CountSjedista",ponuda.Let1.LetID.ToString());
            if (response.IsSuccessStatusCode)
            {
                CountSjedistaVM podaci = response.Content.ReadAsAsync<CountSjedistaVM>().Result;
                txtSlobodnih.Text = (podaci.brSlBuss + podaci.brSlEco).ToString();
                txtZauzetih.Text = (podaci.brZaBuss + podaci.brZaEco).ToString();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
