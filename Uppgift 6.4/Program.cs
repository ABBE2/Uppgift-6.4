using System;
using System.Security.Cryptography.X509Certificates;

namespace program
{
    class program
    {
        static double exponent(double tal1, double tal2)
        {
            
            double x = Math.Pow(tal1, tal2);
            return x;   
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en siffra.");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv en exponent.");
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Svar: {0}", exponent(tal1,tal2));
        }
    }
}