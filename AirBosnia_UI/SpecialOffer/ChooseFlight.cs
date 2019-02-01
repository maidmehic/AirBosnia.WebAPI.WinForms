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
    public partial class ChooseFlight : Form
    {
        private WebApiHelper letServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.LetRoute);

        public Let odabraniLet { get; set; }

        public ChooseFlight()
        {
            InitializeComponent();
            dgvLetovi.AutoGenerateColumns = false;
        }

        private void ChooseFlight_Load(object sender, EventArgs e)
        {
            BindLetovi();
        }

        private void BindLetovi()
        {
            HttpResponseMessage respones = letServis.GetActionResponse("SearchLetPosPonuda", "");
            if (respones.IsSuccessStatusCode)
            {
                dgvLetovi.DataSource = respones.Content.ReadAsAsync<Letovi_IndexVM>().Result.podaci;
                dgvLetovi.ClearSelection();
            }
            else
            {
                MessageBox.Show(respones.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage respones = letServis.GetActionResponse("SearchLetPosPonuda",txtPretraga.Text);
            if (respones.IsSuccessStatusCode)
            {
                dgvLetovi.DataSource = respones.Content.ReadAsAsync<Letovi_IndexVM>().Result.podaci;
                dgvLetovi.ClearSelection();
            }
            else
            {
                MessageBox.Show(respones.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLetovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvLetovi.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = letServis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                odabraniLet = response.Content.ReadAsAsync<Let>().Result;
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
