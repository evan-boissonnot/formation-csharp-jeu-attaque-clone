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
        public static int MON_POINTS_DE_VIE = 0;

        /// <summary>
        /// Maximum des points de vie
        /// </summary>
        public static int MAX_POINTS_DE_VIE = 100;
        #endregion

        #region Properties
        /// <summary>
        /// Position courant du personnage dans le jeu
        /// </summary>
        public Position PositionCourante { get; set; } = new Position();

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
        public bool EstEnVie { get => this.PointsDeVie > Personnage.MON_POINTS_DE_VIE; }
        #endregion
    }
}
