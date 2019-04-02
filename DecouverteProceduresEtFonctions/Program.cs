using System;

namespace DecouverteProceduresEtFonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Saisissez une valeur ?");
            //string maValeur = Console.ReadLine();

            var valeur = RenvoyerSaisieUtilisateur();

            //valeur = 1; pas possible, car deja interprété comme string

            string valeur2 = RenvoyerSaisieUtilisateur();
            string valeur3 = RenvoyerSaisieUtilisateur();

            string valeur4 = "";
            GererSaisieUtilisateurAvecOut(out valeur4);
            GererSaisieUtilisateurAvecRef(ref valeur4);
        }

        static string RenvoyerSaisieUtilisateur()
        {
            Console.WriteLine("Saisissez une valeur ?");
            return Console.ReadLine();
        }

        static void GererSaisieUtilisateurAvecOut(out string retour)
        {
            Console.WriteLine("Saisissez une valeur ?");
            // si commentaire de la ligne, ça build plus
            retour = Console.ReadLine();


        }

        static void GererSaisieUtilisateurAvecRef(ref string retour)
        {
            Console.WriteLine("Saisissez une valeur ?");
            //retour = Console.ReadLine();


        }
    }
}
