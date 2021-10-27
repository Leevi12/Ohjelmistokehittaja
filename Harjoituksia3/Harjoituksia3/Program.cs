using System;

namespace Harjoituksia3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä1 ja Tehtävä 6
            int Luku1;
            int Luku2;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku1 + Luku2);


            //Tehtävä2 ja Tehtävä 7
            int Luku3;
            Console.WriteLine("Syötä lämpötila Celsius asteina niin muutan sen Fahrenheitiksi");
            Luku3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine((Luku3 * 1.8) + 32 );


            //Tehtävä3, Tehtävä 4, Tehtävä 8 ja Tehtävä9
            int Luku4;
            int Luku5;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku5 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku4 + Luku5);
            Console.WriteLine(Luku4 - Luku5);
            Console.WriteLine(Luku4 * Luku5);
            Console.WriteLine(Luku4 / Luku5);
            Console.WriteLine(Luku4 % Luku5);

            //Tehtävä10
            int Luku6;
            Console.WriteLine("Syötä kokonaisluku niin tulostan sen kertotaulun");
            Luku6 = Int32.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.Write(Luku6 * i + "\t");
            }
            Console.ReadLine();
        }
    }
}
