using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation_soin.Classes
{
    class Intervenant
    {
        //
        private string nom;
        private string prenom;
        private List<Prestation> lesPrestation;

        //constructeur
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.lesPrestation = new List<Prestation>();
        }

        //Accesseurs
        public string getNom { get => nom; }
        public string getPrenom { get => prenom; }

        //Méthodes
        public void ajoutePrestation(Prestation unePrestation)
        {
            lesPrestation.Add(unePrestation);
        }

    }
}
