using System;

namespace DecouverteEntierDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //// comm sur une ligne
            ///*
            // * long commentaire
            // */
            //int x = 
            //    8;

            //int y = 10;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Console.WriteLine("Merci de saisir le X");
            //string saisieX = Console.ReadLine();

            //x = int.Parse(saisieX);

            //Console.WriteLine("Merci de saisir le Y");
            //string saisieY = Console.ReadLine();

            //y = int.Parse(saisieY);



            //saisieX = Console.ReadLine();
            //// nouvelle transfo
            //if (! int.TryParse(saisieX, out x))
            //{
            //    Console.WriteLine("Vous n'avez pas saisi un entier !");
            //}

            //while (!int.TryParse(saisieX, out x))
            //{
            //    Console.WriteLine("Vous n'avez pas saisi un entier !");
            //    saisieX = Console.ReadLine();
            //}


            // Decouverte formattage and co

            decimal tauxTva = 19.6M;
            Console.WriteLine(tauxTva);

            double monDouble = 19.6D;

            float monFLoat = 19.6F;




            int valeur1 = 1 / 3;
            Console.WriteLine(valeur1);

            float valeur2 = 1F / 3;
            Console.WriteLine(valeur2);

            double valeur3 = 1D / 3;
            Console.WriteLine(valeur3);

            string formattage = valeur3.ToString("00.000");


            decimal valeurFormattee = 0.33338M;
            Console.WriteLine(valeurFormattee);
            Console.WriteLine(valeurFormattee.ToString("0.0000"));


            Console.WriteLine(formattage);
            Console.WriteLine(valeur3.ToString("#0.00#"));

            Console.WriteLine(valeur3.ToString("#.00", null));

            Console.WriteLine("Val max de Double : " + double.MaxValue);


            decimal valeur4 = 1M / 3;
            Console.WriteLine(valeur4);



            double resultatCalcul = Math.PI;

            Console.WriteLine("Val max de Decimal : " + decimal.MaxValue);

        }
    }
}
