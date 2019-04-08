using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    /// <summary>
    /// Type d'action à faire
    /// Note : ici, dans une v2 on passera par une classe parente et des classes enfants, plutôt qu'un enum
    /// </summary>
    public enum TypeAction
    {
        QuitterLeJeu = -1,
        SaisieDonneesJoueur = 1,
        ChoixEtSaisiePersonnage = 2,
        LancerLeJeu = 3
    }
}
