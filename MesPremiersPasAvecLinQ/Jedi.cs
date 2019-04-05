using System;
using System.Collections.Generic;
using System.Text;

namespace MesPremiersPasAvecLinQ
{
    /// <summary>
    /// C'est un jedi, dans star wars
    /// </summary>
    public class Jedi
    {
        #region Fields
        private string _firstName;
        private string _lastName;
        private int _lifePoint;
        private DateTime _birthDay;
        private int _sexe = 0;
        #endregion

        #region Constructors
        #endregion

        #region Properties

        public string FirstName { get => this._firstName; set => this._firstName = value; }
        public string LastName { get => this._lastName; set => this._lastName = value; }
        public int LifePoint { get => this._lifePoint; set => this._lifePoint = value; }
        public DateTime BirthDay { get => this._birthDay; set => this._birthDay = value; }
        
        public int Sexe { set => this._sexe = value; }

        //public int Sexe { set => this._estUnHomme = value; }

        public bool EstUnHomme { get => this._sexe == 0; }
        public bool EstUneFemme { get => this._sexe == 1; }

        public int Age { get => (int)((DateTime.Now - this.BirthDay).Days / 365.125M); }
        #endregion
    }
}
