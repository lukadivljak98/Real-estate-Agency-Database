
namespace AgencijaZaNekretnine.Forms
{
    partial class SveNekretnineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaNekretninaLbl = new System.Windows.Forms.Label();
            this.NekretnineDataGridView = new System.Windows.Forms.DataGridView();
            this.IdNekretnineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrPosteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlasnikJmbColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredlozenaKirijaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlobodnoOdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlobodnoDoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JeIznajmljenaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NekretnineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaNekretninaLbl
            // 
            this.ListaNekretninaLbl.AutoSize = true;
            this.ListaNekretninaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaNekretninaLbl.Location = new System.Drawing.Point(216, 9);
            this.ListaNekretninaLbl.Name = "ListaNekretninaLbl";
            this.ListaNekretninaLbl.Size = new System.Drawing.Size(624, 44);
            this.ListaNekretninaLbl.TabIndex = 0;
            this.ListaNekretninaLbl.Text = "Lista Nekretnina Za Iznajmljivanje";
            // 
            // NekretnineDataGridView
            // 
            this.NekretnineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NekretnineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNekretnineColumn,
            this.BrPosteColumn,
            this.AdresaColumn,
            this.VlasnikJmbColumn,
            this.PredlozenaKirijaColumn,
            this.SlobodnoOdColumn,
            this.SlobodnoDoColumn,
            this.JeIznajmljenaColumn});
            this.NekretnineDataGridView.Location = new System.Drawing.Point(12, 85);
            this.NekretnineDataGridView.Name = "NekretnineDataGridView";
            this.NekretnineDataGridView.RowHeadersWidth = 51;
            this.NekretnineDataGridView.RowTemplate.Height = 24;
            this.NekretnineDataGridView.Size = new System.Drawing.Size(1056, 509);
            this.NekretnineDataGridView.TabIndex = 1;
            // 
            // IdNekretnineColumn
            // 
            this.IdNekretnineColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdNekretnineColumn.HeaderText = "Sifra Nekretnine";
            this.IdNekretnineColumn.MinimumWidth = 6;
            this.IdNekretnineColumn.Name = "IdNekretnineColumn";
            this.IdNekretnineColumn.ReadOnly = true;
            // 
            // BrPosteColumn
            // 
            this.BrPosteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrPosteColumn.HeaderText = "Broj Poste";
            this.BrPosteColumn.MinimumWidth = 6;
            this.BrPosteColumn.Name = "BrPosteColumn";
            this.BrPosteColumn.ReadOnly = true;
            // 
            // AdresaColumn
            // 
            this.AdresaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdresaColumn.HeaderText = "Adresa";
            this.AdresaColumn.MinimumWidth = 6;
            this.AdresaColumn.Name = "AdresaColumn";
            this.AdresaColumn.ReadOnly = true;
            // 
            // VlasnikJmbColumn
            // 
            this.VlasnikJmbColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VlasnikJmbColumn.HeaderText = "JMB Vlasnika";
            this.VlasnikJmbColumn.MinimumWidth = 6;
            this.VlasnikJmbColumn.Name = "VlasnikJmbColumn";
            this.VlasnikJmbColumn.ReadOnly = true;
            // 
            // PredlozenaKirijaColumn
            // 
            this.PredlozenaKirijaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PredlozenaKirijaColumn.HeaderText = "Predlozena Kirija";
            this.PredlozenaKirijaColumn.MinimumWidth = 6;
            this.PredlozenaKirijaColumn.Name = "PredlozenaKirijaColumn";
            this.PredlozenaKirijaColumn.ReadOnly = true;
            // 
            // SlobodnoOdColumn
            // 
            this.SlobodnoOdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SlobodnoOdColumn.HeaderText = "Slobodno Od";
            this.SlobodnoOdColumn.MinimumWidth = 6;
            this.SlobodnoOdColumn.Name = "SlobodnoOdColumn";
            this.SlobodnoOdColumn.ReadOnly = true;
            // 
            // SlobodnoDoColumn
            // 
            this.SlobodnoDoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SlobodnoDoColumn.HeaderText = "Slobodno Do";
            this.SlobodnoDoColumn.MinimumWidth = 6;
            this.SlobodnoDoColumn.Name = "SlobodnoDoColumn";
            this.SlobodnoDoColumn.ReadOnly = true;
            // 
            // JeIznajmljenaColumn
            // 
            this.JeIznajmljenaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JeIznajmljenaColumn.HeaderText = "Status";
            this.JeIznajmljenaColumn.MinimumWidth = 6;
            this.JeIznajmljenaColumn.Name = "JeIznajmljenaColumn";
            this.JeIznajmljenaColumn.ReadOnly = true;
            // 
            // SveNekretnineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 606);
            this.Controls.Add(this.NekretnineDataGridView);
            this.Controls.Add(this.ListaNekretninaLbl);
            this.Name = "SveNekretnineForm";
            this.Text = "SveNekretnineForm";
            this.Load += new System.EventHandler(this.SveNekretnineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NekretnineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListaNekretninaLbl;
        private System.Windows.Forms.DataGridView NekretnineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNekretnineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrPosteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlasnikJmbColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredlozenaKirijaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlobodnoOdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlobodnoDoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JeIznajmljenaColumn;
    }
}