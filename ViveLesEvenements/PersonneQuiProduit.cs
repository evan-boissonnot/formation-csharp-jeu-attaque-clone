using System;
using System.Collections.Generic;
using System.Text;

namespace ViveLesEvenements
{
    public class PersonneQuiProduit
    {
        // Le moyen pour tout le monde de s'attacher à l'info, et d'être informé
        public event Action<string> RapportFini;

        public void ProduireRapport()
        {
            Console.WriteLine("Je suis en train de faire mon rapport");

            // L'idée ici c'est de prévenir tous mes collègues ou autres !
            if(this.RapportFini != null) // Ya  des instances à prévenir ?
            {
                // Je préviens tout le monde
                this.RapportFini("<<Le contenu du rapport>>");
            }
        }
    }
}
