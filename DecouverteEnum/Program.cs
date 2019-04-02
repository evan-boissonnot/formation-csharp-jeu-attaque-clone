using System;

namespace DecouverteEnum
{
    class Program
    {
        private const int DAY = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DayOfWeek day = DayOfWeek.Tuesday;
            Console.WriteLine(day);

            Console.WriteLine((int)day);


            //kjhfskjfhsdf
            int valeur = 1;



            if (valeur == DAY)
            {
                // pour presenter idee constante
            }

            if (valeur == (int)DayOfWeek.Monday)
            {
                // comparer entier / enum
            }

            day = (DayOfWeek)22;
            Console.WriteLine(day);

            switch (day)
            {
                case DayOfWeek.Monday:
                    {

                    }
                    break;

                case DayOfWeek.Tuesday:
                    {

                    }
                    break;
            }

            switch (day)
            {
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                default:
                    break;
            }

            Sexe sexe = Sexe.Autre;

            Console.WriteLine("H/F ?");
            string valeurSexe = Console.ReadLine();

            sexe = (Sexe)Enum.Parse(typeof(Sexe), valeurSexe);
            Console.WriteLine(sexe);


            string[] listNoms = Enum.GetNames(typeof(Sexe));
            for (int i = 0; i < listNoms.Length; i++)
            {
                Console.WriteLine(listNoms[i]);
            }

        }
    }
}
