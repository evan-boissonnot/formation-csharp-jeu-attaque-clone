using System;

namespace JeuAttaqueDesClones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu !");
            PreparationDuJoueur();
            SeDeplacer();
        }

        #region Autour du joueur
        static void PreparationDuJoueur()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======== INITIALISATION DU JOUEUR ======");

            string nom = "";
            string prenom = "";
            string surnom = "";
            int age = 0;

            nom = AfficherInfoEtDemandeSaisie("Votre nom, s'il vous plaît");
            prenom = AfficherInfoEtDemandeSaisie("Votre prénom, s'il vous plaît");
            surnom = AfficherInfoEtDemandeSaisie("Votre surnom, s'il vous plaît");
            age = AfficherInformationEtDemandeSaisieEntier("Votre âge s'il vous plaît ?");

            ControleSaisieAge(age);

            Console.ForegroundColor = ConsoleColor.White;

            //AfficherLesInformationsUtilisateur(nom, prenom, surnom, age);
            AfficherLesInformationsUtilisateur(ageP: age, prenomP: prenom, nomP: nom, surnomP: surnom);
        }

        static void ControleSaisieAge(int age)
        {
            if (age < 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Attention, tu n'as pas l'âge requis !");

                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        // on a des paramètres optionnels
        static void AfficherLesInformationsUtilisateur(string nomP = "", string prenomP = "",
                                                       string surnomP = "", int ageP = 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            string message = $"Hey { ToUpperFirstCharacter(prenomP) }, { ToUpperFirstCharacter(nomP) }, ton surnom est {surnomP.ToUpper()}. Tu as {ageP} ans";
            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion

        #region Autour saisie
        static string ToUpperFirstCharacter(string valeur)
        {
            return valeur[0].ToString().ToUpper() + valeur.Substring(1).ToLower();
        }

        static int AfficherInformationEtDemandeSaisieEntier(string message)
        {
            string value = AfficherInfoEtDemandeSaisie(message);

            return int.Parse(value);
        }

        static string AfficherInfoEtDemandeSaisie(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        #endregion

        static void SeDeplacer()
        {
            int x = RetournerCoordonnee();
            int y = RetournerCoordonnee();

            MiseAJourCoordonnees(ref x);
            MiseAJourCoordonnees(ref y);

            AfficheCoordonnee(x);
            AfficheCoordonnee(y);
        }

        #region Autour des coordonnees
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

            while(saisieFausse)
            {
                Console.WriteLine("Saisir une coordonnée");
                string valeur = Console.ReadLine();

                saisieFausse = ! int.TryParse(valeur, out coordonnee);
            }

            return coordonnee;

           
        }
        #endregion
    }
}
