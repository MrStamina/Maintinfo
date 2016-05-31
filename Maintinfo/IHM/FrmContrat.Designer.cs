namespace IHM
{
    partial class FrmContrat
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
            this.comboBoxSelectionnerClient = new System.Windows.Forms.ComboBox();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateValidite = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMontantHt = new System.Windows.Forms.TextBox();
            this.textBoxMontantTtc = new System.Windows.Forms.TextBox();
            this.labelMontantTTC = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCentreInformatique = new System.Windows.Forms.Label();
            this.buttonGererCentre = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.dataGridViewEquipementsSousContrat = new System.Windows.Forms.DataGridView();
            this.labelEquipements = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipementsSousContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectionnerClient
            // 
            this.comboBoxSelectionnerClient.FormattingEnabled = true;
            this.comboBoxSelectionnerClient.Location = new System.Drawing.Point(119, 52);
            this.comboBoxSelectionnerClient.Name = "comboBoxSelectionnerClient";
            this.comboBoxSelectionnerClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectionnerClient.TabIndex = 0;
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Location = new System.Drawing.Point(400, 52);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(75, 61);
            this.buttonCreateClient.TabIndex = 1;
            this.buttonCreateClient.Text = "Créer Client";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            // 
            // dateTimePickerDateValidite
            // 
            this.dateTimePickerDateValidite.Location = new System.Drawing.Point(119, 244);
            this.dateTimePickerDateValidite.Name = "dateTimePickerDateValidite";
            this.dateTimePickerDateValidite.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerDateValidite.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(119, 285);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(183, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date Validité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date d\'échéance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Montant Ht";
            // 
            // textBoxMontantHt
            // 
            this.textBoxMontantHt.Location = new System.Drawing.Point(119, 325);
            this.textBoxMontantHt.Name = "textBoxMontantHt";
            this.textBoxMontantHt.Size = new System.Drawing.Size(183, 20);
            this.textBoxMontantHt.TabIndex = 9;
            // 
            // textBoxMontantTtc
            // 
            this.textBoxMontantTtc.Location = new System.Drawing.Point(119, 363);
            this.textBoxMontantTtc.Name = "textBoxMontantTtc";
            this.textBoxMontantTtc.Size = new System.Drawing.Size(183, 20);
            this.textBoxMontantTtc.TabIndex = 10;
            // 
            // labelMontantTTC
            // 
            this.labelMontantTTC.AutoSize = true;
            this.labelMontantTTC.Location = new System.Drawing.Point(12, 366);
            this.labelMontantTTC.Name = "labelMontantTTC";
            this.labelMontantTTC.Size = new System.Drawing.Size(65, 13);
            this.labelMontantTTC.TabIndex = 11;
            this.labelMontantTTC.Text = "Montant Ttc";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // labelCentreInformatique
            // 
            this.labelCentreInformatique.AutoSize = true;
            this.labelCentreInformatique.Location = new System.Drawing.Point(12, 100);
            this.labelCentreInformatique.Name = "labelCentreInformatique";
            this.labelCentreInformatique.Size = new System.Drawing.Size(98, 13);
            this.labelCentreInformatique.TabIndex = 13;
            this.labelCentreInformatique.Text = "Centre informatique";
            // 
            // buttonGererCentre
            // 
            this.buttonGererCentre.Location = new System.Drawing.Point(400, 128);
            this.buttonGererCentre.Name = "buttonGererCentre";
            this.buttonGererCentre.Size = new System.Drawing.Size(75, 61);
            this.buttonGererCentre.TabIndex = 14;
            this.buttonGererCentre.Text = "Gérer Centre";
            this.buttonGererCentre.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(493, 52);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 61);
            this.buttonRegister.TabIndex = 15;
            this.buttonRegister.Text = "Enregistrer Contrat";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(493, 128);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 61);
            this.buttonRetour.TabIndex = 16;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEquipementsSousContrat
            // 
            this.dataGridViewEquipementsSousContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipementsSousContrat.Location = new System.Drawing.Point(119, 138);
            this.dataGridViewEquipementsSousContrat.Name = "dataGridViewEquipementsSousContrat";
            this.dataGridViewEquipementsSousContrat.Size = new System.Drawing.Size(247, 89);
            this.dataGridViewEquipementsSousContrat.TabIndex = 17;
            // 
            // labelEquipements
            // 
            this.labelEquipements.Location = new System.Drawing.Point(12, 167);
            this.labelEquipements.Name = "labelEquipements";
            this.labelEquipements.Size = new System.Drawing.Size(100, 33);
            this.labelEquipements.TabIndex = 18;
            this.labelEquipements.Text = "Equipements sous contrat";
            // 
            // FrmContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 447);
            this.Controls.Add(this.labelEquipements);
            this.Controls.Add(this.dataGridViewEquipementsSousContrat);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonGererCentre);
            this.Controls.Add(this.labelCentreInformatique);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelMontantTTC);
            this.Controls.Add(this.textBoxMontantTtc);
            this.Controls.Add(this.textBoxMontantHt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePickerDateValidite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.comboBoxSelectionnerClient);
            this.Name = "FrmContrat";
            this.Text = "FrmContrat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipementsSousContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectionnerClient;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateValidite;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMontantHt;
        private System.Windows.Forms.TextBox textBoxMontantTtc;
        private System.Windows.Forms.Label labelMontantTTC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCentreInformatique;
        private System.Windows.Forms.Button buttonGererCentre;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataGridView dataGridViewEquipementsSousContrat;
        private System.Windows.Forms.Label labelEquipements;
    }
}