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
        /// <summary>
        /// Relance tous les paramètres du début de jeu
        /// </summary>
        public void Reinitialiser()
        {
            this.PointsDeVie = Personnage.MAX_POINTS_DE_VIE;
            this.SeDeplacerAuHasard();
        }

        /// <summary>
        /// Déplace le personnage selon une direction
        /// </summary>
        public void SeDeplacer(Direction direction)
        {
            int x = 0; int y = 0;

            switch (direction)
            {
                case Direction.Haut: x = -1; break;
                case Direction.Bas: x = 1; break;
                case Direction.Droite: y = 1; break;
                case Direction.Gauche: y = -1; break;
                default: break;
            }

            this.PositionCourante.Deplacer(x, y);
        }

        /// <summary>
        /// Lance un déplacement eu hasard
        /// </summary>
        public void SeDeplacerAuHasard()
        {
            if (this.EstEnVie)
            {
                this.PositionCourante.SeDeplacerAuHasard();
            }
        }

        /// <summary>
        /// Lance un déplacement eu hasard
        /// </summary>
        public void SInitialiserAuHasard()
        {
            if (this.EstEnVie)
            {
                this.PositionCourante.SInitialiserAuHasard();
            }
        }

        /// <summary>
        /// Lance une attaque jusqu'à la mort de l'un des deux personnages (Death match !)
        /// </summary>
        public void Tuer(Personnage personnage)
        {
            if (this != personnage && this.EstEnVie && personnage.EstEnVie)
            {
                while (this.EstEnVie && personnage.EstEnVie)
                {
                    this.AttaquerUneFois(personnage);
                    personnage.AttaquerUneFois(this);
                }
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

        /// <summary>
        /// Vérifie si les deux personnages sont sur la même position
        /// </summary>
        /// <returns></returns>
        public bool VerifierMemePosition(Personnage personne)
        {
            bool memePosition = false;

            if (!this.Equals(personne))
            {
                memePosition = this.PositionCourante == personne.PositionCourante;
            }

            return memePosition;
        }

        /// <summary>
        /// Vérifie si même position qu'une position donnée
        /// </summary>
        /// <returns></returns>
        public bool VerifierMemePosition(Position position)
        {
            return this.PositionCourante == position;
        }
        #endregion

        #region Internal methods
        private void AttaquerUneFois(Personnage defenseur)
        {
            if (defenseur.EstEnVie)
            {
                int pointsAEnlever = Personnage._RANDOM.Next(0, Personnage.MAX_POINTS_DE_VIE / 2);

                defenseur.PointsDeVie -= pointsAEnlever;
            }
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
