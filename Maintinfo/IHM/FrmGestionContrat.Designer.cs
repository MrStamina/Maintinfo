namespace IHM
{
    partial class FrmGestionContrat
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxSelectionnerClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.centreInformatiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelChoixClient = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.centreInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEcheance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantTtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(457, 69);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(71, 47);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Créer";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxSelectionnerClient
            // 
            this.comboBoxSelectionnerClient.DataSource = this.clientBindingSource;
            this.comboBoxSelectionnerClient.DisplayMember = "NomClient";
            this.comboBoxSelectionnerClient.FormattingEnabled = true;
            this.comboBoxSelectionnerClient.Location = new System.Drawing.Point(60, 83);
            this.comboBoxSelectionnerClient.Name = "comboBoxSelectionnerClient";
            this.comboBoxSelectionnerClient.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSelectionnerClient.TabIndex = 1;
            this.comboBoxSelectionnerClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionnerClient_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BO.Client);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.centreInfoDataGridViewTextBoxColumn,
            this.DateDebut,
            this.DateEcheance,
            this.MontantTtc,
            this.Modifier,
            this.Column1});
            this.dataGridView1.DataSource = this.contratBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 171);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // centreInformatiqueBindingSource
            // 
            this.centreInformatiqueBindingSource.DataSource = typeof(BO.CentreInformatique);
            // 
            // contratBindingSource
            // 
            this.contratBindingSource.DataSource = typeof(BO.Contrat);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(549, 69);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 47);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelChoixClient
            // 
            this.labelChoixClient.AutoSize = true;
            this.labelChoixClient.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoixClient.Location = new System.Drawing.Point(57, 49);
            this.labelChoixClient.Name = "labelChoixClient";
            this.labelChoixClient.Size = new System.Drawing.Size(133, 14);
            this.labelChoixClient.TabIndex = 5;
            this.labelChoixClient.Text = "Sélectionner un client :";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(224, 142);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 6;
            // 
            // centreInfoDataGridViewTextBoxColumn
            // 
            this.centreInfoDataGridViewTextBoxColumn.DataPropertyName = "CentreInfo";
            this.centreInfoDataGridViewTextBoxColumn.DataSource = this.centreInformatiqueBindingSource;
            this.centreInfoDataGridViewTextBoxColumn.DisplayMember = "Ville";
            this.centreInfoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.centreInfoDataGridViewTextBoxColumn.HeaderText = "Centre Informatique";
            this.centreInfoDataGridViewTextBoxColumn.Name = "centreInfoDataGridViewTextBoxColumn";
            this.centreInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.centreInfoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.centreInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.centreInfoDataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // DateDebut
            // 
            this.DateDebut.DataPropertyName = "DateDebut";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.DateDebut.DefaultCellStyle = dataGridViewCellStyle7;
            this.DateDebut.HeaderText = "DateDebut";
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.ReadOnly = true;
            // 
            // DateEcheance
            // 
            this.DateEcheance.DataPropertyName = "DateEcheance";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.DateEcheance.DefaultCellStyle = dataGridViewCellStyle8;
            this.DateEcheance.HeaderText = "DateEcheance";
            this.DateEcheance.Name = "DateEcheance";
            this.DateEcheance.ReadOnly = true;
            // 
            // MontantTtc
            // 
            this.MontantTtc.DataPropertyName = "MontantTtc";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.MontantTtc.DefaultCellStyle = dataGridViewCellStyle9;
            this.MontantTtc.HeaderText = "MontantTtc";
            this.MontantTtc.Name = "MontantTtc";
            this.MontantTtc.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            this.Modifier.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Supprimer";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 80;
            // 
            // FrmGestionContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelChoixClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxSelectionnerClient);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FrmGestionContrat";
            this.Text = "Menu Gestion Contrat";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxSelectionnerClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private System.Windows.Forms.BindingSource centreInformatiqueBindingSource;
        private System.Windows.Forms.Label labelChoixClient;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantHtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn centreInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEcheance;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantTtc;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}

