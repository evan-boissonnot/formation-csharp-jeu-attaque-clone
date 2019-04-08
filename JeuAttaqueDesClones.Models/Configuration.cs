using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class Configuration
    {
        #region Fields
        /// <summary>
        /// Taille X maximal du tableau de jeu
        /// </summary>
        public const int MAX_X = 30;

        /// <summary>
        /// Taille Y maximal du tableau de jeu
        /// </summary>
        public const int MAX_Y = 30;

        /// <summary>
        /// Nombre max de combattants
        /// </summary>
        public const int NB_ATTAQUANTS = 30;

        /// <summary>
        /// Indique s'il y a des attaquants
        /// </summary>
        public const bool EstAvecAttaquants = true;
        #endregion
    }
}
