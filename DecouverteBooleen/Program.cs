using System;

namespace DecouverteBooleen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool monBoolean = false;

            Console.WriteLine(monBoolean);

            monBoolean = true && false;
            monBoolean = true || false;

            string valeurSaisie = Console.ReadLine();

            if(valeurSaisie == "coucou" || valeurSaisie == "hello")
            {
                Console.WriteLine("Ca va bien ?");
            }
            

            Console.WriteLine(monBoolean);


            bool? booleenATroisValeurs = null;

            if(booleenATroisValeurs.HasValue)
            {
                bool vraiValeur = booleenATroisValeurs.Value;
            }


            // 0 => Homme, 1 => Femme
            // Coder la demande du sexe à l'utilisateur
            // Vérifier s'il a bien saisi une valeur
            // Tant qu'il n'a pas saisi une valeur, redemandez

            bool essai = bool.TryParse(Console.ReadLine(), out bool resultat);

            if(essai)
            {
                Console.WriteLine("Bravo, vous avez saisi la bonne valeur : " + resultat);
            }


        }
    }
}
