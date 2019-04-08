using JeuAttaqueDesClones.Core;
using JeuAttaqueDesClones.Models;
using System;

namespace JeuAttaqueDesClones
{
    class Program2
    {
        #region Internal methods
        static void Main(string[] args)
        {
            Lanceur lanceur = new Lanceur();

            //Permet de changer de moteur, si on le souhaite
            //De plus, ici, on passe les méthodes d'affichage, et de lecture, pour être découplé avec la Console
            lanceur.Lancer(new MoteurDuJeu(Console.WriteLine, Console.ReadLine, Console.Write));
        }
        #endregion
    }
}
