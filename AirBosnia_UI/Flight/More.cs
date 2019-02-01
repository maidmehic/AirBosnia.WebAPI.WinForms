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

namespace AirBosnia_UI.Flight
{
    public partial class More : Form
    {
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.LetRoute);
        private WebApiHelper posadaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PosadaLetaRoute);
        private WebApiHelper sjedisteServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.SjedisteRoute);

        Let let;
        public More(int id)
        {
            InitializeComponent();

            dgvPosada.AutoGenerateColumns = false;

            HttpResponseMessage response = letServis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                let = response.Content.ReadAsAsync<Let>().Result;
                FillForm();
            }
            else
            {
                let = null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillForm()
        {
            txtBroj.Text = let.BrojLeta;
            txtPolaziste.Text = let.Grad1.Naziv + " " + let.Grad1.Oznaka;
            txtOdrediste.Text = let.Grad.Naziv + " " + let.Grad.Oznaka;
            txtAvion.Text = let.Avion.Naziv + " " + let.Avion.Oznaka;
            if (let.isPosebnaPonuda ?? false)
                labelPosPunuda.Text = "DA";
             
            else
                labelPosPunuda.Text = "NE";


            if (let.StatusLeta == true)
                txtOtkazan.Text = "DA";
            else
                txtOtkazan.Text = "NE";
            txtEvidentirao.Text = let.Zaposlenik.Ime + " " + let.Zaposlenik.Prezime;

            txtDatumPolaska.Text = let.DatumVrijemePolaska.ToString();
            txtDatumDolaska.Text = let.DatumVrijemeDolaska.ToString();
            txtCijenaOdrBuss.Text = let.CijenaBussOdrasli.ToString();
            txtCijenaDjeBuss.Text = let.CijenaBussDjeca.ToString();
            txtCijenaOdrEco.Text = let.CijenaEcoOdrasli.ToString();
            txtCijenaDjeEco.Text = let.CijenaEcoDjeca.ToString();

            BindPosada();
            BindSjedista();
        }

        private void BindSjedista()
        {
            HttpResponseMessage response = sjedisteServis.GetActionResponse("CountSjedista", let.LetID.ToString());
            if (response.IsSuccessStatusCode)
            {
                CountSjedistaVM podaci = response.Content.ReadAsAsync<CountSjedistaVM>().Result;
                txtSlobodnaEco.Text = podaci.brSlEco.ToString();
                txtZauzetaEco.Text = podaci.brZaEco.ToString();
                txtSlobodnaBuss.Text = podaci.brSlBuss.ToString();
                txtZauzetaBuss.Text = podaci.brZaBuss.ToString();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindPosada()
        {
            HttpResponseMessage response = posadaServis.GetActionResponse("SearchPosadaLeta", let.LetID.ToString());
            if (response.IsSuccessStatusCode)
            {
                dgvPosada.DataSource = response.Content.ReadAsAsync<List<PosadaLeta>>().Result;
                dgvPosada.ClearSelection();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
