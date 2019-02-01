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

namespace AirBosnia_UI.Flight
{
    public partial class ChoosePlane : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.AvionRoute);
        public Avion odabraniAvion= new Avion();

        public ChoosePlane()
        {
            InitializeComponent();
            avioniDgv.AutoGenerateColumns = false;
            BindAvioni();
        }

        private void BindAvioni()
        {
            HttpResponseMessage response = servis.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                avioniDgv.DataSource = response.Content.ReadAsAsync<List<Avion>>().Result;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = servis.GetActionResponse("SearchByOznaka", txtOznaka.Text);
            if (response.IsSuccessStatusCode)
            {
                avioniDgv.DataSource = response.Content.ReadAsAsync<List<Avion>>().Result;
            }
            else
            {
                MessageBox.Show("Avion nije pronađen", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void avioniDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32(avioniDgv.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = servis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                odabraniAvion = response.Content.ReadAsAsync<Avion>().Result;
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
