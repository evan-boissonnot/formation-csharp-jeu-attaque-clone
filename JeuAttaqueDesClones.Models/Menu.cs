using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JeuAttaqueDesClones.Models
{
    public class Menu
    {
        #region Fields
        private readonly Action<string> _afficher = null;
        private readonly Func<string> _saisirInformation = null;
        private MenuItem _choixCourant = null;
        #endregion

        #region Constructors
        public Menu(Action<string> afficher, Func<string> saisirInformation)
        {
            this._afficher = afficher;
            this._saisirInformation = saisirInformation;            
        }
        #endregion

        #region Public methods
        public void Initialiser()
        {
            this.Items = new List<MenuItem>()
            {
                new MenuItem() { Id = (int) TypeAction.SaisieDonneesJoueur, Libelle = "Saisie du joueur" },
                new MenuItem() { Id = (int) TypeAction.ChoixEtSaisiePersonnage, Libelle = "Choix du personnage" },
                new MenuItem() { Id = (int) TypeAction.LancerLeJeu, Libelle = "Démarrage du jeu" },
                new MenuItem() { Id = (int) TypeAction.QuitterLeJeu, Libelle = "Quitter" }
            };
        }

        public void Afficher()
        {
            if (this.Items != null)
            {
                foreach (var item in this.Items)
                {
                    this._afficher($"{item.Id} : {item.Libelle}");
                }

                this._afficher("Faite votre choix");
            }
        }

        public MenuItem ChoisirMenu()
        {
            string menu = this._saisirInformation();
            int menuId = 0;

            if(int.TryParse(menu, out menuId))
            {
                this._choixCourant = this.Items.FirstOrDefault(item => item.Id == menuId);
            }            

            return this._choixCourant;
        }
        #endregion

        #region Internal methods
        #endregion

        #region Properties
        /// <summary>
        /// Choix courant de l'utilisateur
        /// </summary>
        public MenuItem ChoixCourant { get => this._choixCourant; }

        /// <summary>
        /// Liste des items du menus
        /// </summary>
        public List<MenuItem> Items { get; set; }

        /// <summary>
        /// Indique si l'utilisateur souhaite quitter le jeu
        /// </summary>
        public bool EstDemandeQuitterJeu { get => (this.ChoixCourant?.EstQuitterJeu).GetValueOrDefault(false); }
        #endregion
    }
}
