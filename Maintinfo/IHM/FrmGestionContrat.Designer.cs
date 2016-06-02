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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxSelectionnerClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonConsulter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.centreInformatiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numeroContratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.centreInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.montantHtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEcheance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(471, 39);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(85, 65);
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
            this.comboBoxSelectionnerClient.Location = new System.Drawing.Point(89, 39);
            this.comboBoxSelectionnerClient.Name = "comboBoxSelectionnerClient";
            this.comboBoxSelectionnerClient.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSelectionnerClient.TabIndex = 1;
            this.comboBoxSelectionnerClient.Visible = false;
            this.comboBoxSelectionnerClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionnerClient_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BO.Client);
            // 
            // buttonConsulter
            // 
            this.buttonConsulter.Location = new System.Drawing.Point(471, 110);
            this.buttonConsulter.Name = "buttonConsulter";
            this.buttonConsulter.Size = new System.Drawing.Size(85, 65);
            this.buttonConsulter.TabIndex = 2;
            this.buttonConsulter.Text = "Consulter";
            this.buttonConsulter.UseVisualStyleBackColor = true;
            this.buttonConsulter.Click += new System.EventHandler(this.buttonConsulter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroContratDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.centreInfoDataGridViewTextBoxColumn,
            this.montantHtDataGridViewTextBoxColumn,
            this.DateDebut,
            this.DateEcheance});
            this.dataGridView1.DataSource = this.contratBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 171);
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
            this.buttonCancel.Location = new System.Drawing.Point(565, 39);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 65);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numeroContratDataGridViewTextBoxColumn
            // 
            this.numeroContratDataGridViewTextBoxColumn.DataPropertyName = "NumeroContrat";
            this.numeroContratDataGridViewTextBoxColumn.HeaderText = "NumeroContrat";
            this.numeroContratDataGridViewTextBoxColumn.Name = "numeroContratDataGridViewTextBoxColumn";
            this.numeroContratDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.DataSource = this.clientBindingSource;
            this.clientDataGridViewTextBoxColumn.DisplayMember = "NomClient";
            this.clientDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientDataGridViewTextBoxColumn.ValueMember = "Self";
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // centreInfoDataGridViewTextBoxColumn
            // 
            this.centreInfoDataGridViewTextBoxColumn.DataPropertyName = "CentreInfo";
            this.centreInfoDataGridViewTextBoxColumn.DataSource = this.centreInformatiqueBindingSource;
            this.centreInfoDataGridViewTextBoxColumn.DisplayMember = "Ville";
            this.centreInfoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.centreInfoDataGridViewTextBoxColumn.HeaderText = "Centre Informatique";
            this.centreInfoDataGridViewTextBoxColumn.Name = "centreInfoDataGridViewTextBoxColumn";
            this.centreInfoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.centreInfoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.centreInfoDataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // montantHtDataGridViewTextBoxColumn
            // 
            this.montantHtDataGridViewTextBoxColumn.DataPropertyName = "MontantHt";
            this.montantHtDataGridViewTextBoxColumn.HeaderText = "MontantHt";
            this.montantHtDataGridViewTextBoxColumn.Name = "montantHtDataGridViewTextBoxColumn";
            // 
            // DateDebut
            // 
            this.DateDebut.DataPropertyName = "DateDebut";
            this.DateDebut.HeaderText = "DateDebut";
            this.DateDebut.Name = "DateDebut";
            // 
            // DateEcheance
            // 
            this.DateEcheance.DataPropertyName = "DateEcheance";
            this.DateEcheance.HeaderText = "DateEcheance";
            this.DateEcheance.Name = "DateEcheance";
            // 
            // FrmGestionContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConsulter);
            this.Controls.Add(this.comboBoxSelectionnerClient);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FrmGestionContrat";
            this.Text = "Menu Gestion Contrat";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centreInformatiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxSelectionnerClient;
        private System.Windows.Forms.Button buttonConsulter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private System.Windows.Forms.BindingSource centreInformatiqueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroContratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn centreInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantHtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEcheance;
    }
}

