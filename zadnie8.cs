
using System;
using static System.Math;
namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
        {
            int a, b, c;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            if(a + b > c &&a + c > b &&b + c > a)
            {
                Console.WriteLine("Da się zbudować trójkąt");
            } else if(a == b && b == a && a == c)
            {
                Console.WriteLine("Da się zbudować trójkąt");

            }
            else
            {
                Console.WriteLine("Nie da się");
            }

        }
    }
}