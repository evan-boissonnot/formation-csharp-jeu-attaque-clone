using System;

namespace DecouverteString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string saisie = Console.ReadLine();

            string chaineFormattee = string.Format("Vous avez saisi : {0}.", saisie);

            Console.WriteLine("Vous avez saisi : " +  saisie + ".");

            Console.WriteLine(chaineFormattee);


            string saisie2 = Console.ReadLine();
            chaineFormattee = string.Format("Vous avez saisi : {0} et {1}.", saisie, saisie2);
            Console.WriteLine(chaineFormattee);


            chaineFormattee = string.Format("Vous avez saisi : {1} et {1}.", saisie, saisie2);
            Console.WriteLine(chaineFormattee);


            //chaineFormattee = string.Format("Vous avez saisi : {2} et {1}.", saisie, saisie2);
            //Console.WriteLine(chaineFormattee);

            chaineFormattee = string.Format("Vous avez saisi : {1}.", saisie, saisie2);
            Console.WriteLine(chaineFormattee);

            chaineFormattee = $"Vous avez saisi : '{saisie}' et {saisie2}.";
            Console.WriteLine(chaineFormattee);

            //______
            string unCheminDeFichier = "c:\\program files";
            unCheminDeFichier = @"c:\program files";

            //______
            string surnom = Console.ReadLine();
            string surNomUpper = surnom.ToUpper();

            Console.WriteLine($" {surnom} et {surNomUpper} ");

            //______
            // 7 caractères, et si vide mettre '_'
            string surnomFormatte = surNomUpper.PadLeft(7, '_');
            Console.WriteLine(surnomFormatte);

            string uneCHaine = null;

            if(uneCHaine == null || uneCHaine == "")
            {
                // c'est vide ou null;
            }
            if(string.IsNullOrEmpty(uneCHaine))
            {
                // c'est vide ou null
            }
            if(string.IsNullOrWhiteSpace(uneCHaine))
            {
                //null ou vide ou que des espaces
            }
        }
    }
}
