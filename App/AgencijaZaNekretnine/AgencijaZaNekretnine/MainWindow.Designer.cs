
namespace AgencijaZaNekretnine
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.NazivAgencijeLbl = new System.Windows.Forms.Label();
            this.NovaNekretnineButton = new System.Windows.Forms.Button();
            this.SveNekretnineButton = new System.Windows.Forms.Button();
            this.NoviUgovorButton = new System.Windows.Forms.Button();
            this.OAgencijiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazivAgencijeLbl
            // 
            this.NazivAgencijeLbl.AutoSize = true;
            this.NazivAgencijeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NazivAgencijeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NazivAgencijeLbl.Location = new System.Drawing.Point(292, 26);
            this.NazivAgencijeLbl.Name = "NazivAgencijeLbl";
            this.NazivAgencijeLbl.Size = new System.Drawing.Size(351, 44);
            this.NazivAgencijeLbl.TabIndex = 0;
            this.NazivAgencijeLbl.Text = "Senzor Nekretnine";
            // 
            // NovaNekretnineButton
            // 
            this.NovaNekretnineButton.BackColor = System.Drawing.Color.Snow;
            this.NovaNekretnineButton.Location = new System.Drawing.Point(15, 118);
            this.NovaNekretnineButton.Name = "NovaNekretnineButton";
            this.NovaNekretnineButton.Size = new System.Drawing.Size(167, 55);
            this.NovaNekretnineButton.TabIndex = 1;
            this.NovaNekretnineButton.Text = "Nova Nekretnina";
            this.NovaNekretnineButton.UseVisualStyleBackColor = false;
            this.NovaNekretnineButton.Click += new System.EventHandler(this.NovaNekretnineButton_Click);
            // 
            // SveNekretnineButton
            // 
            this.SveNekretnineButton.BackColor = System.Drawing.Color.Snow;
            this.SveNekretnineButton.Location = new System.Drawing.Point(249, 118);
            this.SveNekretnineButton.Name = "SveNekretnineButton";
            this.SveNekretnineButton.Size = new System.Drawing.Size(167, 55);
            this.SveNekretnineButton.TabIndex = 2;
            this.SveNekretnineButton.Text = "Sve Nekretnine";
            this.SveNekretnineButton.UseVisualStyleBackColor = false;
            this.SveNekretnineButton.Click += new System.EventHandler(this.SveNekretnineButton_Click);
            // 
            // NoviUgovorButton
            // 
            this.NoviUgovorButton.BackColor = System.Drawing.Color.Snow;
            this.NoviUgovorButton.Location = new System.Drawing.Point(487, 118);
            this.NoviUgovorButton.Name = "NoviUgovorButton";
            this.NoviUgovorButton.Size = new System.Drawing.Size(167, 55);
            this.NoviUgovorButton.TabIndex = 3;
            this.NoviUgovorButton.Text = "Novi Ugovor";
            this.NoviUgovorButton.UseVisualStyleBackColor = false;
            this.NoviUgovorButton.Click += new System.EventHandler(this.NoviUgovorButton_Click);
            // 
            // OAgencijiButton
            // 
            this.OAgencijiButton.BackColor = System.Drawing.Color.Snow;
            this.OAgencijiButton.Location = new System.Drawing.Point(722, 118);
            this.OAgencijiButton.Name = "OAgencijiButton";
            this.OAgencijiButton.Size = new System.Drawing.Size(167, 55);
            this.OAgencijiButton.TabIndex = 4;
            this.OAgencijiButton.Text = "O Agenciji";
            this.OAgencijiButton.UseVisualStyleBackColor = false;
            this.OAgencijiButton.Click += new System.EventHandler(this.OAgencijiButton_Click);
            // 
            // MainWindow
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 525);
            this.Controls.Add(this.OAgencijiButton);
            this.Controls.Add(this.NoviUgovorButton);
            this.Controls.Add(this.SveNekretnineButton);
            this.Controls.Add(this.NovaNekretnineButton);
            this.Controls.Add(this.NazivAgencijeLbl);
            this.Name = "MainWindow";
            this.Text = "Agencija Za Nekretnine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NazivAgencijeLbl;
        private System.Windows.Forms.Button NovaNekretnineButton;
        private System.Windows.Forms.Button SveNekretnineButton;
        private System.Windows.Forms.Button NoviUgovorButton;
        private System.Windows.Forms.Button OAgencijiButton;
    }
}

