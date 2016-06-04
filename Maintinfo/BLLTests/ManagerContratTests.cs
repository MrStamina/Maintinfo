using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BLL.Tests
{


    [TestClass()]
    public class ManagerContratTests
    {
        private List<Equipement> listTest;
        private List<Client> listClientTest;
        private List<Contrat> listeContratTest;
        [TestInitialize]
        public void Chargement()
        {
            listTest = new List<Equipement>();
            BO.Type type1 = new BO.Type(1, "Ordinateur portable");
            BO.Type type2 = new BO.Type(2, "Ordinateur de bureau");



            Tarif tarif1 = new Tarif(1, Convert.ToDateTime("01/01/2016"), 555);
            Tarif tarif2 = new Tarif(2, Convert.ToDateTime("01/01/2016"), 755);
            Tarif tarif3 = new Tarif(3, Convert.ToDateTime("01/01/2016"), 655);
            Tarif tarif4 = new Tarif(4, Convert.ToDateTime("01/01/2016"), 752);

            Modele mod1 = new Modele(1, "Optiplex 500", type2, tarif1);
            Modele mod2 = new Modele(2, "Optiplex 600", type2, tarif2);
            Modele mod3 = new Modele(3, "Noptiplexme", type1, tarif3);
            Modele mod4 = new Modele(4, "Noptiplexme 12500", type1, tarif4);



            List<Equipement> listEquip = new List<Equipement>()
            {
                new Equipement()
                {
                    NumeroSerie = 12456,
                    Modele = mod1,


                },
                new Equipement()
                {
                    NumeroSerie = 12457,
                    Modele = mod1,

                },
                new Equipement()
                {
                    NumeroSerie = 24457,
                    Modele = mod2,

                },
                new Equipement()
                {
                    NumeroSerie = 24458,
                    Modele = mod2,

                },
                new Equipement()
                {
                    NumeroSerie = 32457,
                    Modele = mod3,

                },
            };
            listTest = listEquip;

            List<Client> listeClient = new List<Client>()
            {
                new Client()
                {
                    NumClient = 1,
                    NomClient = "Dupont",
                    AdresseClient = "MescouilleOSky",
                    Ville = "Gap",
                    CodePostal = "05000",
                    NumTel = "0492513457"
                },
                new Client()
                {
                    NumClient = 2,
                    NomClient = "DuGland",
                    AdresseClient = "MescouilleOSky",
                    Ville = "Gap",
                    CodePostal = "05000",
                    NumTel = "0492513457"
                },
                new Client()
                {
                    NumClient = 3,
                    NomClient = "Valls",
                    AdresseClient = "MescouilleOSky",
                    Ville = "Gap",
                    CodePostal = "05000",
                    NumTel = "0492513457"
                }

            };
            listClientTest = listeClient;
            SecteurGeographique sect1 = new SecteurGeographique(1, "Sud-Ouest");
            SecteurGeographique sect2 = new SecteurGeographique(2, "Region parisienne");
            SecteurGeographique sect3 = new SecteurGeographique(3, "Sud-Est");


            CentreInformatique centre1 = new CentreInformatique(1, "dtc", "Nimes", "0494526325", listEquip, sect3);
            CentreInformatique centre2 = new CentreInformatique(2, "dtc", "Nice", "0495526325", listEquip, sect3);
            CentreInformatique centre3 = new CentreInformatique(3, "dtc", "Bordeaux", "0194526325", listEquip, sect1);
            CentreInformatique centre4 = new CentreInformatique(4, "dtc", "Paris", "0184526325", listEquip, sect2);

            List<Contrat> listContrat = new List<Contrat>()
            {
                new Contrat()
                {
                    NumeroContrat = 1,
                    Client = listeClient.First(a => a.NumClient == 1),
                    CentreInfo = centre1,
                    MontantHt = 5245

                },
                new Contrat()
                {
                    NumeroContrat = 2,
                    Client = listeClient.First(a => a.NumClient == 1),
                    CentreInfo = centre2,
                    MontantHt = 4245

                },
                new Contrat()
                {
                    NumeroContrat = 3,
                    Client = listeClient.First(a => a.NumClient == 2),
                    CentreInfo = centre3,
                    MontantHt = 6245

                },
            };
            listeContratTest = listContrat;
        }


        [TestMethod()]
        public void CalculerMontantHtTest()
        {
            double expected = 3275;
            double actual = 0;
            ManagerContrat manContrat = new ManagerContrat();
            actual = manContrat.CalculerMontantHt(listTest);
            Assert.AreEqual(expected, actual);


        }

        [TestMethod()]
        public void CalculerMontantTtcTest()
        {
            double expected = 0;
            double montantHt = 0;

            double actual = 0;
            ManagerContrat manContrat = new ManagerContrat();
            montantHt = manContrat.CalculerMontantHt(listTest);
            expected = (manContrat.CalculerMontantHt(listTest)) + (manContrat.CalculerMontantHt(listTest) * 0.2);
            actual = manContrat.CalculerMontantTtc(montantHt);
            Assert.AreEqual(expected, actual);

        }

       
    }


}