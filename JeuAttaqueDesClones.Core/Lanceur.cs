using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Core
{
    /// <summary>
    /// Lanceur du jeu
    /// </summary>
    public class Lanceur
    {
        #region Public methods
        public void Lancer(MoteurDuJeu moteur)
        {
            moteur.Demarrer();
        }
        #endregion
    }
}
