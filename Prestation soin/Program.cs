using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestation_soin
{
    class Program
    {

        public static void creaDossier()
        {
            DateTime date1 = new DateTime(2000, 8, 21);
            Classes.Dossier dossier1 = new Classes.Dossier("Gabriel", "Delage", date1);

            dossier1.afficheDossier();
        }

        static void Main(string[] args)
        {
            creaDossier();
        }
    }
}
