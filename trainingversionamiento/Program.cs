using System;

namespace trainingversionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operacion:");
            string operacion = Console.ReadLine();

            Console.WriteLine("Numero 1:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string number1 = Console.ReadLine();
            Console.WriteLine("Numero 2:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string number2 = Console.ReadLine();
            int resultado = 0;
            if(Int32.Parse(number1 )< 10)
            {
                Console.WriteLine("Error: numero 1 tiene que ser mayor a 10");
                return;
            }
            switch (operacion)
            {
                case "suma":
                    resultado = Int32.Parse(number1) + Int32.Parse(number2);
                    break;
                case "resta":
                    resultado = Int32.Parse(number1) - Int32.Parse(number2);
                    break;
                default:
                    Console.WriteLine("Error: Operacion no valida");
                    break;
            }

            Console.WriteLine("test");
            Console.WriteLine($" El resultado de la operacion {operacion} entre {number1} y {number2} es igual a {resultado.ToString()}");

        }
    }
}
