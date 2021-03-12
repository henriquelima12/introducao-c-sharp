using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Henrique";
            bool isWorking = false;
            int result;
            string str = "3476";
            result = Convert.ToInt32(str);

            Console.WriteLine("Hello World!");
            Console.WriteLine(result);
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}
