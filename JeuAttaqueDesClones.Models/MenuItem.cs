using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class MenuItem
    {
        #region Properties
        /// <summary>
        /// Id de l'item du menu
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Libelle de l'item
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Informe si c'est l'id de quitter le jeu
        /// </summary>
        public bool EstQuitterJeu { get => this.Id == -1; }

        /// <summary>
        /// Type d'action sur le menu
        /// </summary>
        public TypeAction Type { get => (TypeAction)this.Id; }
        #endregion
    }
}
