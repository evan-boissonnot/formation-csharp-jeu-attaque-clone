using System;
using System.Collections.Generic;

namespace ViveLesEvenements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Chef chef = new Chef();
            List<PersonneQuiLit> lecteurs = new List<PersonneQuiLit>()
            {
                new PersonneQuiLit(),
                new PersonneQuiLit(),
                new PersonneQuiLit()
            };

            PersonneQuiProduit producteur = new PersonneQuiProduit();

            producteur.RapportFini += chef.TraiterRapport;
            foreach (var item in lecteurs)
            {
                producteur.RapportFini += item.LireRapport;
            }

            producteur.ProduireRapport();
        }
    }
}
