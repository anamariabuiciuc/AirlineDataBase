
namespace Airline
{
    partial class Conectare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conectare));
            this.buttonClientExistent = new System.Windows.Forms.Button();
            this.buttonClientNou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientExistent
            // 
            this.buttonClientExistent.Location = new System.Drawing.Point(262, 101);
            this.buttonClientExistent.Name = "buttonClientExistent";
            this.buttonClientExistent.Size = new System.Drawing.Size(100, 45);
            this.buttonClientExistent.TabIndex = 0;
            this.buttonClientExistent.Text = "Client existent";
            this.buttonClientExistent.UseVisualStyleBackColor = true;
            this.buttonClientExistent.Click += new System.EventHandler(this.buttonClientExistent_Click);
            // 
            // buttonClientNou
            // 
            this.buttonClientNou.Location = new System.Drawing.Point(262, 164);
            this.buttonClientNou.Name = "buttonClientNou";
            this.buttonClientNou.Size = new System.Drawing.Size(100, 45);
            this.buttonClientNou.TabIndex = 1;
            this.buttonClientNou.Text = "Client nou";
            this.buttonClientNou.UseVisualStyleBackColor = true;
            this.buttonClientNou.Click += new System.EventHandler(this.buttonClientNou_Click);
            // 
            // Conectare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClientNou);
            this.Controls.Add(this.buttonClientExistent);
            this.Name = "Conectare";
            this.Text = "Conectare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientExistent;
        private System.Windows.Forms.Button buttonClientNou;
    }
}