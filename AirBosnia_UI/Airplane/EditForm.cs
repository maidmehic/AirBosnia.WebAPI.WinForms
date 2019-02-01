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
    public partial class EditForm : Form
    {
        private WebApiHelper servis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.AvionRoute);

        private Avion avion;

        public EditForm(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = servis.GetResponse(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                avion = response.Content.ReadAsAsync<Avion>().Result;
                FillForm();
            }
            else
            {
                avion = null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillForm()
        {
            nazivTxt.Text = avion.Naziv;
            oznakaTxt.Text = avion.Oznaka;
            brSjedistaB.Text = avion.BrojSjedistaBuss.ToString();
            brSjedistaE.Text = avion.BrojSjedistaEco.ToString();
        }


        private void spremiBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (avion != null)
                {
                    avion.Naziv = nazivTxt.Text;
                    avion.Oznaka = oznakaTxt.Text;
                    avion.BrojSjedistaBuss = Convert.ToInt32(brSjedistaB.Text);
                    avion.BrojSjedistaEco = Convert.ToInt32(brSjedistaE.Text);

                    HttpResponseMessage response = servis.PutResponse(avion.AvionID, avion);
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
        }

        private void nazivTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv je obavezno polje");
            }
            else if (nazivTxt.Text.Length <= 1)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv aviona mora sadržavati više od 1 karaktera");
            }
            else if (nazivTxt.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivTxt, "Naziv aviona mora sadržavati manje od 50 karaktera");
            }
            else
            {
                errorProvider.SetError(nazivTxt, null);
            }
        }
        

        private void oznakaTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(oznakaTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(oznakaTxt, "Oznaka je obavezno polje");
            }
            else if (oznakaTxt.Text.Length <= 1)
            {
                e.Cancel = true;
                errorProvider.SetError(oznakaTxt, "Oznaka aviona mora sadržavati više od 1 karaktera");
            }
            else if (oznakaTxt.Text.Length > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(oznakaTxt, "Oznaka aviona mora sadržavati manje od 20 karaktera");
            }
            else
            {
                errorProvider.SetError(oznakaTxt, null);
            }
        }
    }
}
