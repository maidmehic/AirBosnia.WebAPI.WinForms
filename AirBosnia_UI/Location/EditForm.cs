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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI.Location
{
    public partial class EditForm : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"],Global.GradRoute);

        Grad lokacija;
        public EditForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = servis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                lokacija = response.Content.ReadAsAsync<Grad>().Result;
                FillForm();
            }
            else
            {
                lokacija = null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillForm()
        {
            nazivTxt.Text = lokacija.Naziv;
            oznakaTxt.Text = lokacija.Oznaka;
        }

        private void spremiBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                if (lokacija != null)
                {
                    lokacija.Naziv = nazivTxt.Text;
                    lokacija.Oznaka = oznakaTxt.Text;

                    HttpResponseMessage responseMessage = servis.PutResponse(lokacija.GradID, lokacija);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(responseMessage.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nazivTxt_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage response = servis.GetActionResponse("GetByNazivEdit", nazivTxt.Text,lokacija.GradID.ToString());

            Regex regex = new Regex(@"^[a-žA-ž\s]+$");
            Match match = regex.Match(nazivTxt.Text);

            if (String.IsNullOrEmpty(nazivTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv je obavezan");
            }
            else if (nazivTxt.Text.Length <= 1)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv mora sadržavati više od 1 karaktera");
            }
            else if (nazivTxt.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv mora sadržavati manje od 50 karaktera");
            }
            else if (response.IsSuccessStatusCode)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Postoji lokacija sa unesenim nazivom");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv se mora sastojati od slova");
            }
            else
            {
                errorProvider.SetError(nazivTxt, null);
            }
        }

        private void oznakaTxt_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage response = servis.GetActionResponse("GetByOznakaEdit", oznakaTxt.Text,lokacija.GradID.ToString());
            Regex regex = new Regex(@"^[a-žA-ž]+$");
            Match match = regex.Match(oznakaTxt.Text);

            if (!String.IsNullOrEmpty(oznakaTxt.Text))
            {
                if (response.IsSuccessStatusCode)
                {
                    e.Cancel = true;
                    errorProvider.SetError(oznakaTxt, "Postoji lokacija sa unesenom oznakom");
                }
                else if (!match.Success)
                {
                    e.Cancel = true;
                    errorProvider.SetError(oznakaTxt, "Oznaka se mora sastojati od slova");
                }
                else
                {
                    errorProvider.SetError(oznakaTxt, null);
                }
            }
        }
    }
}
