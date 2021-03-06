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
    public partial class NovaNekretninaForm : Form
    {
        public NovaNekretninaForm()
        {
            InitializeComponent();
            ucitajBrPoste();
        }

        private void OtkaziButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SacuvajButton_Click(object sender, EventArgs e)
        {
            Nekretnina n = new Nekretnina();
            //n.idNekretnina = 1;
            n.brPoste = BrPosteComboBox.SelectedItem.ToString();
            n.adresa = AdresaTextBox.Text;
            n.vlasnikJMB = VlasnikJmbTextBox.Text;
            long id = NekretninaController.Insert(n);
            NekretninaIznajmljivanje ni = new NekretninaIznajmljivanje();
            ni.idNekretnina = (int)id;
            ni.predlozenaKirija =  Double.Parse(PredlozenaKirijaTextBox.Text);
            ni.slobodnoOd = SlobodnoOdPicker.Value;
            ni.slobodnoDo = SlobodnoDoPicker.Value;
            ni.jeIznajmljena = false;
            NekretninaIznajmljivanjeController.Insert(ni);
            this.Close();
        }

        private void ucitajBrPoste()
        {
            var lista = MjestoController.ReadAll();
            foreach(var item in lista)
                 BrPosteComboBox.Items.Add(item.brPoste.ToString());
        }
    }
}
