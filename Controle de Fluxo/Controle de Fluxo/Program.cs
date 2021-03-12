using System;

namespace Controle_de_Fluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Manhã");
            }
            else if (hour >= 12 && hour > 18)
            {
                Console.WriteLine("Tarde");
            }
            else 
            {
                Console.WriteLine("Noite");
            }

            Console.WriteLine("Números divisíveis por 2 cujo resto é igual a 0:");
            for (var i=0; i<=10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Lendo valores da lista:");
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            while(true)
            {
                Console.Write("Enter your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                break;

                Console.WriteLine("Nome: " + input);

            }

        }
    }
}
