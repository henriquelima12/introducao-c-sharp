using System;

namespace Classes
{
    class Program
    {
        public class Person
        {
            public string name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, i am {1}" ,to, name);
            }
        }
        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Henrique";
            person.Introduce("Machine");

        }
    }
}
