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
        private static Random _RANDOM = new Random();
        public static int _MAX_X = 50;
        public static int _MAX_Y = 50;

        /// <summary>
        /// Minimum des points de vie
        /// </summary>
        public static int MON_POINTS_DE_VIE = 0;

        /// <summary>
        /// Maximum des points de vie
        /// </summary>
        public static int MAX_POINTS_DE_VIE = 100;
        #endregion

        #region Constructors
        #endregion

        #region Public methods
        public static bool operator !=(Personnage personnage, Personnage personnage2)
        {
            return ! personnage.Equals(personnage2);
        }

        public static bool operator ==(Personnage personnage, Personnage personnage2)
        {
            return personnage.Equals(personnage2);
        }

        public void SeDeplacer()
        {
            if(this.EstEnVie)
            {
                this.PositionCourante.X = Personnage._RANDOM.Next(0, _MAX_X + 1);
                this.PositionCourante.Y = Personnage._RANDOM.Next(0, _MAX_Y + 1);
            }
        }

        public void Attaquer(Personnage personnage)
        {
            if(this != personnage)
            {
                throw new NotImplementedException();
            }
        }

        public override bool Equals(object obj)
        {
            bool estEgal = false;
            Personnage autrePersonnage = obj as Personnage;

            if (autrePersonnage != null)
            {
                estEgal = autrePersonnage.GetType() == this.GetType() &&
                          autrePersonnage.Nom == this.Nom;
            }

            return estEgal;
        }
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
        public int PointsDeVie { get; set; } = Personnage.MAX_POINTS_DE_VIE;

        /// <summary>
        /// Indique si le personnage est encore en vie
        /// </summary>
        public bool EstEnVie { get => this.PointsDeVie > Personnage.MON_POINTS_DE_VIE; }
        #endregion
    }
}
