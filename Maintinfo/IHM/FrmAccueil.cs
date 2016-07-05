using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void sidentifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var login = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
            if (login != null)
            {
                login.Activate();
            }
            else
            {
                new FrmLogin().Show();
            }
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Etes-vous sûr de vouloir quitter ?";
            const string caption = "QUITTER";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void consulterLesContratsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accueilContrat = Application.OpenForms.OfType<FrmGestionContrat>().FirstOrDefault();
            if (accueilContrat != null)
            {
                accueilContrat.Activate();
            }
            else
            {
                new FrmGestionContrat().Show();
            }
        }

        private void gérerClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ficheClient = Application.OpenForms.OfType<FrmGestionClient>().FirstOrDefault();
            if (ficheClient != null)
            {
                ficheClient.Activate();
            }
            else
            {
                new FrmGestionClient().Show();
            }
        }

        private void gérerCentresInformatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var centre = Application.OpenForms.OfType<FrmGestionCentre>().FirstOrDefault();
            if (centre != null)
            {
                centre.Activate();
            }
            else
            {
                new FrmGestionCentre().Show();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void gérerEquipementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var equipement = Application.OpenForms.OfType<FrmGestionEquipement>().FirstOrDefault();
            if (equipement != null)
            {
                equipement.Activate();
            }
            else
            {
                new FrmGestionEquipement().Show();
            }
        }

        private void gérerTarifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tarifs = Application.OpenForms.OfType<FrmGererTarifs>().FirstOrDefault();
            if (tarifs != null)
            {
                tarifs.Activate();
            }
            else
            {
                new FrmGererTarifs().Show();
            }
        }
    }
}
