using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
    public class ManagerEquipement
    {
        private MaintinfoContext _context;
        private UnitOfWork unitOfWork;
        

        public ManagerEquipement()
        {
            _context = new MaintinfoContext();
            unitOfWork = new UnitOfWork(_context);
          
        }

        public void AddEquipement(Equipement equipement)
        {
            unitOfWork.Equipements.Add(equipement);
           
        }

        public void AddRangeEquipement(IEnumerable<Equipement> equipements)
        {
            unitOfWork.Equipements.AddRange(equipements);
        }

        public int ValiderChangement()
        {
            return unitOfWork.Complete();
        }

        public void AddEquipementToContrat(int idCentre, int idContrat)
        {

            var query = unitOfWork.Equipements.GetEquipementByCentre(idCentre);
            foreach (var VARIABLE in query)
            {
                VARIABLE.ContratId = idContrat;
            }
            unitOfWork.Complete();

        }

        public void AddSomeEquipementToContrat(IEnumerable<Equipement> lesEquipements, int idCentre, int idContrat)
        {
           
            
            foreach (var VARIABLE in lesEquipements)
            {
               Equipement equipinDb = unitOfWork.Equipements.Get(VARIABLE.Id);

                equipinDb.ContratId = idContrat;

            }
            unitOfWork.Complete();
        }

        public List<LigneEquipement> RetirerEquipements(List<LigneEquipement>lesEquipements,string modele, int idCentre)
        {

            lesEquipements.RemoveAll(x => x.Libelle == modele);
            return lesEquipements;
        }

        public IEnumerable<Equipement> GetEquipementsByCentre(int idCentre)
        {
            return unitOfWork.Equipements.GetEquipementByCentre(idCentre);
        }

        public List<LigneEquipement> AfficherEquipements(int idCentre)
        {
            List<Equipement> lesEquipements = unitOfWork.Equipements.GetEquipementByCentre(idCentre).ToList();
            var modeles = unitOfWork.Modeles.GetAll();
            List<Equipement> listTriage;
            int quantite;
            string libelle;
            decimal tarif;
            List<LigneEquipement> lesLigneEquipements = new List<LigneEquipement>();
            
            for (int i = 1; i <= modeles.Count(); i++)
            {
                listTriage = new List<Equipement>();
                listTriage = lesEquipements.FindAll(x => x.Modele.Id == i);
                quantite = listTriage.Count;
                if (quantite != 0)
                {
                    Equipement equip = listTriage.First();
                    libelle = equip.Modele.Libelle;
                    tarif = (equip.Modele.Tarif.TarifModele)*quantite;
                    LigneEquipement ligneEquipement = new LigneEquipement
                    {
                        Quantite = quantite,
                        Libelle = libelle,
                        Montant = tarif,
                    };
                    lesLigneEquipements.Add(ligneEquipement);
                }

            }
            return lesLigneEquipements;
        }
    }
}
