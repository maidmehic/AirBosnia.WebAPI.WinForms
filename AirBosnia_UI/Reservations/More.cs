using AirBosnia_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI.Reservations
{
    public partial class More : Form
    {
        public More(Rezervacija rezervacija)
        {
            InitializeComponent();
            BindForm(rezervacija);
        }

        private void BindForm(Rezervacija rezervacija)
        {
            txtImePrezime.Text = rezervacija.ImePutnika + " " + rezervacija.PrezimePutnika;
            txtDatumRodenja.Text = rezervacija.DatumRodjenjaPutnika.ToString("d MMM, yyyy");
            txtSpolTip.Text = rezervacija.Spol + " / " + rezervacija.TipPutnika;
            txtTipDokumenta.Text = rezervacija.TipDokumenta;
            txtBrojDokumenta.Text = rezervacija.BrojDokumenta;
            txtCijena.Text = rezervacija.CijenaKarte.ToString();
            txtDatumRez.Text = rezervacija.DatumRezervacije.ToString("d MMM, yyyy HH:mm");
            txtEvidentirao.Text = rezervacija.Korisnik.Ime + " " + rezervacija.Korisnik.Prezime;
            txtPolaziste.Text = rezervacija.Let.Grad1.Naziv + " (" + rezervacija.Let.Grad1.Oznaka + ")";
            txtOdrediste.Text = rezervacija.Let.Grad.Naziv + " (" + rezervacija.Let.Grad.Oznaka + ")";
            txtBrojLeta.Text = rezervacija.Let.BrojLeta;
            txtDatumPolaska.Text = rezervacija.Let.DatumVrijemePolaska.ToString("d MMM, yyyy HH:mm");
            txtDatumDolaska.Text = rezervacija.Let.DatumVrijemeDolaska.ToString("d MMM, yyyy HH:mm");
            txtSjediste.Text = rezervacija.Sjediste.Oznaka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
