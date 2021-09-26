using System;

namespace trainingversionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string number1 = Console.ReadLine();
            Console.WriteLine("Numero 2:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string number2 = Console.ReadLine();

            int resultado = Int32.Parse(number1) + Int32.Parse(number2);
            Console.WriteLine($"{number1} + {number2} = {resultado.ToString()}");

        }
    }
}
