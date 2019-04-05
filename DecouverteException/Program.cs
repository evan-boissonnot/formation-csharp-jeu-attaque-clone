using System;

namespace DecouverteException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string saisie = Console.ReadLine();
            int valeur = int.Parse(saisie);

            // nouveau contexte mémoire
            //{
            //    decimal value = 3;
            //}


            decimal divisionTVA = 0;
            try
            {
                divisionTVA = 18 / valeur;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                if(exception is DivideByZeroException)
                {
                    Console.WriteLine("Erreur sur le zero !");
                }
                else
                {
                    Console.WriteLine("Boa, y a eu une erreur quoi !");
                }
            }

            try
            {
                divisionTVA = 18 / valeur;
            }
            catch(DivideByZeroException exception)
            {
                Console.WriteLine("Erreur sur le zero !");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
                Console.WriteLine("Boa, y a eu une erreur quoi !");

            }

            try
            {
                throw new Exception();
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Erreur sur le zero !");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                Console.WriteLine("Boa, y a eu une erreur quoi !");

            }

            try
            {
                throw new NotImplementedException();
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Erreur sur le zero !");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

                Console.WriteLine("Boa, y a eu une erreur quoi !");

            }


            //try
            //{
            //    throw new NotImplementedException();
            //}
            //catch (DivideByZeroException exception)
            //{
            //    Console.WriteLine("Erreur sur le zero !");
            //}

            Console.WriteLine("Le resultat est : " + divisionTVA);



            Facture facture = new Facture();

            try
            {
                facture.DefinirDate(Console.ReadLine());
                throw new Exception();
            }
            catch(FormatException ex)
            {

            }
            catch(DateTropVieilleException ex)
            {
                Console.WriteLine("La date est dépassée de 30 jours");
            }
            finally
            {
                Console.WriteLine("coucou, je m'exécute tout le temps");
            }

            Console.WriteLine("coucou, je m'exécute tout le temps ??");

        }
    }
}
