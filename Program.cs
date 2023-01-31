using System;

namespace PrideAndPrejudice
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Calculator! Select operation to continue.");
            System.Console.WriteLine();
            System.Console.WriteLine("+");
            System.Console.WriteLine("-");
            System.Console.WriteLine("/");
            System.Console.WriteLine("*");
            string Negr = Console.ReadLine();
            System.Console.WriteLine("Vvedite chislo1");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Vvedite chislo2");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            if (Negr == "+")
            {
                System.Console.WriteLine(numberOne + numberTwo);
            }
            if (Negr == "-")
            {
                System.Console.WriteLine(numberOne - numberTwo);
            }
            if (Negr == "/")
            {
                System.Console.WriteLine(numberOne / numberTwo);
            }
            if (Negr == "*")
            {
                System.Console.WriteLine(numberOne * numberTwo);
            }
            Console.ReadLine();
        }
    }
}
