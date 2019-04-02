using System;
using System.Globalization;

namespace DecouverteDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vive les dates !!");

            DateTime dateTime = DateTime.MinValue;
            //DateTime @DateTime = 

            Console.WriteLine(dateTime);
            dateTime = DateTime.Now;


            Console.WriteLine(dateTime);
            dateTime.AddDays(2);
            Console.WriteLine(dateTime);

            DateTime newDate = dateTime.AddDays(2);
            Console.WriteLine(newDate);

            newDate = dateTime.AddDays(-2);
            Console.WriteLine(newDate);



            if (newDate.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("C'est un dimanche, dodo !");

            }

            DateTime date = new DateTime(2018, 3, 2);
            DateTime date2 = new DateTime(2019, 4, 4);

            int valCompare = DateTime.Compare(date2, date);
            Console.WriteLine(valCompare);

            // Comment savoir combien de jours, exactement il y a entre les deux dates ?
            TimeSpan time = date2.Subtract(date);
            Console.WriteLine(time.TotalDays);


            DateTime dateToutSeul = DateTime.Now.Date;


            TimeSpan horaire = date.TimeOfDay;

            //________
           Console.WriteLine(DateTime.Now.ToString("année : yy, yyy, yyyy -- 'mois' : MM MMM MMMM -- 'jour' : dd ddd dddd"));


            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now.ToString("année : yy, yyy, yyyy -- 'mois' : MM MMM MMMM -- 'jour' : dd ddd dddd", 
                                                    culture));


        }
    }
}
