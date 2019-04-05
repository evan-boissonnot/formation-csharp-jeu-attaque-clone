using System;
using System.Collections.Generic;
using System.Text;

namespace DecouverteDelegate
{
    public class Calculateur
    {
        public void CalculerTva20pourcent(decimal montantTTC, Action<decimal> Afficher)
        {
            decimal tva = montantTTC * 0.2M;
            //Console.WriteLine($"Le montant tva est de : {tva:00.00}€");

            Afficher(tva);
        }
    }
}
