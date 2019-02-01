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
    public partial class AddCrewMember : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.ZaposlenikRoute);

        public AddCrewMember()
        {
            InitializeComponent();
            dgvZaposlenici.AutoGenerateColumns = false;
            BindZaposlenici();
        }

         public Zaposlenici_IndexVM.Rows odabraniZaposlenik = new Zaposlenici_IndexVM.Rows();

        private void BindZaposlenici()
        {
            HttpResponseMessage response = servis.GetActionResponse("SearchAllPosada", "p");
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
            HttpResponseMessage response = servis.GetActionResponse("SearchByImePrezimePosada", pretragaTxt.Text);

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

        private void dgvZaposlenici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvZaposlenici.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = servis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                odabraniZaposlenik = response.Content.ReadAsAsync<Zaposlenici_IndexVM.Rows>().Result;
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
