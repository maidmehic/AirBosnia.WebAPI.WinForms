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
    public partial class AddForm : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.GradRoute);


        Grad g = new Grad();
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void spremiBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                g.Naziv = nazivTxt.Text;
                g.Oznaka = oznakaTxt.Text;

                HttpResponseMessage response = servis.PostResponse(g);
                if (response.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nazivTxt_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage response = servis.GetActionResponse("GetByNaziv", nazivTxt.Text);

            Regex regex = new Regex(@"^[a-žA-ž\s]+$");
            Match match = regex.Match(nazivTxt.Text);

            if (String.IsNullOrEmpty(nazivTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv je obavezan");
            }
            else if (nazivTxt.Text.Length<=1)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv mora sadržavati više od 1 karaktera");
            }
            else if (nazivTxt.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv mora sadržavati manje od 50 karaktera");
            }
            else if(response.IsSuccessStatusCode)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Postoji lokacija sa unesenim nazivom");
            }else if (!match.Success)
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
            HttpResponseMessage response = servis.GetActionResponse("GetByOznaka", oznakaTxt.Text);

            Regex regex = new Regex(@"^[a-žA-ž]+$");
            Match match = regex.Match(oznakaTxt.Text);
            if (!String.IsNullOrEmpty(oznakaTxt.Text))
            {
                if (response.IsSuccessStatusCode)
                {
                    e.Cancel = true;
                    errorProvider.SetError(oznakaTxt, "Postoji lokacija sa unesenom oznakom");
                }else if (!match.Success)
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
