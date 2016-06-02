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
using BO;
using DAL.Exceptions;



namespace IHM
{
    public partial class FrmGestionContrat : Form
    {
        ClientManager clientMan;
        ManagerCentreInformatique manCentre;
        ManagerContrat manContrat;
        public FrmGestionContrat()
        {
            InitializeComponent();
            Chargement();           
           
        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {
           
            comboBoxSelectionnerClient.Visible = true;
            comboBoxSelectionnerClient.SelectedItem = null ;
        }

        private void comboBoxSelectionnerClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBoxSelectionnerClient.SelectedItem != null)
            {
                dataGridView1.Visible = true;
                contratBindingSource.DataSource = manContrat.consulterContratParClient(((Client)comboBoxSelectionnerClient.SelectedItem).NumClient);
            }
            
        }

        private void Chargement()
        {
            clientMan = new ClientManager();
            manCentre = new ManagerCentreInformatique();
            manContrat = new ManagerContrat();
            try
            {
                clientBindingSource.DataSource = clientMan.chargerClient();
                centreInformatiqueBindingSource.DataSource = manCentre.chargerCentre();
                contratBindingSource.DataSource = manContrat.chargerLesContrats();
            }
            catch (DalExceptionAfficheMessage deaf)
            {
                MessageBox.Show(deaf.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var createContrat = Application.OpenForms.OfType<FrmContrat>().FirstOrDefault();
            if(createContrat != null)
            {
                createContrat.Activate();
            }
            else
            {
                new FrmContrat().Show();
            }
        }
    }
}
