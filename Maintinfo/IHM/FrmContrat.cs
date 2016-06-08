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

using BLL;
using DAL.Exceptions;
using BO;

namespace IHM
{
    
    public partial class FrmContrat : Form
    {
        GestionnaireContrat gesContrat;
        List<Equipement> listEquip;
        List<LigneEquipement> listEquipByCentre;
        double montantHt;
        double montantTtc;
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
            //listEquip = new List<Equipement>();
            listEquipByCentre = new List<LigneEquipement>();
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
                try
                {
                    centreInformatiqueBindingSource.DataSource = gesContrat.AfficherCentreParClient(((Client)comboBoxSelectionnerClient.SelectedItem).NumClient);

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

        private void comboBoxSelectionnerClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            alimenterCentre();
            comboBoxCentreInfo.SelectedItem = null;
        }

        private void comboBoxCentreInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            alimenterEquipement();
        }

        private void alimenterEquipement()
        {
            if(comboBoxCentreInfo.SelectedItem != null)
            {
                try
                {
                    listEquip = gesContrat.ChargerEquipementParCentre(((CentreInformatique)comboBoxCentreInfo.SelectedItem).NumCentre);
                }
                catch (DalExceptionAfficheMessage deaf)
                {
                    MessageBox.Show(deaf.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                listEquipByCentre = gesContrat.AfficherEquipementParCentre(listEquip);
               equipementByCentreBindingSource.DataSource = listEquipByCentre;
                

            }
        }

        private void verification()
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            montantHt = gesContrat.CalculerMontantHt(listEquipByCentre);
            textBoxMontantHt.Text = Convert.ToString(montantHt) + " euros";
            montantTtc = gesContrat.CalculerMontantTtc(montantHt);
            textBoxMontantTtc.Text = Convert.ToString(montantTtc) + " euros";
        }

        private void buttonAppliquer_Click(object sender, EventArgs e)
        {
            double result = 0.01;
            
            montantTtc = gesContrat.AppliquerRemise(Convert.ToDouble(numericUpDownRemise.Value) * result);
            textBoxMontantTtc.Text = Convert.ToString(montantTtc) + " euros";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(comboBoxCentreInfo.SelectedItem != null && comboBoxSelectionnerClient.SelectedItem != null)
            {
                int idContrat = 0;
                DateTime dateEcheance = gesContrat.CalculerDateEcheance(dateTimePickerDateValidite.Value);
                Contrat contrat = new Contrat(idContrat, (Client)comboBoxSelectionnerClient.SelectedItem,
                    (CentreInformatique)comboBoxCentreInfo.SelectedItem, montantTtc,
                    dateTimePickerDateValidite.Value,dateEcheance, textBoxCommentaire.Text);
                try
                {
                    idContrat = gesContrat.EnregistrerContrat(contrat);
                    contrat.NumeroContrat = idContrat;
                    gesContrat.AjouterEquipementAuContrat(listEquip,contrat.NumeroContrat);
                    MessageBox.Show("Le Contrat est enregistré");
                } 
                catch(DalExceptionFinAppli defa)
                {
                    MessageBox.Show(defa.Message, "Erreur applicative");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                this.Close();     
                                 
                

                 
            }
        }

        private void dataGridViewEquipement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridViewEquipement.Columns["Retirer"].Index && e.RowIndex >= 0)
            {
                string message = "Etes-vous sûr de vouloir retirer le(s) équipement(s) ?";
                string caption = "Retrait d'Equipement(s)";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    LigneEquipement lignEquip = new LigneEquipement();
                    lignEquip = (dataGridViewEquipement.Rows[e.RowIndex].DataBoundItem) as LigneEquipement;
                    listEquip = gesContrat.RetirerEquipementDuContrat(listEquip,lignEquip);
                    equipementByCentreBindingSource.Remove(lignEquip);
                    textBoxMontantHt.Clear();
                    textBoxMontantTtc.Clear();
                }
                
            }
            dataGridViewEquipement.Refresh();
        }

        //private void buttonImprimer_Click(object sender, EventArgs e)
        //{
        //    FileStream fs = new FileStream("Contrat.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
        //    Document nouveauDoc = new Document();

        //    PdfWriter writer = PdfWriter.GetInstance(nouveauDoc, fs);
        //    nouveauDoc.Open();
        //    nouveauDoc.Add(new Paragraph("Tout va bien ?"));
        //    nouveauDoc.Close();

        //    //}
        //    //catch (DocumentException de)
        //    //{
        //    //    MessageBox.Show("erreur" + de.Message);
        //    //}
        //    //catch (IOException ioe)
        //    //{
        //    //    MessageBox.Show("erreur" + ioe.Message);
        //    //}
        //    //nouveauDoc.Close();


        //}
    }
}
