
namespace Airline
{
    partial class Administrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrare));
            this.buttonAdminClienti = new System.Windows.Forms.Button();
            this.buttonAdminRezervari = new System.Windows.Forms.Button();
            this.buttonAdminBilete = new System.Windows.Forms.Button();
            this.buttonAdminZboruri = new System.Windows.Forms.Button();
            this.buttonAdminRute = new System.Windows.Forms.Button();
            this.buttonAdminAeroport = new System.Windows.Forms.Button();
            this.buttonAdminAeronava = new System.Windows.Forms.Button();
            this.buttonAdminPiloti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdminClienti
            // 
            this.buttonAdminClienti.Location = new System.Drawing.Point(147, 61);
            this.buttonAdminClienti.Name = "buttonAdminClienti";
            this.buttonAdminClienti.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminClienti.TabIndex = 0;
            this.buttonAdminClienti.Text = "Clienti";
            this.buttonAdminClienti.UseVisualStyleBackColor = true;
            this.buttonAdminClienti.Click += new System.EventHandler(this.buttonAdminClienti_Click);
            // 
            // buttonAdminRezervari
            // 
            this.buttonAdminRezervari.Location = new System.Drawing.Point(147, 133);
            this.buttonAdminRezervari.Name = "buttonAdminRezervari";
            this.buttonAdminRezervari.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminRezervari.TabIndex = 1;
            this.buttonAdminRezervari.Text = "Rezervari";
            this.buttonAdminRezervari.UseVisualStyleBackColor = true;
            this.buttonAdminRezervari.Click += new System.EventHandler(this.buttonAdminRezervari_Click);
            // 
            // buttonAdminBilete
            // 
            this.buttonAdminBilete.Location = new System.Drawing.Point(147, 207);
            this.buttonAdminBilete.Name = "buttonAdminBilete";
            this.buttonAdminBilete.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminBilete.TabIndex = 2;
            this.buttonAdminBilete.Text = "Bilete";
            this.buttonAdminBilete.UseVisualStyleBackColor = true;
            this.buttonAdminBilete.Click += new System.EventHandler(this.buttonAdminBilete_Click);
            // 
            // buttonAdminZboruri
            // 
            this.buttonAdminZboruri.Location = new System.Drawing.Point(147, 276);
            this.buttonAdminZboruri.Name = "buttonAdminZboruri";
            this.buttonAdminZboruri.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminZboruri.TabIndex = 3;
            this.buttonAdminZboruri.Text = "Zboruri";
            this.buttonAdminZboruri.UseVisualStyleBackColor = true;
            this.buttonAdminZboruri.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdminRute
            // 
            this.buttonAdminRute.Location = new System.Drawing.Point(459, 61);
            this.buttonAdminRute.Name = "buttonAdminRute";
            this.buttonAdminRute.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminRute.TabIndex = 4;
            this.buttonAdminRute.Text = "Rute";
            this.buttonAdminRute.UseVisualStyleBackColor = true;
            this.buttonAdminRute.Click += new System.EventHandler(this.buttonAdminRute_Click);
            // 
            // buttonAdminAeroport
            // 
            this.buttonAdminAeroport.Location = new System.Drawing.Point(459, 133);
            this.buttonAdminAeroport.Name = "buttonAdminAeroport";
            this.buttonAdminAeroport.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminAeroport.TabIndex = 5;
            this.buttonAdminAeroport.Text = "Aeroporturi";
            this.buttonAdminAeroport.UseVisualStyleBackColor = true;
            this.buttonAdminAeroport.Click += new System.EventHandler(this.buttonAdminAeroport_Click);
            // 
            // buttonAdminAeronava
            // 
            this.buttonAdminAeronava.Location = new System.Drawing.Point(459, 205);
            this.buttonAdminAeronava.Name = "buttonAdminAeronava";
            this.buttonAdminAeronava.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminAeronava.TabIndex = 6;
            this.buttonAdminAeronava.Text = "Aeronave";
            this.buttonAdminAeronava.UseVisualStyleBackColor = true;
            this.buttonAdminAeronava.Click += new System.EventHandler(this.buttonAdminAeronava_Click);
            // 
            // buttonAdminPiloti
            // 
            this.buttonAdminPiloti.Location = new System.Drawing.Point(459, 276);
            this.buttonAdminPiloti.Name = "buttonAdminPiloti";
            this.buttonAdminPiloti.Size = new System.Drawing.Size(100, 45);
            this.buttonAdminPiloti.TabIndex = 7;
            this.buttonAdminPiloti.Text = "Piloti";
            this.buttonAdminPiloti.UseVisualStyleBackColor = true;
            this.buttonAdminPiloti.Click += new System.EventHandler(this.buttonAdminPiloti_Click);
            // 
            // Administrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdminPiloti);
            this.Controls.Add(this.buttonAdminAeronava);
            this.Controls.Add(this.buttonAdminAeroport);
            this.Controls.Add(this.buttonAdminRute);
            this.Controls.Add(this.buttonAdminZboruri);
            this.Controls.Add(this.buttonAdminBilete);
            this.Controls.Add(this.buttonAdminRezervari);
            this.Controls.Add(this.buttonAdminClienti);
            this.Name = "Administrare";
            this.Text = "Administrare";
            this.Load += new System.EventHandler(this.Administrare_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminClienti;
        private System.Windows.Forms.Button buttonAdminRezervari;
        private System.Windows.Forms.Button buttonAdminBilete;
        private System.Windows.Forms.Button buttonAdminZboruri;
        private System.Windows.Forms.Button buttonAdminRute;
        private System.Windows.Forms.Button buttonAdminAeroport;
        private System.Windows.Forms.Button buttonAdminAeronava;
        private System.Windows.Forms.Button buttonAdminPiloti;
    }
}