using System;

namespace Harjoituksia4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä1
            int Luku1;
            Console.WriteLine("Syötä ikäsi");
            Luku1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku1 + " Näytät ikäistäsi nuoremmalta");


            //Tehtävä2
            int Luku2;
            Console.WriteLine("Syötä 10 suurempi luku");
            Luku2 = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= Luku2; i++) 
            {
                Console.Write(Luku2 + " ");
            }
            Console.WriteLine("\n");


            //Tehtävä3
            string yourWord;
            Console.WriteLine("Syötä jokin sana");
            yourWord = Console.ReadLine();
            int len = yourWord.Length;
            Console.WriteLine( yourWord[len - 1] + yourWord.Substring(1, len - 2) + yourWord[0]);
        }
    }
}
