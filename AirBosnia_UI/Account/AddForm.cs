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

namespace AirBosnia_UI.Account
{
    public partial class AddForm : Form
    {

        private WebApiHelper nalogServis = new WebApiHelper(ConfigurationManager.AppSettings["APIAddress"], Global.KorisnickiNalogRoute);
       public  KorisnickiNalog k = new KorisnickiNalog();
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                k.KorisnickoIme = txtusr.Text;
                k.Lozinka = txtpass.Text;
                k.Status = true;

                DialogResult = DialogResult.OK;
                Close();
            }
           
        }

        private void txtusr_Validating(object sender, CancelEventArgs e)
        {
            HttpResponseMessage response = nalogServis.GetActionResponse("GetNalogByUsername", txtusr.Text, 0.ToString());
            Regex regex = new Regex(@"^[a-z]+[_\.]?[a-z]+$");
            Match match = regex.Match(txtusr.Text);

            if (String.IsNullOrEmpty(txtusr.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtusr, "Korisničko ime je obavezno polje");
            }else if (response.IsSuccessStatusCode)
            {
                e.Cancel = true;
                errorProvider.SetError(txtusr, "Korisničko ime je zauzeto");
            }else if (txtusr.Text.Length > 20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtusr, "Korisničko ime mora sadržavati manje od 20 karaktera");
            }
            else if (txtusr.Text.Length <= 2)
            {
                e.Cancel = true;
                errorProvider.SetError(txtusr, "Korisničko ime mora sadržavati više od 2 karaktera");
            }
            else if (!match.Success)
            {
                e.Cancel = true;
                errorProvider.SetError(txtusr, "Potrebno je koristiti mala slova, '.' i '_'");
            }
            else
            {
                errorProvider.SetError(txtusr, null);
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtpass.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtpass, "Lozinka je obavezno polje");
            }else if(txtpass.Text.Length <= 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtpass, "Lozinka mora sadržavati više od 3 karaktera");
            }else if (txtpass.Text.Length >20)
            {
                e.Cancel = true;
                errorProvider.SetError(txtpass, "Lozinka mora sadržavati manje od 20 karaktera");
            }
            else
            {
                errorProvider.SetError(txtpass, null);
            }
        }
    }
}
