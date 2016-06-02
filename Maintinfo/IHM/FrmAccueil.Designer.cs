namespace IHM
{
    partial class FrmAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionContratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesContratsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerCentresInformatiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionRéparationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.gestionContratToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.gestionRéparationsToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem1,
            this.quitterToolStripMenuItem1});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // sidentifierToolStripMenuItem1
            // 
            this.sidentifierToolStripMenuItem1.Name = "sidentifierToolStripMenuItem1";
            this.sidentifierToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem1.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem1.Click += new System.EventHandler(this.sidentifierToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // gestionContratToolStripMenuItem
            // 
            this.gestionContratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesContratsToolStripMenuItem,
            this.gérerClientsToolStripMenuItem,
            this.gérerCentresInformatiqueToolStripMenuItem});
            this.gestionContratToolStripMenuItem.Enabled = false;
            this.gestionContratToolStripMenuItem.Name = "gestionContratToolStripMenuItem";
            this.gestionContratToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.gestionContratToolStripMenuItem.Text = "Gestion Contrat";
            // 
            // consulterLesContratsToolStripMenuItem
            // 
            this.consulterLesContratsToolStripMenuItem.Name = "consulterLesContratsToolStripMenuItem";
            this.consulterLesContratsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.consulterLesContratsToolStripMenuItem.Text = "Gérer Contrats";
            this.consulterLesContratsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesContratsToolStripMenuItem_Click);
            // 
            // gérerClientsToolStripMenuItem
            // 
            this.gérerClientsToolStripMenuItem.Name = "gérerClientsToolStripMenuItem";
            this.gérerClientsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gérerClientsToolStripMenuItem.Text = "Gérer Clients";
            this.gérerClientsToolStripMenuItem.Click += new System.EventHandler(this.gérerClientsToolStripMenuItem_Click);
            // 
            // gérerCentresInformatiqueToolStripMenuItem
            // 
            this.gérerCentresInformatiqueToolStripMenuItem.Name = "gérerCentresInformatiqueToolStripMenuItem";
            this.gérerCentresInformatiqueToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gérerCentresInformatiqueToolStripMenuItem.Text = "Gérer Centres ";
            this.gérerCentresInformatiqueToolStripMenuItem.Click += new System.EventHandler(this.gérerCentresInformatiqueToolStripMenuItem_Click);
            // 
            // gestionStockToolStripMenuItem
            // 
            this.gestionStockToolStripMenuItem.Enabled = false;
            this.gestionStockToolStripMenuItem.Name = "gestionStockToolStripMenuItem";
            this.gestionStockToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionStockToolStripMenuItem.Text = "Gestion Stock";
            // 
            // gestionRéparationsToolStripMenuItem
            // 
            this.gestionRéparationsToolStripMenuItem.Enabled = false;
            this.gestionRéparationsToolStripMenuItem.Name = "gestionRéparationsToolStripMenuItem";
            this.gestionRéparationsToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gestionRéparationsToolStripMenuItem.Text = "Gestion Réparations";
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalesToolStripMenuItem,
            this.verticalesToolStripMenuItem});
            this.fenêtresToolStripMenuItem.Enabled = false;
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalesToolStripMenuItem
            // 
            this.horizontalesToolStripMenuItem.Name = "horizontalesToolStripMenuItem";
            this.horizontalesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.horizontalesToolStripMenuItem.Text = "Horizontales";
            this.horizontalesToolStripMenuItem.Click += new System.EventHandler(this.horizontalesToolStripMenuItem_Click);
            // 
            // verticalesToolStripMenuItem
            // 
            this.verticalesToolStripMenuItem.Name = "verticalesToolStripMenuItem";
            this.verticalesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.verticalesToolStripMenuItem.Text = "Verticales";
            this.verticalesToolStripMenuItem.Click += new System.EventHandler(this.verticalesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAccueil";
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAccueil_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionContratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesContratsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerCentresInformatiqueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionRéparationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblDate;
    }
}