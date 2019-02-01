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

namespace AirBosnia_UI.Reservations
{
    public partial class IndexForm : Form
    {
        private WebApiHelper rezervacijeServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RezervacijaRoute);

        public IndexForm()
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;

            BindRezervacije();
        }

        private void BindRezervacije()
        {
            HttpResponseMessage response = rezervacijeServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvRezervacije.DataSource = response.Content.ReadAsAsync<Rezervacije_IndexVM>().Result.podaci;
                dgvRezervacije.ClearSelection();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = rezervacijeServis.GetActionResponse("SearchRezervacijeByPutnik",txtImePrezime.Text);
            if (response.IsSuccessStatusCode)
            {
                dgvRezervacije.DataSource = response.Content.ReadAsAsync<Rezervacije_IndexVM>().Result.podaci;
                dgvRezervacije.ClearSelection();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = rezervacijeServis.GetActionResponse("SearchRezervacijeDanasnjiDan", txtImePrezime.Text);
            if (response.IsSuccessStatusCode)
            {
                dgvRezervacije.DataSource = response.Content.ReadAsAsync<Rezervacije_IndexVM>().Result.podaci;
                dgvRezervacije.ClearSelection();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvRezervacije.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = rezervacijeServis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                Rezervacija rezervacija = response.Content.ReadAsAsync<Rezervacija>().Result;
                More frm = new More(rezervacija);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
