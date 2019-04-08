using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    /// <summary>
    /// Personnage du jeu
    /// </summary>
    public abstract class Personnage
    {
        #region Fields
        /// <summary>
        /// Minimum des points de vie
        /// </summary>
        public static int MinPointsDeVie = 0;

        /// <summary>
        /// Maximum des points de vie
        /// </summary>
        public static int MaxPointsDeVie = 100;
        #endregion

        #region Properties
        /// <summary>
        /// Nom du personnage
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Points de vie du personnage
        /// </summary>
        public int PointsDeVie { get; set; }

        /// <summary>
        /// Indique si le personnage est encore en vie
        /// </summary>
        public bool EstEnVie { get => this.PointsDeVie > Personnage.MinPointsDeVie; }
        #endregion
    }
}
