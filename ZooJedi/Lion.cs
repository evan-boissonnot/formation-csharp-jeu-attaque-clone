using System;
using System.Collections.Generic;
using System.Text;

namespace ZooJedi
{
    /// <summary>
    /// Représente les lions .....
    /// </summary>
    public class Lion
    {
        public Lion(DateTime dateDeNaissance, string nom)
        {
            this.NombreDePattes = 4;
            this.DateNaissance = dateDeNaissance;
            this.Nom = nom;
        }

        /// <summary>
        /// Date de naissance, permettant d'avoir ...
        /// </summary>
        private DateTime DateNaissance;

        /// <summary>
        /// Définit le fait qu'il y a des oreilles 
        /// </summary>
        public bool ADesOreilles;

        
        private float Taille;
        public float GetTaille()
        {
            return this.Taille;
        }
        public void SetTaille(float uneTaille)
        {
            if (uneTaille > 1.5F)
                uneTaille = 1;

            this.Taille = uneTaille;
        }

        public float MaTaille
        {
            get
            {
                return this.Taille;
            }
            set
            {
                if (value > 1.5F)
                    value = 1;

                this.Taille = value;
            }
        }

        

        private bool _aUneQueue = true;
        public bool AUneQueue
        {
            get
            {
                return this._aUneQueue;
            }
        }

        private string Nom;

        private int NombreDePattes = 4;
        public int GetNombreDePattes()
        {
            return this.NombreDePattes;
        }

        public DateTime GetDateDeNaissance()
        {
            return this.DateNaissance;
        }

        public string GetNom()
        {
            return this.Nom;
        }
    }
}
