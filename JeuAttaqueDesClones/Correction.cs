using System;

namespace JeuAttaqueDesClones
{
    class Correction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu !");
            SeDeplacer();
        }

        static void SeDeplacer()
        {
            int x = RetournerCoordonnee();
            int y = RetournerCoordonnee();

            MiseAJourCoordonnees(ref x);
            MiseAJourCoordonnees(ref y);

            AfficheCoordonnee(x);
            AfficheCoordonnee(y);
        }

        static void MiseAJourCoordonnees(ref int valeur)
        {
            valeur = valeur + 2;
        }

        static void AfficheCoordonnee(int valeur)
        {
            Console.WriteLine(valeur);
        }

        static int RetournerCoordonnee()
        {
            bool saisieFausse = false;
            int coordonnee = 0;

            while (saisieFausse)
            {
                Console.WriteLine("Saisir une coordonnée");
                string valeur = Console.ReadLine();

                saisieFausse = !int.TryParse(valeur, out coordonnee);
            }

            return coordonnee;
        }
    }
}
