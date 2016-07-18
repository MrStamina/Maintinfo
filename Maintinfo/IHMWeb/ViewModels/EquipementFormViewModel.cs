using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;

namespace IHMWeb.ViewModels
{
    public class EquipementFormViewModel
    {
        public int? Id { get; set; }

        public int? Quantite { get; set; }
        public int ModeleId { get; set; }

        public int CentreInformatiqueId { get; set; }

        public int? ContratId { get; set; }

        public IEnumerable<Modele> Modeles { get; set; }

        public IEnumerable<Equipement> Equipements { get; set; }

        public List<LigneEquipement> LigneEquipements { get; set; }

       

        public EquipementFormViewModel()
        {
            Id = 0;
        }

        public EquipementFormViewModel(Equipement equip)
        {
            Id = equip.Id;
            CentreInformatiqueId = equip.CentreInformatiqueId;
            ModeleId = equip.ModeleId;

        }
    }
}