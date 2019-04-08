using System;
using System.Collections.Generic;
using System.Threading;
using JeuAttaqueDesClones.Models;

namespace JeuAttaqueDesClones.Core
{
    /// <summary>
    /// Moteur de jeu, lance le programme
    /// </summary>
    public class MoteurDuJeu
    {
        #region Fields
        private static int _NB_ATTAQUANTS = 100;

        #region Autour du jeu
        private Joueur _joueur = null;
        private List<Personnage> _attaquants = new List<Personnage>();
        #endregion

        private Menu _menu = null;
        private readonly Action<string> _afficherLigne = null;
        private readonly Action<string> _afficherSurMemeLigne = null;
        private readonly Func<string> _saisirInformation = null;
        #endregion

        #region Constructors
        public MoteurDuJeu(Action<string> afficherLigne, Func<string> saisirInformation, Action<string> afficherSurMemeLigne = null)
        {
            this._afficherLigne = afficherLigne;
            this._afficherSurMemeLigne = afficherSurMemeLigne;
            this._saisirInformation = saisirInformation;

            this._menu = new Menu(this._afficherLigne, this._saisirInformation);
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
            } while (!this._menu.EstDemandeQuitterJeu);

        }
        #endregion

        #region Internal methods
        // Note: ici, l'idée est d'éliminer, dans une v2) le switch en passant par des Action, et des classes qui font le travail à la place (héritage + polymorphisme)
        private void LancerActionSuivantChoixMenu()
        {
            switch (this._menu.ChoixCourant?.Type)
            {
                case TypeAction.SaisieDonneesJoueur:
                    {
                        this.SaisieDonneesJoueur();
                    }
                    break;

                case TypeAction.ChoixEtSaisiePersonnage:
                    {
                        this.SaisiePersonnage();
                    }
                    break;

                case TypeAction.LancerLeJeu:
                    {
                        this.Lancer();
                    }
                    break;

                default:
                    break;
            }
        }

        private void SaisieDonneesJoueur()
        {
            // NOTE: ici, on pourrait utiliser le menu, avec le menu item

            this._afficherLigne("======== QUI ETES VOUS ? ========");

            this._afficherLigne("Votre prénom ?");
            this._joueur.Prenom = this._saisirInformation();

            this._afficherLigne("Votre nom ?");
            this._joueur.Nom = this._saisirInformation();
        }

        private void SaisiePersonnage()
        {
            // NOTE: ici, on pourrait utiliser le menu, avec le menu item

            this._afficherLigne("======== VOTRE PERSONNAGE ========");

            this._afficherLigne("Personnage du côté obscur ou lumineux de la force ? 0 ou 1");
            string choix = this._saisirInformation();
            int choixReel = 0;
            int.TryParse(choix, out choixReel);

            this._joueur.InitialiserPersonnage(choixReel == 1);

            this._afficherLigne("Le nom de votre personnage ?");
            this._joueur.MonPersonnage.Nom = this._saisirInformation();
        }

        private void Lancer()
        {
            this.InitialiserLancementJeu();
            this.DemarrerLeJeu();
        }

        private void DemarrerLeJeu()
        {
            while (this._joueur.MonPersonnage.EstEnVie)
            {
                this.DeplacerLesAttaquants();
                this.GererLesAttaques();
                DemanderNouveauDeplacement();
                Thread.Sleep(100);
                this.AfficherCarte();
            }
        }

        private void InitialiserLancementJeu()
        {
            this._afficherLigne("======== C'EST PARTI !!! ========");

            this.InitialiserAttaquants();
            this.InitialiserPositionJoueur();

            this.AfficherBarreDeProgression();
            this._afficherLigne("======== May the force be with you ! ========");
        }

        private void InitialiserPositionJoueur()
        {
            this._joueur.MonPersonnage.SeDeplacer();
        }

        private void AfficherBarreDeProgression()
        {
            //NOTE: ici, on pourra créer en v2, une classe dédiée
            const int max = 50;
            int i = 0;

            this._afficherSurMemeLigne("[");
            while (i < max)
            {
                this._afficherSurMemeLigne("=");
                Thread.Sleep(200 - i);

                i++;
            }
            this._afficherSurMemeLigne("]\n");
        }

        private void InitialiserAttaquants()
        {
            bool estGentil = (this._joueur.MonPersonnage is Clone);

            for (int i = 0; i < MoteurDuJeu._NB_ATTAQUANTS; i++)
            {
                this._attaquants.Add(this.InitialiserUnAttaquant(estGentil));
            }
        }

        private Personnage InitialiserUnAttaquant(bool estGentil)
        {
            Personnage personnage = null;

            //NOTE: ici, en v2, il faudra avoir une Fabric (Design Pattern) dédiée
            if (estGentil)
            {
                personnage = new Robot();
            }
            else
            {
                personnage = new Clone();
            }

            this.DeplacerUnAttaquant(personnage);

            return personnage;
        }

        private void DeplacerLesAttaquants()
        {
            this._attaquants.ForEach(item => item.SeDeplacer());
        }

        private void DeplacerUnAttaquant(Personnage personnage)
        {
            personnage.SeDeplacer();
        }

        private void GererLesAttaques()
        {
            throw new NotImplementedException();
        }

        private void DemanderNouveauDeplacement()
        {
            throw new NotImplementedException();
        }

        private void AfficherCarte()
        {
            for (int i = 0; i < Personnage._MAX_X; i++)
            {
                for (int j = 0; j < Personnage._MAX_Y; j++)
                {
                    this._afficherSurMemeLigne(".");
                    throw new NotImplementedException("Gérer l'affichage si joueur, attaquant (vivant ou mort)");
                }
                this._afficherSurMemeLigne("\n");
            }
        }
        #endregion
    }
}
