using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.name = "Toyota";
            carro.Move();
            System.Console.WriteLine();
            Console.WriteLine(carro.name);
            Maruti maruti = new Maruti();
            Console.WriteLine();
            maruti.MarutiStart();
        }
    }
}
