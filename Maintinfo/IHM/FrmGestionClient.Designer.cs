namespace IHM
{
    partial class FrmGestionClient
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.maskedTextBoxCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(114, 62);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 65);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(58, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom Client";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(114, 108);
            this.textBoxAdresse.Multiline = true;
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(100, 40);
            this.textBoxAdresse.TabIndex = 2;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(12, 124);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 3;
            this.labelAdresse.Text = "Adresse";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(114, 247);
            this.maskedTextBoxTel.Mask = "00 00 00 00 00 00";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 4;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(12, 250);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(58, 13);
            this.labelTel.TabIndex = 5;
            this.labelTel.Text = "Telephone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enregistrer Fiche";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(321, 143);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 43);
            this.buttonAnnuler.TabIndex = 7;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxCodePostal
            // 
            this.maskedTextBoxCodePostal.Location = new System.Drawing.Point(114, 166);
            this.maskedTextBoxCodePostal.Mask = "99999";
            this.maskedTextBoxCodePostal.Name = "maskedTextBoxCodePostal";
            this.maskedTextBoxCodePostal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCodePostal.TabIndex = 8;
            this.maskedTextBoxCodePostal.ValidatingType = typeof(int);
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(12, 169);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(64, 13);
            this.labelCodePostal.TabIndex = 9;
            this.labelCodePostal.Text = "Code Postal";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(114, 207);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 10;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(12, 210);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 11;
            this.labelVille.Text = "Ville";
            // 
            // FrmGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 325);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.maskedTextBoxCodePostal);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "FrmGestionClient";
            this.Text = "Fiche client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodePostal;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelVille;
    }
}