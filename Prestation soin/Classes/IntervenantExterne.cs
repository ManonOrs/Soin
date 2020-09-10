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

        public IntervenantExterne(string specialite, string adresse, string tel, string nom, string prenom)
            :base(nom,prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        public string getSpecialite { get => specialite; }
        public string getAdresse { get => adresse; }
        public string getTel { get => tel; }
    }
}
