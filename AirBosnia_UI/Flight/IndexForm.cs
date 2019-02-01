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
    public partial class IndexForm : Form
    {
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.LetRoute);
        private WebApiHelper rezervacijaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.RezervacijaRoute);

        public IndexForm()
        {
            InitializeComponent();
            dgvLetovi.AutoGenerateColumns = false;
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Let uspješno dodan", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindLetovi();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = letServis.GetActionResponse("SearchLetovi", (Convert.ToInt32(cmbStatus.SelectedIndex)).ToString(), txtPretraga.Text);
            if (response.IsSuccessStatusCode)
            {
                dgvLetovi.DataSource = response.Content.ReadAsAsync<Letovi_IndexVM>().Result.podaci;
                dgvLetovi.ClearSelection();
                if (dgvLetovi.Rows.Count == 0)
                {
                    MessageBox.Show("Letovi nisu pronađeni", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Letovi nisu pronađeni", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindLetovi();
            BindStatus();
        }

        private void BindStatus()
        {
            List<string> statusi = new List<string>();
            statusi.Add("Aktivni");
            statusi.Add("Završeni");
            statusi.Add("Svi");
            statusi.Add("Otkazani");
            cmbStatus.DataSource = statusi;
        }

        private void BindLetovi()
        {
            HttpResponseMessage response = letServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvLetovi.DataSource = response.Content.ReadAsAsync<Letovi_IndexVM>().Result.podaci.OrderBy(x=>x.DatumVrijemePolaska).ToList();
                dgvLetovi.ClearSelection();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvLetovi.SelectedRows[0].Cells[0].Value);
                EditForm f = new EditForm(id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Let uspješno izmjenjen", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindLetovi();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati let", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvLetovi.SelectedRows[0].Cells[0].Value);
                More f = new More(id);
                f.ShowDialog();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati let", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLetovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvLetovi.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = rezervacijaServis.GetActionResponse("SearchRezervacijeByLetID", id.ToString());
            if (response.IsSuccessStatusCode)
            {
                Rezervacija_ReportVM rezervacije = response.Content.ReadAsAsync<Rezervacija_ReportVM>().Result;
                Reports.reportForm frm = new Reports.reportForm(rezervacije);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ne postoje rezervacije za odabrani let", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
