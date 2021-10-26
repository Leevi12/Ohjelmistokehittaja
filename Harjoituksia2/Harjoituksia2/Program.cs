using System;

namespace Harjoituksia2
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
            if (Luku1 > Luku2)
            {
                Console.WriteLine(Luku1);
                Console.WriteLine(Luku2);
            }
            else
            {
                Console.WriteLine(Luku2);
                Console.WriteLine(Luku1);
            }


            //Tehtävä2
            int Luku3;
            int Luku4;
            int Luku5;
            Console.WriteLine("Syötä ensimmäinen Luku");
            Luku3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä kolmas Luku");
            Luku5 = Int32.Parse(Console.ReadLine());
            if (Luku3 > Luku4 && Luku3 > Luku5)
            {
                Console.WriteLine(Luku3);
            }
            else if (Luku4 > Luku3 && Luku4 > Luku5)
            {
                Console.WriteLine(Luku4);
            }
            else
            {
                Console.WriteLine(Luku5);
            }


            //Tehtävä3
            int Luku6;
            Console.WriteLine("Anna Luku 0-9");
            Luku6 = Int32.Parse(Console.ReadLine());
            switch(Luku6)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitseman");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksan");
                    break;
                default:
                    Console.WriteLine("Anna luku 0-9");
                    break;
            }


            //Tehtävä4
            int Luku7;
            int Luku8;
            int Luku9;
            int Luku10;
            int Luku11;
            Console.WriteLine("Syötä ensimmainen Luku");
            Luku7 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä Toinen Luku");
            Luku8 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä kolmas Luku");
            Luku9 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä neljas Luku");
            Luku10 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä viides Luku");
            Luku11 = Int32.Parse(Console.ReadLine());
            if (Luku7 > Luku8 && Luku7 > Luku9 && Luku7 > Luku10 && Luku7 > Luku11)
            {
                Console.WriteLine(Luku7);
            }
            else if (Luku8 > Luku7 && Luku8 > Luku9 && Luku8 > Luku10 && Luku8 > Luku11)
            {
                Console.WriteLine(Luku8);
            }
            else if (Luku9 > Luku7 && Luku9 > Luku8 && Luku9 > Luku10 && Luku9 > Luku11)
            {
                Console.WriteLine(Luku9);
            }
            else if (Luku10 > Luku7 && Luku10 > Luku8 && Luku10 > Luku9 && Luku10 > Luku11)
            {
                Console.WriteLine(Luku10);
            }
            else
            {
                Console.WriteLine(Luku11);
            }


            //Tehtävä5
            int Luku12;
            string valinta;
            Console.WriteLine("Valitse vaihtoehdoista: kokonaisluku, double vai merkkijono");
            valinta = Console.ReadLine();
            switch(valinta) { 
            case "kokonaisluku":
            case "double":
                Console.WriteLine("Anna lukusi ja lisaan sihen yhden");
                Luku12 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Luku12 + 1);
                break;
            case "merkkijono":
                Console.WriteLine("Anna haluamasi sana tai lause");
                valinta = Console.ReadLine();
                Console.WriteLine(valinta + "*");
                break;
            default:
                Console.WriteLine("Valitse vaihtoehdoista: kokonaisluku, double vai merkkijono");
                break;

            }

            //Tehtävä6
            
        }

    }
}
