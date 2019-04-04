using System;
using ZooJedi;
using System.Linq;
using System.Collections.Generic;

namespace DecouverteTableauEtListEtDictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //#region Les tableaux
            //int[] monTableauEntiers = new int[5];

            //for (int i = 0; i < monTableauEntiers.Length; i++)
            //{
            //    Console.WriteLine(monTableauEntiers[i]);
            //}

            //for (int i = 0; i < monTableauEntiers.Length; i++)
            //{
            //    monTableauEntiers[i] = i;
            //    Console.WriteLine(monTableauEntiers[i]);
            //}

            //int somme = monTableauEntiers.Sum();

            //int[] secondTableauEntier = { 1, 2, 90 };


            //string[][] tableauDeTableau = new string[2][];
            //tableauDeTableau[0] = new string[3];
            //string valeur = tableauDeTableau[0][1];


            //int[,] tableauADeuxDimensions = new int[2, 3];
            //int premiereLigneDerniereColonne = tableauADeuxDimensions[0, 2];

            //// Array., pour faire des traitements indépendemment du type de tableau (en plus de LINQ)

            //string[] tableauChaine = new string[3];
            //for (int i = 0; i < tableauChaine.Length; i++)
            //{
            //    Console.WriteLine("'" + tableauChaine[i] + "'");
            //}

            //Lion[] lions = new Lion[4];
            //for (int i = 0; i < lions.Length; i++)
            //{
            //    Console.WriteLine("'" + lions[i] + "'");
            //}

            //for (int i = 0; i < lions.Length; i++)
            //{
            //    lions[i] = new Lion(DateTime.Now.AddDays(-i), "lion" + i);
            //    Console.WriteLine("'" + lions[i].GetNom() + "' : " + lions[i].GetDateDeNaissance());
            //}

            //#endregion

            #region Les listes
            List<int> list = new List<int>(3);
            int[] tab = new int[3];

            list.Add(18);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<int> listEntiers2 = new List<int>
            {
                2,
                3,
                8
            };

            listEntiers2.Remove(8);
            #endregion

            #region Dictionnaires
            Dictionary<string, string> dico = new Dictionary<string, string>();

            dico.Add("NOIR", "SOLEIL");
            dico.Add("ROUGE", "BALEINE");
            dico.Add("BLANC", "CHOCOLAT");
            //dico.Add("BLANC", "CHOCOLAT3");

            string valeurDico = dico["BLANC"];

            foreach (var item in dico)
            {
                Console.WriteLine(item.Key + " "+ item.Value);
            }
            #endregion

        }
    }
}
