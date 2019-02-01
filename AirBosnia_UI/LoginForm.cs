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

namespace AirBosnia_UI
{
    public partial class LoginForm : Form
    {
        private WebApiHelper nalogServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisnickiNalogRoute);


        public LoginForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                HttpResponseMessage response = nalogServis.GetActionResponse("GetNalogUsernamePassword", usernameInput.Text, passwordInput.Text,0.ToString());

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka", Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response.IsSuccessStatusCode)
                {
                    Zaposlenik z = response.Content.ReadAsAsync<Zaposlenik>().Result;
                    DialogResult = DialogResult.OK;
                    Global.logirani = z;
                    Close();
                }
                else
                {
                    MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void usernameInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(usernameInput.Text))
            {
                e.Cancel = true;//otkazi
                errorProvider.SetError(usernameInput, "Molimo unesite korisničko ime");
            }
            else
            {
                errorProvider.SetError(usernameInput, null);
            }
        }

        private void passwordInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(passwordInput.Text))
            {
                e.Cancel = true;//otkazi
                errorProvider.SetError(passwordInput, "Molimo unesite lozinku");
            }
            else
            {
                errorProvider.SetError(passwordInput, null);
            }
        }
    }
}
