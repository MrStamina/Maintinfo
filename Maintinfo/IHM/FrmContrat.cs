using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;




using BO;
using BusinessLogicLayer;
using EntityDal.Exceptions;

namespace IHM
{
    
    public partial class FrmContrat : Form
    {
        private GestionnaireContrat gesContrat;
        
        private decimal montantHt;
        private decimal montantTtc;
        public FrmContrat()
        {
            InitializeComponent();
            Chargement();
        }

        #region Gestion des bouton vers d'autres formes
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
        #endregion

        #region Gestion du chargement de la form
        private void Chargement()
        {
            gesContrat = new GestionnaireContrat();
            
            //listEquip = new List<Equipement>();
            //listEquipByCentre = new List<LigneEquipement>();
            try
            {
                clientBindingSource.DataSource = gesContrat.GetAllClients();
                //modeleBindingSource.DataSource = gesContrat.ChargerModele();


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
        #endregion

        #region Gestion des deux comboboxs
        private void AlimenterCentre()
        {
            if (comboBoxSelectionnerClient.SelectedItem != null)
            {
                try
                {
                    var listCentre = gesContrat.GetCentreByClient(((Client)comboBoxSelectionnerClient.SelectedItem).Id);
                    GestionAffichageCentre(listCentre);

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

        }

        private void GestionAffichageCentre(IEnumerable<CentreInformatique> listCentreInformatiques)
        {
            if (!listCentreInformatiques.Any())
            {
                string message = "Les centres rattachés au client possèdent déja un contrat de maintenance. \n Souhaitez-vous créer un nouveau centre ?";
                string caption = "Information";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
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

            }
            else
            {
                labelMessage.ForeColor = Color.Red;
                labelMessage.Text = "Il y a " + listCentreInformatiques.Count().ToString() + " centre(s) disponible(s) pour un contrat de maintenance";
                centreInformatiqueBindingSource.DataSource = listCentreInformatiques;
            }
        }
        private void AlimenterEquipement()
        {
            //if (comboBoxCentreInfo.SelectedItem != null)
            //{
            //    try
            //    {
            //        listEquip = gesContrat.ChargerEquipementParCentre(((CentreInformatique)comboBoxCentreInfo.SelectedItem).NumCentre);
            //    }
            //    catch (DalExceptionAfficheMessage deaf)
            //    {
            //        MessageBox.Show(deaf.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

            //    listEquipByCentre = gesContrat.AfficherEquipementParCentre(listEquip);
            //    equipementByCentreBindingSource.DataSource = listEquipByCentre;
            //    labelMessage.ResetText();


            //}
        }

        private void comboBoxSelectionnerClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipementByCentreBindingSource.Clear();
            AlimenterCentre();
            comboBoxCentreInfo.SelectedItem = null;

        }

        private void comboBoxCentreInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipementByCentreBindingSource.Clear();
            AlimenterEquipement();

        }
        #endregion




        #region Gestion des boutons de calculs montant + remise      
        private void buttonValider_Click(object sender, EventArgs e)
        {

            //montantHt = gesContrat.CalculerMontantHt(listEquipByCentre);
            //textBoxMontantHt.Text = montantHt.ToString("#.##") + " €";
            //montantTtc = gesContrat.CalculerMontantTtc(montantHt);
            //textBoxMontantTtc.Text = montantTtc.ToString("#.##") + " €";
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            //decimal result = 0.01M;

            //montantTtc = gesContrat.AppliquerRemise(Convert.ToDecimal(numericUpDownRemise.Value) * result);
            //textBoxMontantTtc.Text = montantTtc.ToString("#.##") + " €";
        }
        #endregion

        #region Gestion de l'enregistrement du contrat


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //if (comboBoxCentreInfo.SelectedItem != null && comboBoxSelectionnerClient.SelectedItem != null)
            //{
            //    int idContrat = 0;
            //    DateTime dateEcheance = gesContrat.CalculerDateEcheance(dateTimePickerDateValidite.Value);
            //    Contrat contrat = new Contrat(idContrat, (Client)comboBoxSelectionnerClient.SelectedItem,
            //        (CentreInformatique)comboBoxCentreInfo.SelectedItem, montantTtc,
            //        dateTimePickerDateValidite.Value, dateEcheance, textBoxCommentaire.Text);
            //    try
            //    {
            //        idContrat = gesContrat.EnregistrerContrat(contrat);
            //        contrat.NumeroContrat = idContrat;
            //        gesContrat.AjouterEquipementAuContrat(listEquip, contrat.NumeroContrat);
            //        MessageBox.Show("Le Contrat est enregistré");
            //    }
            //    catch (DalExceptionFinAppli defa)
            //    {
            //        MessageBox.Show(defa.Message, "Erreur applicative");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

            //    this.Close();




            //}
        }
        #endregion

        #region Gestion du DatagridView
        private void dataGridViewEquipement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridViewEquipement.Columns["Retirer"].Index && e.RowIndex >= 0)
            //{
            //    string message = "Etes-vous sûr de vouloir retirer le(s) équipement(s) ?";
            //    string caption = "Retrait d'Equipement(s)";
            //    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        LigneEquipement lignEquip = new LigneEquipement();
            //        lignEquip = (dataGridViewEquipement.Rows[e.RowIndex].DataBoundItem) as LigneEquipement;
            //        listEquip = gesContrat.RetirerEquipementDuContrat(listEquip, lignEquip);
            //        equipementByCentreBindingSource.Remove(lignEquip);
            //        textBoxMontantHt.Clear();
            //        textBoxMontantTtc.Clear();
            //    }

            //}
            //dataGridViewEquipement.Refresh();
        }

        #endregion

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
