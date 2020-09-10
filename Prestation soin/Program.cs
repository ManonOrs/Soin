using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestation_soin.Classes;

namespace Prestation_soin
{
    class Program
    {

        //public static void creaDossier()
        //{
        //    DateTime date1 = new DateTime(2000, 8, 21);
        //    Dossier dossier1 = new Dossier("Gabriel", "Delage", date1);

        //    dossier1.afficheDossier();
        //}

        public static void fermerProgramme()
        {
            Console.Write("Voullez-vous fermer le programme? Ecrire oui ou non.");
            string qst = Console.ReadLine();

            if(qst == "oui" || qst == "Oui")
            {
                Environment.Exit(0);
            }
            else if(qst == "non" || qst == "Non")
            {
                Console.WriteLine("L'application ne s'est pas fermer.");
            }
            else{
                Console.WriteLine("Veuillez repondre par oui ou non. ");
            }
        }

        static void Main(string[] args)
        {
            Intervenant intervenant1 = new Intervenant("Jean", "Didier");
            IntervenantExterne intervenant2 = new IntervenantExterne("Cardiologue", "Marseille", "06 98 45 21 23", "Vincent", "Frasel");

            DateTime date1 = new DateTime(2000, 8, 21);
            DateTime date2 = new DateTime(2015, 7, 15);
            DateTime date3 = new DateTime(2020, 11, 3);

            Dossier dossier1 = new Dossier("Gabriel", "Delage");
            dossier1.ajoutePrestation("P1", date2, intervenant1);
            dossier1.ajoutePrestation("P2", date3, intervenant2);

            


            dossier1.afficheDossier();
            //fermerProgramme();
            Console.ReadKey();
        }
    }
}
