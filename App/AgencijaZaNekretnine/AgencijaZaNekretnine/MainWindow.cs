using AgencijaZaNekretnine.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaNekretnine
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NovaNekretnineButton_Click(object sender, EventArgs e)
        {
            NovaNekretninaForm window = new NovaNekretninaForm();
            window.ShowDialog();
        }

        private void OAgencijiButton_Click(object sender, EventArgs e)
        {
            OAgencijiForm window = new OAgencijiForm();
            window.ShowDialog();
        }

        private void SveNekretnineButton_Click(object sender, EventArgs e)
        {
            SveNekretnineForm window = new SveNekretnineForm();
            window.ShowDialog();
        }

        private void NoviUgovorButton_Click(object sender, EventArgs e)
        {
            NoviUgovorForm window = new NoviUgovorForm();
            window.ShowDialog();
        }
    }
}
