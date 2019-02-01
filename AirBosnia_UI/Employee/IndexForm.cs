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

namespace AirBosnia_UI.Employee
{
    public partial class IndexForm : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.ZaposlenikRoute);
        private WebApiHelper tipZaposlenjaServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.TipZaposlenjaRoute);


        public IndexForm()
        {
            InitializeComponent();
            dgvZaposlenici.AutoGenerateColumns = false;

        }

        private void BindZaposlenici()
        {
            HttpResponseMessage response = servis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                Zaposlenici_IndexVM Model = response.Content.ReadAsAsync<Zaposlenici_IndexVM>().Result;
                dgvZaposlenici.DataSource = Model.podaci;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = servis.GetActionResponse("SearchByImePrezime", Convert.ToInt32(cmbTip.SelectedIndex).ToString(), pretragaTxt.Text);

            if (response.IsSuccessStatusCode)
            {
                Zaposlenici_IndexVM Model = response.Content.ReadAsAsync<Zaposlenici_IndexVM>().Result;
                dgvZaposlenici.DataSource = Model.podaci;
            }
            else
            {
                MessageBox.Show("Zaposlenik nije pronađen", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Zaposlenik uspješno dodan", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindZaposlenici();
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvZaposlenici.SelectedRows[0].Cells[0].Value);
                EditForm f = new EditForm(id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Zaposlenik uspješno izmjenjen", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindZaposlenici();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati zaposlenika", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindTip();
            BindZaposlenici();

        }

        private void BindTip()
        {
            HttpResponseMessage response = tipZaposlenjaServis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<TipZaposlenja> tipovi = response.Content.ReadAsAsync<List<TipZaposlenja>>().Result;
                tipovi.Insert(0, new TipZaposlenja("Svi"));
                cmbTip.DataSource = tipovi;
                cmbTip.ValueMember = "TipZaposlenjaID";
                cmbTip.DisplayMember = "Naziv";
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
