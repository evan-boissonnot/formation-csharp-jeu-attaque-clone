using System;
using JeuAttaqueDesClones.Models;

namespace JeuAttaqueDesClones.Core
{
    /// <summary>
    /// Moteur de jeu, lance le programme
    /// </summary>
    public class MoteurDuJeu
    {
        #region Fields
        private Joueur _joueur = null;
        private Menu _menu = null;
        private readonly Action<string> _afficher = null;
        private readonly Func<string> _saisirInformation = null;
        #endregion

        #region Constructors
        public MoteurDuJeu(Action<string> afficher, Func<string> saisirInformation)
        {
            this._afficher = afficher;
            this._saisirInformation = saisirInformation;

            this._menu = new Menu(this._afficher, this._saisirInformation);
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Lance le programme
        /// </summary>
        public void Demarrer()
        {
            this._joueur = new Joueur();
            this._menu.Initialiser();

            do
            {
                this._menu.Afficher();
                this._menu.ChoisirMenu();
                this.LancerActionSuivantChoixMenu();
            } while (! this._menu.EstDemandeQuitterJeu);
            
        }
        #endregion

        #region Internal methods
        // Note: ici, l'idée est d'éliminer, dans une v2) le switch en passant par des Action, et des classes qui font le travail à la place (héritage + polymorphisme)
        private void LancerActionSuivantChoixMenu()
        {
            switch (this._menu.ChoixCourant?.Type)
            {
                case TypeAction.ChoixEtSaisiePersonnage:
                    {

                    } break;

                case TypeAction.SaisieDonneesJoueur:
                    {
                        this.SaisieDonneesJoueur();
                    } break;

                case TypeAction.LancerLeJeu:
                    {

                    } break;

                default:
                    break;
            }
        }

        private void SaisieDonneesJoueur()
        {

        }
        #endregion
    }
}
