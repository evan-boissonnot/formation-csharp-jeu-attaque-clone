using System;

namespace DecouverteDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculateur calculateur = new Calculateur();
            calculateur.CalculerTva20pourcent(100, JafficheLaTva);
            calculateur.CalculerTva20pourcent(100, JafficheLaTvaEnCouleur);

            Action uneProc = () =>
            {
                Console.WriteLine("coucou");
            };
            uneProc();

            Action<string> uneProc2 = (variable) =>
            {
                Console.WriteLine("C'est une chaine : " + variable);
            };
            uneProc2("youhoo");

            Action<decimal> uneProcAfficheTva = (tva) =>
            {
                Console.WriteLine("La tva : " + tva);
            };
            calculateur.CalculerTva20pourcent(100, uneProcAfficheTva);


            calculateur.CalculerTva20pourcent(100, (tva) =>
            {
                Console.WriteLine("La tva :) : " + tva);
            });
        }

        static void JafficheLaTva(decimal uneValeur)
        {
            Console.WriteLine("La tva est de " + uneValeur);
        }

        static void JafficheLaTvaEnCouleur(decimal uneValeur)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La tva est de " + uneValeur);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
