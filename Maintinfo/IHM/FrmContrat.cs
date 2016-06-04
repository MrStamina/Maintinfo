using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Exceptions;
using BO;

namespace IHM
{
    
    public partial class FrmContrat : Form
    {
        GestionnaireContrat gesContrat;
        public FrmContrat()
        {
            InitializeComponent();
            chargement();
        }

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            var newclient = Application.OpenForms.OfType<FrmGestionClient>().FirstOrDefault();
            if (newclient != null)
            {
                newclient.Activate();
            }
            else
            {
                new FrmGestionClient().Show();
            }
        }

        private void buttonGererCentre_Click(object sender, EventArgs e)
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

        private void chargement()
        {
            gesContrat = new GestionnaireContrat();
            try
            {
                clientBindingSource.DataSource = gesContrat.ChargerClient();
                modeleBindingSource.DataSource = gesContrat.ChargerModele();                
                
            }
            catch (DalExceptionAfficheMessage deaf)
            {
                MessageBox.Show(deaf.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBoxSelectionnerClient.SelectedItem = null;            
            
        }
        private void alimenterCentre()
        {
            if(comboBoxSelectionnerClient.SelectedItem != null)
            {
                centreInformatiqueBindingSource.DataSource = gesContrat.AfficherCentreParClient(((Client)comboBoxSelectionnerClient.SelectedItem).NumClient);
                comboBoxCentreInfo.SelectedItem = null;

            }
        }

        private void comboBoxSelectionnerClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            alimenterCentre();
        }

        private void comboBoxCentreInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            alimenterEquipement();
        }

        private void alimenterEquipement()
        {
            if(comboBoxCentreInfo.SelectedItem != null)
            {
                //modeleBindingSource.DataSource = 
                equipementBindingSource.DataSource = gesContrat.AfficherEquipementParCentre(((CentreInformatique)comboBoxCentreInfo.SelectedItem).NumCentre);

            }
        }
    }
}
