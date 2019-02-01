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

namespace AirBosnia_UI.Account
{
    public partial class EditPassword : Form
    {
        private WebApiHelper nalogServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisnickiNalogRoute);

        KorisnickiNalog nalog;
        public EditPassword()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = nalogServis.GetActionResponse("GetNalogByZaposlenikID", Global.logirani.ZaposlenikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                nalog = response.Content.ReadAsAsync<KorisnickiNalog>().Result;
            }
            else
            {
                nalog = null;
                MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (nalog != null)
                {
                    nalog.Lozinka = txtNova.Text;

                    HttpResponseMessage response = nalogServis.PutResponse(nalog.KorisnickiNalogID, nalog);
                    if (response.IsSuccessStatusCode)
                    {
                        Close();
                        MessageBox.Show("Lozinka je uspješno izmjenjena", Poruke.success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase, Poruke.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtStara_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtStara.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStara, "Potrebno je unijeti staru lozinku");
            }else if (txtStara.Text != nalog.Lozinka)
            {
                e.Cancel = true;
                errorProvider.SetError(txtStara, "Unesena lozinka je netačna");
            }
            else
            {
                errorProvider.SetError(txtStara, null);
            }
        }

        private void txtNova_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNova.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNova, "Potrebno je unijeti novu lozinku");
            }
            else if (txtNova.Text.Length <= 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNova, "Lozinka mora sadržavati više od 3 karaktera");
            }
            else if (txtNova.Text.Length > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNova, "Lozinka mora sadržavati manje od 20 karaktera");
            }
            else
            {
                errorProvider.SetError(txtNova, null);
            }
        }

        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPotvrda.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrda, "Potrebno je potvrditi novu lozinku");
            }
            else if (txtNova.Text != txtPotvrda.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrda, "Unesena lozinka je netačna");
            }
            else
            {
                errorProvider.SetError(txtPotvrda, null);
            }
        }
    }
}
