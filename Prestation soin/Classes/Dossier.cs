﻿using System;
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

        //Accesseurs

        //Méthodes
        public void ajoutePrestation(string unLibelle, DateTime uneDate, DateTime uneHeure, Intervenant unIntervenant)
        {
            mesPrestation.Add(new Prestation(unLibelle, uneDate, uneHeure, unIntervenant));
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

        public int getNbJoursSoins()
        {
            int cpt = 1;
            Prestation unePrestation;
            if(this.mesPrestation.Count() == 0)
            {
                return 0;
            }

            unePrestation = this.mesPrestation[1];
            foreach(var maPrestation in mesPrestation)
            {
                cpt = cpt + maPrestation.compareTo(unePrestation);
                unePrestation = maPrestation;
            }

            return cpt;
        }

        public void afficheDossier()
        {
            Console.WriteLine("yo");
        }

    }
}
