using System;

namespace Harjoituksia4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä11
            int Luku1;
            Console.WriteLine("Syötä ikäsi");
            Luku1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Luku1 + " Näytät ikäistäsi nuoremmalta");


            //Tehtävä12
            int Luku2;
            Console.WriteLine("Syötä 10 suurempi luku");
            Luku2 = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= Luku2; i++) 
            {
                Console.Write(Luku2 + " ");
            }
            Console.WriteLine("\n");


            //Tehtävä13
            string yourWord;
            Console.WriteLine("Syötä jokin sana");
            yourWord = Console.ReadLine();
            int len = yourWord.Length;
            Console.WriteLine( yourWord[len - 1] + yourWord.Substring(1, len - 2) + yourWord[0]);


            //Tehtävä14
            int Luku3;
            int Luku4;
            Console.WriteLine("Syötä ensimmäinen luku");
            Luku3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä ensimmäinen luku");
            Luku4 = Int32.Parse(Console.ReadLine());
            if (Luku3 > 0 && Luku4 > 0)
            {
                Console.Write("Molemmat luvut ovat positiivisia");
            }
            else if (Luku3 > 0 || Luku4 >0)
            {
                Console.Write("Toinen luvuista on positiivinen");
            }
            else
            {
                Console.Write("Molemmat luvut ovat negatiivisia");
            }
            Console.WriteLine("\n");

            //Tehtävä15
            string line;
            Console.WriteLine("Syötä jokin lause");
            line = Console.ReadLine();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }
                Console.WriteLine(word);


            //Tehtävä16 & 17
            for(int i = 3; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}