using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
//using BO;

using EntityDal;


namespace IHM
{
    public partial class FrmGestionContrat : Form
    {
        GestionnaireContrat gesContrat;
        public FrmGestionContrat()
        {
            InitializeComponent();
            //Chargement();

        }

        //TODO rajouter les exceptions
       

        private void comboBoxSelectionnerClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSelectionnerClient.SelectedItem != null)
            {
                contratBindingSource.DataSource = gesContrat.ConsulterContratParClient(((Client)comboBoxSelectionnerClient.SelectedItem).Id);
                AfficheMessage();
            }

        }

        //private void Chargement()
        //{
        //    gesContrat = new GestionnaireContrat();
        //    try
        //    {
        //        clientBindingSource.DataSource = gesContrat.ChargerClient();
        //        centreInformatiqueBindingSource.DataSource = gesContrat.ChargerCentre();
        //        contratBindingSource.DataSource = gesContrat.ChargerContrat();
        //    }
        //    catch (DalExceptionAfficheMessage deaf)
        //    {
        //        MessageBox.Show(deaf.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    comboBoxSelectionnerClient.SelectedItem = null;


        //}

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var createContrat = Application.OpenForms.OfType<FrmContrat>().FirstOrDefault();
            if (createContrat != null)
            {
                createContrat.Activate();
            }
            else
            {
                new FrmContrat().Show();
            }
        }

        public void AfficheMessage()
        {
            int numClient = ((Client)comboBoxSelectionnerClient.SelectedItem).Id;

            var listContrats = gesContrat.ConsulterContratParClient(numClient);
            if (!listContrats.Any())
            {
                labelMessage.ForeColor = Color.Red;
                labelMessage.Text = "Aucun contrat disponible pour ce client";
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
                labelMessage.ResetText();
            }
        }
    }
}
