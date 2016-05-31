namespace IHM
{
    partial class FrmGestionCentre
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.comboBoxSecteurGeographique = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEquipements = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Configuration = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listBoxEquipements = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.Configuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(142, 55);
            this.maskedTextBox1.Mask = "00 00 00 00 00 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(12, 58);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(58, 13);
            this.labelTel.TabIndex = 1;
            this.labelTel.Text = "Numéro tel";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(142, 105);
            this.textBoxAdresse.Multiline = true;
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(97, 51);
            this.textBoxAdresse.TabIndex = 2;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(12, 129);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 3;
            this.labelAdresse.Text = "Adresse";
            // 
            // comboBoxSecteurGeographique
            // 
            this.comboBoxSecteurGeographique.FormattingEnabled = true;
            this.comboBoxSecteurGeographique.Location = new System.Drawing.Point(142, 193);
            this.comboBoxSecteurGeographique.Name = "comboBoxSecteurGeographique";
            this.comboBoxSecteurGeographique.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecteurGeographique.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Secteur géographique";
            // 
            // comboBoxEquipements
            // 
            this.comboBoxEquipements.FormattingEnabled = true;
            this.comboBoxEquipements.Location = new System.Drawing.Point(109, 39);
            this.comboBoxEquipements.Name = "comboBoxEquipements";
            this.comboBoxEquipements.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipements.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Equipement";
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.buttonAjouter);
            this.Configuration.Controls.Add(this.labelQuantite);
            this.Configuration.Controls.Add(this.numericUpDownQuantite);
            this.Configuration.Controls.Add(this.label2);
            this.Configuration.Controls.Add(this.comboBoxEquipements);
            this.Configuration.Location = new System.Drawing.Point(285, 58);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(280, 156);
            this.Configuration.TabIndex = 8;
            this.Configuration.TabStop = false;
            this.Configuration.Text = "Configuration centre";
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Location = new System.Drawing.Point(109, 86);
            this.numericUpDownQuantite.Name = "numericUpDownQuantite";
            this.numericUpDownQuantite.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownQuantite.TabIndex = 8;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(13, 93);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(47, 13);
            this.labelQuantite.TabIndex = 9;
            this.labelQuantite.Text = "Quantité";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(109, 127);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // listBoxEquipements
            // 
            this.listBoxEquipements.FormattingEnabled = true;
            this.listBoxEquipements.Location = new System.Drawing.Point(100, 260);
            this.listBoxEquipements.Name = "listBoxEquipements";
            this.listBoxEquipements.Size = new System.Drawing.Size(383, 160);
            this.listBoxEquipements.TabIndex = 9;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(254, 426);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Retirer";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(466, 12);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(85, 40);
            this.buttonRetour.TabIndex = 12;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(350, 12);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(85, 40);
            this.buttonEnregistrer.TabIndex = 13;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // FrmGestionCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 476);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxEquipements);
            this.Controls.Add(this.Configuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSecteurGeographique);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "FrmGestionCentre";
            this.Text = "Fiche centre";
            this.Configuration.ResumeLayout(false);
            this.Configuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.ComboBox comboBoxSecteurGeographique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEquipements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Configuration;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantite;
        private System.Windows.Forms.ListBox listBoxEquipements;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonEnregistrer;
    }
}