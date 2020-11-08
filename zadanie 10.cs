using System;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);
            if (a == 1000000)
            {
                Console.WriteLine("Milion");
                a =- 1000000;
            }
            if (a >= 900000) { a -= 900000; Console.Write("Dziewięćset tysięcy "); }
            else if (a >= 800000) { a -= 800000; Console.Write("Osiemset tysięcy "); }
            else if (a >= 700000) { a -= 700000; Console.Write("Siedemset tysięcy "); }
            else if (a >= 600000) { a -= 600000; Console.Write("Sześćset tysięcy "); }
            else if (a >= 500000) { a -= 500000; Console.Write("Pięćset tysięcy "); }
            else if (a >= 400000) { a -= 400000; Console.Write("Czterysta tysięcy "); }
            else if (a >= 300000) { a -= 300000; Console.Write("Trzysta tysięcy "); }
            else if (a >= 200000) { a -= 200000; Console.Write("Dwieście tysięcy "); }
            else if (a >= 100000) { a -= 100000; Console.Write("Sto tysięcy "); }
            if (a >= 90000) { a -= 90000; Console.Write("Dziewięćdziesiąt tysięcy "); }
            else if (a >= 80000) { a -= 80000; Console.Write("Osiemdziesiąt tysięcy "); }
            else if (a >= 70000) { a -= 70000; Console.Write("Siedemdziesiąt tysięcy "); }
            else if (a >= 60000) { a -= 60000; Console.Write("Sześćdziesiąt tysięcy "); }
            else if (a >= 50000) { a -= 50000; Console.Write("Pięćdziesiąt tysięcy "); }
            else if (a >= 40000) { a -= 40000; Console.Write("Czterdzieści tysięcy "); }
            else if (a >= 30000) { a -= 30000; Console.Write("Trzydzieści tysięcy "); }
            else if (a >= 20000) { a -= 20000; Console.Write("Dwadzieścia tysięcy "); }
            else if (a >= 10000) { a -= 10000; Console.Write("Dziesięć tysięcy "); }
            if (a >= 9000) { a -= 9000; Console.Write("Dziewięć tysięcy "); }
            else if (a >= 8000) { a -= 8000; Console.Write("Osiem tysięcy "); }
            else if (a >= 7000) { a -= 7000; Console.Write("Siedem tysięcy "); }
            else if (a >= 6000) { a -= 6000; Console.Write("Sześć tysięcy "); }
            else if (a >= 5000) { a -= 5000; Console.Write("Pięć tysięcy "); }
            else if (a >= 4000) { a -= 4000; Console.Write("Cztery tysiące "); }
            else if (a >= 3000) { a -= 3000; Console.Write("Trzy tysiące "); }
            else if (a >= 2000) { a -= 2000; Console.Write("Dwa tysiące "); }
            else if (a >= 1000) { a -= 1000; Console.Write("Tysiąc "); }
            if (a >= 900) { a -= 900; Console.Write("Dziewięćset "); }
            else if (a >= 800) { a -= 800; Console.Write("Osiemset "); }
            else if (a >= 700) { a -= 700; Console.Write("Siedemset "); }
            else if (a >= 600) { a -= 600; Console.Write("Sześćset "); }
            else if (a >= 500) { a -= 500; Console.Write("Pięćset "); }
            else if (a >= 400) { a -= 400; Console.Write("Czterysta "); }
            else if (a >= 300) { a -= 300; Console.Write("Trzysta "); }
            else if (a >= 200) { a -= 200; Console.Write("Dwieście "); }
            else if (a >= 100) { a -= 100; Console.Write("Sto "); }
            if (a >= 90) { a -= 90; Console.Write("Dziewięćdziesiąt "); }
            else if (a >= 80) { a -= 80; Console.Write("Osiemdziesiąt "); }
            else if (a >= 70) { a -= 70; Console.Write("Siedemdziesiąt "); }
            else if (a >= 60) { a -= 60; Console.Write("Sześćdziesiąt "); }
            else if (a >= 50) { a -= 50; Console.Write("Pięćdziesiąt "); }
            else if (a >= 40) { a -= 40; Console.Write("Czterdzieści "); }
            else if (a >= 30) { a -= 30; Console.Write("Trzydzieści "); }
            else if (a >= 20) { a -= 20; Console.Write("Dwadzieścia "); }
            else if (a >= 10) { a -= 10; Console.Write("Dziesięc"); }
            switch (a)
            {
                case 1: Console.Write("Jeden"); break;
                case 2: Console.Write("Dwa"); break;
                case 3: Console.Write("Trzy"); break;
                case 4: Console.Write("Cztery"); break;
                case 5: Console.Write("Pięć"); break;
                case 6: Console.Write("Sześć"); break;
                case 7: Console.Write("Siedem"); break;
                case 8: Console.Write("Osiem"); break;
                case 9: Console.Write("Dziewięć"); break;
            }
        }
    }
}
