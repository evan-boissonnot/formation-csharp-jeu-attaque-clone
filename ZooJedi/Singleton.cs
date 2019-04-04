using System;
using System.Collections.Generic;
using System.Text;

namespace ZooJedi
{
    public class Singleton
    {
        /// <summary>
        /// Ici, ce champ est appelé avant tout new de la classe, car static
        /// Les initialisations de champs static se font toujours avant les new
        /// Or, le new ici est impossible depuis l'extérieur car private, ici.
        /// Cette initialisation "spéciale" instancie une seule fois sa propre classe
        /// Donc ne sera appelée qu'une seule fois dans l'exécutable.
        /// </summary>
        private static Singleton __instance = new Singleton();

        private Singleton()
        {

        }

        /// <summary>
        /// Ici on a la propriété public donc on l'appelle quand on veut depuis l'extérieur
        /// Elle appelle l'instance unique (la variable static)
        /// </summary>
        public static Singleton Instance { get { return __instance; } }
    }
}
