using AgencijaZaNekretnine.Data.Controller;
using AgencijaZaNekretnine.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaNekretnine.Forms
{
    public partial class OAgencijiForm : Form
    {
        public OAgencijiForm()
        {
            InitializeComponent();
        }

        private void OAgencijiForm_Load(object sender, EventArgs e)
        {
            Agencija a = AgencijaController.Read(1);
            NazivAgencijeTextBox.Text = a.naziv;
            BrTelefonaTextBox.Text = a.brTelefona;
            AdresaTextBox.Text = a.adresa;
        }
    }
}
