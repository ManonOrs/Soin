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
        private DateTime dateSoin;
        private DateTime heureSoin;
        private Intervenant L_Intervenant;

        //Constructeur
        public Prestation(string libelle, DateTime dateSoin, DateTime heureSoin, Intervenant intervenant)
        {
            this.libelle = libelle;
            this.dateSoin = dateSoin;
            this.heureSoin = heureSoin;
            this.L_Intervenant = intervenant;

            this.L_Intervenant.ajoutePrestation(this);

        }

        //Accesseurs
        public DateTime getDateSoin()
        {
            return this.dateSoin;
        }

        public DateTime getHeureSoin()
        {
            return this.heureSoin;
        }

        public Intervenant getL_Intervenant()
        {
            return this.L_Intervenant;
        }

        //Methodes
        public int compareTo(Prestation unePrestation)
        {
            if (this.dateSoin == unePrestation.getDateSoin())
            {
                return 0;
            }
            else if (this.dateSoin > unePrestation.getDateSoin())
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
