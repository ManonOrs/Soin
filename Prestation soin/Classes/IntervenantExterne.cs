using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation_soin.Classes
{
    class IntervenantExterne :Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            :base(nom,prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        public string getSpecialite { get => specialite; }
        public string getAdresse { get => adresse; }
        public string getTel { get => tel; }

        public override void AfficheIntervenantComplet()
        {
            Console.WriteLine("Nom: " + base.getNom + " Prenom: " + base.getPrenom + " Specialite: "+ this.getSpecialite + " Adresse: "+ this.getAdresse + " Telephone: "+this.getTel+ "\n");
        }
    }
}
