using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class Wookie
    {
        #region Properties
        public int Id { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Famille MaFamille { get; set; }

        public List<Combat> MesCombats { get; set; }
        #endregion
    }
}
