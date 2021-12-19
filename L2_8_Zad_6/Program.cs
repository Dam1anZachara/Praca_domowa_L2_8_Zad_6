using System;

namespace L2_8_Zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + 1/2 + 1/3 + 1/4 itd.");
            
            decimal sumOfThePattern = 0;
            
            for (decimal i = 1; i <= 20; i++)
            {
                decimal componentOfThePattern = 1 / i;
                sumOfThePattern = sumOfThePattern + componentOfThePattern;
            }
            Console.WriteLine($"Suma liczb ze wzoru wynosi: {sumOfThePattern}");
        }
    }
}
