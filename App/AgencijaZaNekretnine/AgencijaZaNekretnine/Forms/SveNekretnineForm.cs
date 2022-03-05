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
    public partial class SveNekretnineForm : Form
    {
        public SveNekretnineForm()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            List<NekretninaIznajmljivanje> list = NekretninaIznajmljivanjeController.ReadAll();

            foreach(var obj in list)
            {
                DataGridViewRow dgvr = (DataGridViewRow)NekretnineDataGridView.Rows[0].Clone();
                dgvr.Cells[0].Value = obj.idNekretnina.ToString();
                dgvr.Cells[1].Value = obj.brPoste;
                dgvr.Cells[2].Value = obj.adresa;
                dgvr.Cells[3].Value = obj.vlasnikJMB;
                dgvr.Cells[4].Value = obj.predlozenaKirija.ToString();
                dgvr.Cells[5].Value = obj.slobodnoOd.ToString();
                dgvr.Cells[6].Value = obj.slobodnoDo.ToString();
                dgvr.Cells[7].Value = obj.jeIznajmljena.ToString();
                NekretnineDataGridView.Rows.Add(dgvr);
            }
        }

        private void SveNekretnineForm_Load(object sender, EventArgs e)
        {

        }
    }
}
