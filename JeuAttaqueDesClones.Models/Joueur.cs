using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class Joueur
    {
        #region Fields
        private Personnage _personnage = null;
        #endregion

        #region Public methods
        /// <summary>
        /// Initialise la propriété MonPersonnage
        /// </summary>
        /// <param name="estGentil"></param>
        public Personnage InitialiserPersonnage(bool estGentil = true)
        {
            if (estGentil)
                this._personnage = new Clone();
            else
                this._personnage = new Robot();

            return this._personnage;
        }

        /// <summary>
        /// Réinitalise le joueur
        /// </summary>
        public void Reinitialiser()
        {
            this.MonPersonnage.Reinitialiser();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Personnage du joueur
        /// </summary>
        public Personnage MonPersonnage { get { return this._personnage; } }

        /// <summary>
        /// Nom du joueur
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du joueur
        /// </summary>
        public string Prenom { get; set; }
        #endregion
    }
}
