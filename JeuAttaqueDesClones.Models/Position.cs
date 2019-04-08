using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class Position
    {
        #region Fields
        private static Random _RANDOM = new Random();
        #endregion

        #region Constructors
        public Position() { }

        public Position(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Déplace une position
        /// </summary>
        public void Deplacer(int x, int y)
        {
            x = this.X + x;
            y = this.Y + y;

            this.VerifierCoordonnee(ref x, Configuration.MAX_X);
            this.VerifierCoordonnee(ref y, Configuration.MAX_Y);

            this.X = x;
            this.Y = y;
        }

        public void SeDeplacerAuHasard()
        {
            int x = Position._RANDOM.Next(0, Configuration.MAX_X + 1);
            int y = Position._RANDOM.Next(0, Configuration.MAX_Y + 1);

            this.Deplacer(x, y);
        }

        public static bool operator ==(Position position1, Position position2)
        {
            return 
                position1.X == position2.X &&
                position1.Y == position2.Y;
        }

        public static bool operator !=(Position position1, Position position2)
        {
            return !(position1 == position2);
        }

        public override bool Equals(object obj)
        {
            return obj is Position &&
                   ((Position)obj == this);
        }
        #endregion

        #region Internal methods
        private void VerifierCoordonnee(ref int value, int max)
        {
            if (value <= 0)
                value = 0;

            if (value >= max)
                value = max - 1;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Coordonnée X
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Coordonnée Y
        /// </summary>
        public int Y { get; private set; }
        #endregion
    }
}
