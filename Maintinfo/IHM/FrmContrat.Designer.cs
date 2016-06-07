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
            this.components = new System.ComponentModel.Container();
            this.comboBoxSelectionnerClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateValidite = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMontantHt = new System.Windows.Forms.TextBox();
            this.textBoxMontantTtc = new System.Windows.Forms.TextBox();
            this.labelMontantTTC = new System.Windows.Forms.Label();
            this.comboBoxCentreInfo = new System.Windows.Forms.ComboBox();
            this.centreInformatiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCentreInformatique = new System.Windows.Forms.Label();
            this.buttonGererCentre = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.modeleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelEquipements = new System.Windows.Forms.Label();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.groupBoxRemise = new System.Windows.Forms.GroupBox();
            this.numericUpDownRemise = new System.Windows.Forms.NumericUpDown();
            this.buttonAppliquer = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.dataGridViewEquipement = new System.Windows.Forms.DataGridView();
            this.equipementByCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleModeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).BeginInit();
            this.groupBoxRemise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementByCentreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectionnerClient
            // 
            this.comboBoxSelectionnerClient.DataSource = this.clientBindingSource;
            this.comboBoxSelectionnerClient.DisplayMember = "NomClient";
            this.comboBoxSelectionnerClient.FormattingEnabled = true;
            this.comboBoxSelectionnerClient.Location = new System.Drawing.Point(119, 48);
            this.comboBoxSelectionnerClient.Name = "comboBoxSelectionnerClient";
            this.comboBoxSelectionnerClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectionnerClient.TabIndex = 0;
            this.comboBoxSelectionnerClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionnerClient_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BO.Client);
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Location = new System.Drawing.Point(480, 119);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(75, 61);
            this.buttonCreateClient.TabIndex = 1;
            this.buttonCreateClient.Text = "Gérer Client";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client :";
            // 
            // dateTimePickerDateValidite
            // 
            this.dateTimePickerDateValidite.Location = new System.Drawing.Point(118, 307);
            this.dateTimePickerDateValidite.Name = "dateTimePickerDateValidite";
            this.dateTimePickerDateValidite.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerDateValidite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date début :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Montant Ht :";
            // 
            // textBoxMontantHt
            // 
            this.textBoxMontantHt.Location = new System.Drawing.Point(119, 345);
            this.textBoxMontantHt.Name = "textBoxMontantHt";
            this.textBoxMontantHt.Size = new System.Drawing.Size(77, 20);
            this.textBoxMontantHt.TabIndex = 9;
            // 
            // textBoxMontantTtc
            // 
            this.textBoxMontantTtc.Location = new System.Drawing.Point(119, 380);
            this.textBoxMontantTtc.Name = "textBoxMontantTtc";
            this.textBoxMontantTtc.Size = new System.Drawing.Size(77, 20);
            this.textBoxMontantTtc.TabIndex = 10;
            // 
            // labelMontantTTC
            // 
            this.labelMontantTTC.AutoSize = true;
            this.labelMontantTTC.Location = new System.Drawing.Point(12, 387);
            this.labelMontantTTC.Name = "labelMontantTTC";
            this.labelMontantTTC.Size = new System.Drawing.Size(71, 13);
            this.labelMontantTTC.TabIndex = 11;
            this.labelMontantTTC.Text = "Montant Ttc :";
            // 
            // comboBoxCentreInfo
            // 
            this.comboBoxCentreInfo.DataSource = this.centreInformatiqueBindingSource;
            this.comboBoxCentreInfo.DisplayMember = "Ville";
            this.comboBoxCentreInfo.FormattingEnabled = true;
            this.comboBoxCentreInfo.Location = new System.Drawing.Point(386, 45);
            this.comboBoxCentreInfo.Name = "comboBoxCentreInfo";
            this.comboBoxCentreInfo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCentreInfo.TabIndex = 12;
            this.comboBoxCentreInfo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCentreInfo_SelectedIndexChanged);
            // 
            // centreInformatiqueBindingSource
            // 
            this.centreInformatiqueBindingSource.DataSource = typeof(BO.CentreInformatique);
            // 
            // labelCentreInformatique
            // 
            this.labelCentreInformatique.AutoSize = true;
            this.labelCentreInformatique.Location = new System.Drawing.Point(276, 48);
            this.labelCentreInformatique.Name = "labelCentreInformatique";
            this.labelCentreInformatique.Size = new System.Drawing.Size(104, 13);
            this.labelCentreInformatique.TabIndex = 13;
            this.labelCentreInformatique.Text = "Centre informatique :";
            // 
            // buttonGererCentre
            // 
            this.buttonGererCentre.Location = new System.Drawing.Point(480, 198);
            this.buttonGererCentre.Name = "buttonGererCentre";
            this.buttonGererCentre.Size = new System.Drawing.Size(75, 61);
            this.buttonGererCentre.TabIndex = 14;
            this.buttonGererCentre.Text = "Gérer Centre";
            this.buttonGererCentre.UseVisualStyleBackColor = true;
            this.buttonGererCentre.Click += new System.EventHandler(this.buttonGererCentre_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(568, 119);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 61);
            this.buttonRegister.TabIndex = 15;
            this.buttonRegister.Text = "Enregistrer Contrat";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(568, 198);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 61);
            this.buttonRetour.TabIndex = 16;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            // 
            // modeleBindingSource
            // 
            this.modeleBindingSource.DataSource = typeof(BO.Modele);
            // 
            // equipementBindingSource
            // 
            this.equipementBindingSource.DataSource = typeof(BO.Equipement);
            // 
            // labelEquipements
            // 
            this.labelEquipements.Location = new System.Drawing.Point(12, 143);
            this.labelEquipements.Name = "labelEquipements";
            this.labelEquipements.Size = new System.Drawing.Size(100, 33);
            this.labelEquipements.TabIndex = 18;
            this.labelEquipements.Text = "Equipements sous contrat :";
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Location = new System.Drawing.Point(315, 342);
            this.textBoxCommentaire.MaxLength = 100;
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(127, 58);
            this.textBoxCommentaire.TabIndex = 19;
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(235, 365);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(74, 13);
            this.labelCommentaire.TabIndex = 20;
            this.labelCommentaire.Text = "Commentaire :";
            // 
            // groupBoxRemise
            // 
            this.groupBoxRemise.Controls.Add(this.numericUpDownRemise);
            this.groupBoxRemise.Controls.Add(this.buttonAppliquer);
            this.groupBoxRemise.Location = new System.Drawing.Point(460, 291);
            this.groupBoxRemise.Name = "groupBoxRemise";
            this.groupBoxRemise.Size = new System.Drawing.Size(183, 74);
            this.groupBoxRemise.TabIndex = 21;
            this.groupBoxRemise.TabStop = false;
            this.groupBoxRemise.Text = "Remise %";
            // 
            // numericUpDownRemise
            // 
            this.numericUpDownRemise.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRemise.Location = new System.Drawing.Point(20, 39);
            this.numericUpDownRemise.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownRemise.Name = "numericUpDownRemise";
            this.numericUpDownRemise.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownRemise.TabIndex = 1;
            // 
            // buttonAppliquer
            // 
            this.buttonAppliquer.Location = new System.Drawing.Point(102, 39);
            this.buttonAppliquer.Name = "buttonAppliquer";
            this.buttonAppliquer.Size = new System.Drawing.Size(75, 23);
            this.buttonAppliquer.TabIndex = 0;
            this.buttonAppliquer.Text = "Appliquer";
            this.buttonAppliquer.UseVisualStyleBackColor = true;
            this.buttonAppliquer.Click += new System.EventHandler(this.buttonAppliquer_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(253, 265);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 22;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // dataGridViewEquipement
            // 
            this.dataGridViewEquipement.AllowUserToAddRows = false;
            this.dataGridViewEquipement.AllowUserToDeleteRows = false;
            this.dataGridViewEquipement.AutoGenerateColumns = false;
            this.dataGridViewEquipement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qteDataGridViewTextBoxColumn,
            this.libelleModeleDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn,
            this.Supprimer});
            this.dataGridViewEquipement.DataSource = this.equipementByCentreBindingSource;
            this.dataGridViewEquipement.Location = new System.Drawing.Point(119, 108);
            this.dataGridViewEquipement.Name = "dataGridViewEquipement";
            this.dataGridViewEquipement.ReadOnly = true;
            this.dataGridViewEquipement.Size = new System.Drawing.Size(336, 151);
            this.dataGridViewEquipement.TabIndex = 23;
            // 
            // equipementByCentreBindingSource
            // 
            this.equipementByCentreBindingSource.DataSource = typeof(BO.LigneEquipement);
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            this.qteDataGridViewTextBoxColumn.ReadOnly = true;
            this.qteDataGridViewTextBoxColumn.Width = 50;
            // 
            // libelleModeleDataGridViewTextBoxColumn
            // 
            this.libelleModeleDataGridViewTextBoxColumn.DataPropertyName = "Libelle_Modele";
            this.libelleModeleDataGridViewTextBoxColumn.HeaderText = "      Modele";
            this.libelleModeleDataGridViewTextBoxColumn.Name = "libelleModeleDataGridViewTextBoxColumn";
            this.libelleModeleDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleModeleDataGridViewTextBoxColumn.Width = 110;
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            this.tarifDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifDataGridViewTextBoxColumn.Width = 50;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 80;
            // 
            // FrmContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 447);
            this.Controls.Add(this.dataGridViewEquipement);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.groupBoxRemise);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.textBoxCommentaire);
            this.Controls.Add(this.labelEquipements);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonGererCentre);
            this.Controls.Add(this.labelCentreInformatique);
            this.Controls.Add(this.comboBoxCentreInfo);
            this.Controls.Add(this.labelMontantTTC);
            this.Controls.Add(this.textBoxMontantTtc);
            this.Controls.Add(this.textBoxMontantHt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDateValidite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.comboBoxSelectionnerClient);
            this.Name = "FrmContrat";
            this.Text = "Enregistrer Contrat";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).EndInit();
            this.groupBoxRemise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementByCentreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectionnerClient;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateValidite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMontantHt;
        private System.Windows.Forms.TextBox textBoxMontantTtc;
        private System.Windows.Forms.Label labelMontantTTC;
        private System.Windows.Forms.ComboBox comboBoxCentreInfo;
        private System.Windows.Forms.Label labelCentreInformatique;
        private System.Windows.Forms.Button buttonGererCentre;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelEquipements;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource equipementBindingSource;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.GroupBox groupBoxRemise;
        private System.Windows.Forms.NumericUpDown numericUpDownRemise;
        private System.Windows.Forms.Button buttonAppliquer;
        private System.Windows.Forms.BindingSource centreInformatiqueBindingSource;
        private System.Windows.Forms.BindingSource modeleBindingSource;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DataGridView dataGridViewEquipement;
        //private MaintinfoDataSetTableAdapters.GetEquipementByCentreTableAdapter getEquipementByCentreTableAdapter;
        private System.Windows.Forms.BindingSource equipementByCentreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleModeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}