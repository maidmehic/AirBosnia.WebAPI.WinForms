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

    public partial class IndexForm : Form
    {
        private WebApiHelper ponudaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.PosebnaPonudaRoute);

        public IndexForm()
        {
            InitializeComponent();
            dgvPonude.AutoGenerateColumns = false;
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Ponuda uspješno dodana", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindPonude();
            }
        }

        private void BindPonude()
        {
            HttpResponseMessage response = ponudaServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                dgvPonude.DataSource = response.Content.ReadAsAsync<PosebnPonuda_IndexVM>().Result.ponude;
                dgvPonude.ClearSelection();
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindStatus();
            BindPonude();
        }

        private void BindStatus()
        {
            List<string> statusi = new List<string>();
            statusi.Add("Aktivne");
            statusi.Add("Završene");
            statusi.Add("Sve");
            cmbStatus.DataSource = statusi;
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = ponudaServis.GetActionResponse("SearchPonude", (Convert.ToInt32(cmbStatus.SelectedIndex)).ToString());
            if (response.IsSuccessStatusCode)
            {
                dgvPonude.DataSource = response.Content.ReadAsAsync<PosebnPonuda_IndexVM>().Result.ponude;
                dgvPonude.ClearSelection();
                if (dgvPonude.Rows.Count == 0)
                {
                    MessageBox.Show("Ponude nisu pronađene", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                int id = Convert.ToInt32(dgvPonude.SelectedRows[0].Cells[0].Value);
                EditForm f = new EditForm(id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Ponuda uspješno izmjenjena", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindPonude();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati ponudu", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvPonude.SelectedRows[0].Cells[0].Value);
                More f = new More(id);
                f.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati ponudu", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
