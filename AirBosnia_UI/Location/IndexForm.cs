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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI.Location
{
    public partial class IndexForm : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.GradRoute);

        public IndexForm()
        {
            InitializeComponent();
            dgvLokacije.AutoGenerateColumns = false;
            BindLokacije();
        }

        private void BindLokacije()
        {
            HttpResponseMessage response = servis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvLokacije.DataSource = response.Content.ReadAsAsync<List<Grad>>().Result;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = servis.GetActionResponse("SearchByNaziv", txtPretraga.Text);
            if (response.IsSuccessStatusCode)
            {
                dgvLokacije.DataSource = response.Content.ReadAsAsync<List<Grad>>().Result;
            }
            else
            {
                MessageBox.Show("Lokacija nije pronađena", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Lokacija uspješno spremljena", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindLokacije();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvLokacije.SelectedRows[0].Cells[0].Value);
                EditForm f = new EditForm(id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Lokacija uspješno izmjenjena", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindLokacije();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati lokaciju", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
