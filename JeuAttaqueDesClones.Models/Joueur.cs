using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class Joueur
    {
        private Personnage _personnage;

        /// <summary>
        /// Initialise la propriété MonPersonnage
        /// </summary>
        /// <param name="estGentil"></param>
        public void InitialiserPersonnage(bool estGentil = true)
        {
            if (estGentil)
                this._personnage = new Clone();
            else
                this._personnage = new Robot();
        }

        public Personnage MonPersonnage { get { return this._personnage; } }
    }
}
