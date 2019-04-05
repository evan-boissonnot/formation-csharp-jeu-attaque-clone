using System;
using System.Collections.Generic;
using System.Text;

namespace DecouverteException
{
    public class Facture
    {
        private DateTime _dateTime = DateTime.Now;

        /// <summary>
        /// Affecte la date
        /// </summary>
        /// <param name="dateSaisie"></param>
        /// <exception cref="Exception">Attention ici si date vide ça plante</exception>
        /// <exception cref="FormatException">Attention ici si date vide ça plante</exception>
        public void DefinirDate(string dateSaisie)
        {
            if (string.IsNullOrEmpty(dateSaisie))
                throw new Exception();

            this._dateTime = DateTime.Parse(dateSaisie);

            //if (this._dateTime < DateTime.Now.AddDays(-30))
            //    throw new Exception("La date est dépassée de 30 jours");

            if (this._dateTime < DateTime.Now.AddDays(-30))
                throw new DateTropVieilleException("");
        }

        public DateTime DateCreation { get { return this._dateTime; } }
    }
}
