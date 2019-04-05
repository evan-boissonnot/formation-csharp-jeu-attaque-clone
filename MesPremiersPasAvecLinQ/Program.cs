using System;
using System.Collections.Generic;
using System.Linq;

namespace MesPremiersPasAvecLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Jedi> jediList = new List<Jedi>()
            {
                new Jedi() { BirthDay = DateTime.Now, FirstName = "Luke", LastName = "Skywalker", LifePoint = 100 },
                new Jedi() { BirthDay = DateTime.Now.AddDays(-1), FirstName = "Anakin", LastName = "Skywalker", LifePoint = 100 },
                new Jedi() { BirthDay = DateTime.Now.AddDays(-1), FirstName = "Leia", LastName = "Skywalker", Sexe = 1, LifePoint = 100 },
                new Jedi() { BirthDay = DateTime.Now.AddYears(-200), FirstName = "Chewie", LastName = "", LifePoint = 100 },
                new Jedi() { BirthDay = DateTime.Now.AddYears(-800), FirstName = "Yoda", LastName = "", LifePoint = 200 },
                new Jedi() { BirthDay = DateTime.Now, FirstName = "Asoka", LastName = "Skywalker", Sexe = 1, LifePoint = 100 },
                new Jedi() { BirthDay = DateTime.Now.AddYears(-100), FirstName = "QuiGon", LastName = "Jin", LifePoint = 100 },
                new Jedi() { BirthDay = DateTime.Now.AddYears(-80), FirstName = "Mass", LastName = "Windu", LifePoint = 150 },
            };

            var requete = from item in jediList
                          where item.EstUneFemme
                          select item;

            int resultat = requete.Count();

            var requete2 = from item in jediList
                           where item.Age >= 80
                           select item;

            foreach (var item in requete2)
            {
                Console.WriteLine(item.FirstName + " " + item.Age);
            }

            var requete3 = from item in jediList
                           where item.Age >= 80
                           select new
                           {
                               MonAge = item.Age,
                               NomPrenom = item.FirstName + " " + item.LastName,
                               ComptageJour = item.BirthDay.Day + 18
                           };

            foreach (var item in requete3)
            {
                Console.WriteLine(item.NomPrenom + " " + item.MonAge);
            }

            // identique à la requete 2
            var list = jediList.Where(item => item.Age >= 80);//.Select(item => new { coucou = 1 });
            foreach (var item in list)
            {
                Console.WriteLine(item.FirstName + " " + item.Age);
            }
        }
    }
}
