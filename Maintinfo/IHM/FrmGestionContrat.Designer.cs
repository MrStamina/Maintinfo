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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxSelectionnerClient = new System.Windows.Forms.ComboBox();
            this.buttonConsulter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // comboBoxSelectionnerClient
            // 
            this.comboBoxSelectionnerClient.FormattingEnabled = true;
            this.comboBoxSelectionnerClient.Location = new System.Drawing.Point(89, 39);
            this.comboBoxSelectionnerClient.Name = "comboBoxSelectionnerClient";
            this.comboBoxSelectionnerClient.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSelectionnerClient.TabIndex = 1;
            // 
            // buttonConsulter
            // 
            this.buttonConsulter.Location = new System.Drawing.Point(471, 110);
            this.buttonConsulter.Name = "buttonConsulter";
            this.buttonConsulter.Size = new System.Drawing.Size(85, 65);
            this.buttonConsulter.TabIndex = 2;
            this.buttonConsulter.Text = "Consulter";
            this.buttonConsulter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 171);
            this.dataGridView1.TabIndex = 3;
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxSelectionnerClient;
        private System.Windows.Forms.Button buttonConsulter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancel;
    }
}

