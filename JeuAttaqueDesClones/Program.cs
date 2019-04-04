using System;

namespace JeuAttaqueDesClones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur le jeu !");

            ChoixMenu menu = ChoixMenu.Quitter;
            do
            {
                AfficherMenuDuJeu();
                menu = LancerChoixUtilisateur();
            } while (menu != ChoixMenu.Quitter);
        }

        #region Autour du menu
        static ChoixMenu LancerChoixUtilisateur()
        {
            string choix = Console.ReadLine();
            ChoixMenu menuEnCours = ConvertirStringToChoixMenu(choix);
            //ultra générique : ChoixMenu me = ConvertirStringToEnum<ChoixMenu>(choix);

            switch (menuEnCours)
            {
                case ChoixMenu.Quitter:
                    break;
                case ChoixMenu.SaisieUtilisateur:
                    PreparationDuJoueur(); break;
                case ChoixMenu.GestionDeplacement:
                    SeDeplacer(); break;
                default:
                    break;
            }

            return menuEnCours;
        }

        static ChoixMenu ConvertirStringToChoixMenu(string value)
        {
            return (ChoixMenu)Enum.Parse(typeof(ChoixMenu), value);
        }

        static T ConvertirStringToEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        static void AfficherMenuDuJeu()
        {
            string[] choixEnChaine = Enum.GetNames(typeof(ChoixMenu));

            for (int i = 0; i < choixEnChaine.Length; i++)
            {
                ChoixMenu menuEnCours = ConvertirStringToChoixMenu(choixEnChaine[i]);

                string formatAAfficher = string.Format("{0} : {1}", (int)menuEnCours, choixEnChaine[i]);
                Console.WriteLine(formatAAfficher);
            }
        }
        #endregion

        #region Autour du joueur
        static void PreparationDuJoueur()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======== INITIALISATION DU JOUEUR ======");

            string nom = "";
            string prenom = "";
            string surnom = "";
            string dateDeNaissance = "";

            nom = AfficherInfoEtDemandeSaisie("Votre nom, s'il vous plaît");
            prenom = AfficherInfoEtDemandeSaisie("Votre prénom, s'il vous plaît");
            surnom = AfficherInfoEtDemandeSaisie("Votre surnom, s'il vous plaît");
            dateDeNaissance = AfficherInfoEtDemandeSaisie("Votre date de naissance s'il vous plaît ?");

            int age = ControleSaisieAge(dateDeNaissance);

            Console.ForegroundColor = ConsoleColor.White;

            AfficherLesInformationsUtilisateur(ageP: age, prenomP: prenom, nomP: nom, surnomP: surnom);
        }

        static int ControleSaisieAge(string dateDeNaissance)
        {
            int age = 0;

            DateTime date = DateTime.Parse(dateDeNaissance);
            DateTime dateDuJour = DateTime.Now;

            TimeSpan timeSpan = dateDuJour - date;
            age = (int)(timeSpan.Days / 365.125M);

            if (age < 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Attention, tu n'as pas l'âge requis !");

                Console.ForegroundColor = ConsoleColor.White;
            }

            return age;
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

            while (saisieFausse)
            {
                Console.WriteLine("Saisir une coordonnée");
                string valeur = Console.ReadLine();

                saisieFausse = !int.TryParse(valeur, out coordonnee);
            }

            return coordonnee;


        }
        #endregion
    }
}
