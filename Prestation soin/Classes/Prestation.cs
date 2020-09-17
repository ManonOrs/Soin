using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation_soin.Classes
{
    class Prestation
    {
        //
        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant L_Intervenant;

        //Constructeur
        public Prestation(string libelle, DateTime dateHeureSoin, Intervenant intervenant)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
            this.L_Intervenant = intervenant;

            this.L_Intervenant.ajoutePrestation(this);

        }

        //Accesseurs
        public DateTime getDateHeureSoin()
        {
            return this.dateHeureSoin;
        }

        public string getLibelle()
        {
            return this.libelle;
        }


        public Intervenant getL_Intervenant()
        {
            return this.L_Intervenant;
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateHeureSoin { get => dateHeureSoin; set => dateHeureSoin = value; }
        internal Intervenant L_Intervenant1 { get => L_Intervenant; set => L_Intervenant = value; }


        //Methodes
        public int compareTo(Prestation unePrestation)
        {
            if (this.dateHeureSoin == unePrestation.getDateHeureSoin())
            {
                return 0;
            }
            else if (this.dateHeureSoin > unePrestation.getDateHeureSoin())
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
    }
}
