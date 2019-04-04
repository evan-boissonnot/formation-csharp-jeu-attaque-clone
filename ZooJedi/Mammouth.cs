using System;
using System.Collections.Generic;
using System.Text;

namespace ZooJedi
{
    /// <summary>
    /// Classe représentant un ancien pachyderme
    /// </summary>
    public class Mammouth : Animal
    {
        public Mammouth(DateTime dateDeNaissance, string nom) : base(dateDeNaissance, nom)
        {
        }

        public override void Dormir()
        {
            Console.WriteLine("Je dors debout, moi " + this.GetNom());
        }

        private int _nbDefenses = 2;
        public int NbDefenses { get { return this._nbDefenses; } }


    }
}
