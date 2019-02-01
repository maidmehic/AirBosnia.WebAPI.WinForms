using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBosnia_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            zaposlenikToolStripMenuItem.Text = Global.logirani.Ime + " " + Global.logirani.Prezime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airplane.IndexForm f = new Airplane.IndexForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Location.IndexForm f = new Location.IndexForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee.IndexForm f = new Employee.IndexForm();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Flight.IndexForm f = new Flight.IndexForm();
            f.Show();
        }

        private void btnPonude_Click(object sender, EventArgs e)
        {
            SpecialOffer.IndexForm f = new SpecialOffer.IndexForm();
            f.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.logirani = null;
            Application.Restart();
        }

        private void računToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account.EditPassword f = new Account.EditPassword();
            f.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            Reservations.IndexForm f = new Reservations.IndexForm();
            f.Show();
        }
    }
}
