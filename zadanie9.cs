
using System;
using static System.Math;
namespace Class1
{
    class Program
    {
       static void Main(string[] args)
        {
            double a, b, c;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);

            double delta = Pow(b, 2) - 4 * a * c;
            
            if(delta == 0)
            {
                Console.Write(-b / (2 * a));
            } else if(delta < 0)
            {
                Console.WriteLine("Brak miejsc zerowych");
            } else
            {
                double x1 = (-b - Sqrt(delta)) / 2 * a;
                double x2 = (-b + Sqrt(delta)) / 2 * a;
                Console.WriteLine(x1 + " " + x2);
            }
        }
    }
}