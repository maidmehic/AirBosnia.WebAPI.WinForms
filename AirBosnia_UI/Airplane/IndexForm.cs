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

namespace AirBosnia_UI.Airplane
{
    public partial class IndexForm : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.AvionRoute);

        public IndexForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Avion uspješno spremljen", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindAvioni();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(avioniDgv.SelectedRows[0].Cells[0].Value);
                EditForm f = new EditForm(id);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Avion uspješno izmjenjen", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindAvioni();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Potrebno je odabrati avion", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
    }
}
