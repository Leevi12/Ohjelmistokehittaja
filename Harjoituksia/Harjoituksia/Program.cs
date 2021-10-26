using System;

namespace Harjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tehtävä1
            int Luku1;
            int Luku2;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku1 = Luku2 + 3);


            //Tehtävä2
            int Luku3;
            int Luku4;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku3 = Luku4 - 2);




            //Tehtävä3
            int Luku5;
            int Luku6;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku5 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku6 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku5 = Luku6 * 5);


            //Tehtävä4
            int Luku7;
            int Luku8;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku7 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku8 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku7 = Luku8 / Luku7);


            //Tehtävä5
            int Luku9;
            int Luku10;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku9 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku10 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku9 = Luku10 % 4);


            //Tehtävä6
            int Luku11;
            int Luku12;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku11 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku12 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku10 += Luku11);


            //Tehtävä7
            int Luku13;
            int Luku14;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku13 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku14 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku13 -= Luku14);


            //Tehtävä8
            int Luku15;
            int Luku16;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku15 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku16 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku13 *= Luku14 * 5);


            //Tehtävä9
            int Luku17;
            int Luku18;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku17 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku18 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku17 /= Luku18);
        }

    }
}