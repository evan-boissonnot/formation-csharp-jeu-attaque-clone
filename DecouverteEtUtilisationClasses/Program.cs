using System;
using System.Collections.Generic;
using ZooJedi;

namespace DecouverteEtUtilisationClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ZooJedi.Lion lion = new ZooJedi.Lion(DateTime.Now, "Simba")
            {
                ADesOreilles = true
            };

            ZooJedi.Lion lion2 = new ZooJedi.Lion(DateTime.Now.AddDays(-1), "Nala")
            {
                ADesOreilles = false
            };

            Console.WriteLine($"{lion.GetNombreDePattes()}");
            Console.WriteLine($"{lion2.GetDateDeNaissance()}");

            lion.SetTaille(12);
            lion.MaTaille = 12;

            Console.WriteLine(lion.MaTaille);

            /////////
            Mammouth mammouth = new Mammouth(DateTime.Now, "Manny");
            Console.WriteLine(mammouth.GetNom());

            Chien chien = new Chien(DateTime.Now, "Volt");
            Console.WriteLine(chien.GetNom());

            // soLid : Liskov
            Animal a1 = new Mammouth(DateTime.Now, "Manny");
            Animal a2 = new Chien(DateTime.Now, "Volt");


            Console.WriteLine(a1.GetNom());
            Console.WriteLine(a2.GetNom());

            a1.Dormir();
            a2.Dormir();

            //
            //int nb = (a1 as Mammouth).NbDefenses;


            List<Animal> list = new List<Animal>()
            {
                new Mammouth(DateTime.Now, "Many"),
                new Chien(DateTime.Now, "Volt"),
                new Mammouth(DateTime.Now, "Many2"),
                new Chien(DateTime.Now, "Pluto")
            };

            foreach (var item in list)
            {
                item.Dormir();
            }


            // Exemple interet static =>  singleton

            Singleton single = Singleton.Instance;
            Singleton single2 = Singleton.Instance;

        }
    }
}
