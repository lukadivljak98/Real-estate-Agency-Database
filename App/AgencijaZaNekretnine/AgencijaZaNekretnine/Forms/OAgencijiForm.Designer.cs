
namespace AgencijaZaNekretnine.Forms
{
    partial class OAgencijiForm
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
            this.NazivAgencijeLbl = new System.Windows.Forms.Label();
            this.OAgencijiLbl = new System.Windows.Forms.Label();
            this.NazivAgencijeTextBox = new System.Windows.Forms.TextBox();
            this.BrTelefonaLbl = new System.Windows.Forms.Label();
            this.BrTelefonaTextBox = new System.Windows.Forms.TextBox();
            this.AdresaLbl = new System.Windows.Forms.Label();
            this.AdresaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NazivAgencijeLbl
            // 
            this.NazivAgencijeLbl.AutoSize = true;
            this.NazivAgencijeLbl.Location = new System.Drawing.Point(12, 133);
            this.NazivAgencijeLbl.Name = "NazivAgencijeLbl";
            this.NazivAgencijeLbl.Size = new System.Drawing.Size(101, 17);
            this.NazivAgencijeLbl.TabIndex = 0;
            this.NazivAgencijeLbl.Text = "Naziv Agencije";
            // 
            // OAgencijiLbl
            // 
            this.OAgencijiLbl.AutoSize = true;
            this.OAgencijiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OAgencijiLbl.Location = new System.Drawing.Point(111, 28);
            this.OAgencijiLbl.Name = "OAgencijiLbl";
            this.OAgencijiLbl.Size = new System.Drawing.Size(204, 44);
            this.OAgencijiLbl.TabIndex = 1;
            this.OAgencijiLbl.Text = "O Agenciji";
            // 
            // NazivAgencijeTextBox
            // 
            this.NazivAgencijeTextBox.Location = new System.Drawing.Point(156, 130);
            this.NazivAgencijeTextBox.Name = "NazivAgencijeTextBox";
            this.NazivAgencijeTextBox.ReadOnly = true;
            this.NazivAgencijeTextBox.Size = new System.Drawing.Size(264, 22);
            this.NazivAgencijeTextBox.TabIndex = 2;
            // 
            // BrTelefonaLbl
            // 
            this.BrTelefonaLbl.AutoSize = true;
            this.BrTelefonaLbl.Location = new System.Drawing.Point(12, 197);
            this.BrTelefonaLbl.Name = "BrTelefonaLbl";
            this.BrTelefonaLbl.Size = new System.Drawing.Size(85, 17);
            this.BrTelefonaLbl.TabIndex = 3;
            this.BrTelefonaLbl.Text = "Broj Telefon";
            // 
            // BrTelefonaTextBox
            // 
            this.BrTelefonaTextBox.Location = new System.Drawing.Point(156, 194);
            this.BrTelefonaTextBox.Name = "BrTelefonaTextBox";
            this.BrTelefonaTextBox.ReadOnly = true;
            this.BrTelefonaTextBox.Size = new System.Drawing.Size(264, 22);
            this.BrTelefonaTextBox.TabIndex = 4;
            // 
            // AdresaLbl
            // 
            this.AdresaLbl.AutoSize = true;
            this.AdresaLbl.Location = new System.Drawing.Point(12, 267);
            this.AdresaLbl.Name = "AdresaLbl";
            this.AdresaLbl.Size = new System.Drawing.Size(53, 17);
            this.AdresaLbl.TabIndex = 5;
            this.AdresaLbl.Text = "Adresa";
            // 
            // AdresaTextBox
            // 
            this.AdresaTextBox.Location = new System.Drawing.Point(156, 264);
            this.AdresaTextBox.Name = "AdresaTextBox";
            this.AdresaTextBox.ReadOnly = true;
            this.AdresaTextBox.Size = new System.Drawing.Size(264, 22);
            this.AdresaTextBox.TabIndex = 6;
            // 
            // OAgencijiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 352);
            this.Controls.Add(this.AdresaTextBox);
            this.Controls.Add(this.AdresaLbl);
            this.Controls.Add(this.BrTelefonaTextBox);
            this.Controls.Add(this.BrTelefonaLbl);
            this.Controls.Add(this.NazivAgencijeTextBox);
            this.Controls.Add(this.OAgencijiLbl);
            this.Controls.Add(this.NazivAgencijeLbl);
            this.Name = "OAgencijiForm";
            this.Text = "OAgencijiForm";
            this.Load += new System.EventHandler(this.OAgencijiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazivAgencijeLbl;
        private System.Windows.Forms.Label OAgencijiLbl;
        private System.Windows.Forms.TextBox NazivAgencijeTextBox;
        private System.Windows.Forms.Label BrTelefonaLbl;
        private System.Windows.Forms.TextBox BrTelefonaTextBox;
        private System.Windows.Forms.Label AdresaLbl;
        private System.Windows.Forms.TextBox AdresaTextBox;
    }
}