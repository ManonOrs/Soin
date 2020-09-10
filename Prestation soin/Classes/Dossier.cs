using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation_soin.Classes
{
    class Dossier
    {
        //
        private string nomPatient;
        private string prenomPatient;
        private DateTime dateNaissancePatient;
        private List<Prestation> mesPrestation;

        //Constructeur
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissancePatient = dateNaissancePatient;
            this.mesPrestation = new List<Prestation>();
        }

        public Dossier(string nomPatient, string prenomPatient)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissancePatient = new DateTime(2000,08,21);
            this.mesPrestation = new List<Prestation>();
        }

        //Accesseurs

        //Méthodes
        public void ajoutePrestation(string unLibelle, DateTime uneDateHeure, Intervenant unIntervenant)
        {
            mesPrestation.Add(new Prestation(unLibelle, uneDateHeure, unIntervenant));
        }

        public int getNbPrestationsExternes()
        {
            int cpt = 0;
            foreach(Prestation prest in mesPrestation)
            {
                if(prest.getL_Intervenant().GetType().Name == "IntervenantExterne")
                {
                    cpt = cpt + 1;
                }
            }
            return cpt;
        }

        //public int getNbJoursSoins()
        //{
        //    int cpt = 1;
        //    Prestation unePrestation;
        //    if(this.mesPrestation.Count() == 0)
        //    {
        //        return 0;
        //    }

        //    unePrestation = this.mesPrestation[1];
        //    foreach(var maPrestation in mesPrestation)
        //    {
        //        cpt = cpt + maPrestation.compareTo(unePrestation);
        //        unePrestation = maPrestation;
        //    }

        //    return cpt;
        //}

        public int getNbJoursSoins()
        {
            return this.mesPrestation.Select(x => x.getDateHeureSoin().Date).Distinct().Count();
        }

        public void afficheDossier()
        {
            Console.WriteLine("----- Début dossier -----");
            Console.WriteLine("Nom: " + this.nomPatient + "   Prenom: " + prenomPatient + "   Date de naissance: " + this.dateNaissancePatient.ToString("dd/MM/yyyy"));
            foreach(Prestation prest in mesPrestation)
            {
                Console.WriteLine("   Libelle " + prest.getLibelle() + " - " + prest.getDateHeureSoin() +  " - Intervenant: " + prest.getL_Intervenant().getNom + " - " + prest.getL_Intervenant().getPrenom);
            }
            Console.WriteLine("---- Fin dossier -----");
            Console.WriteLine("Nombre de jours de soins: " + this.getNbJoursSoins());
            Console.WriteLine("Nombres de soins externes: " + this.getNbPrestationsExternes());
        }

    }
}
