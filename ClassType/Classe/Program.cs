using System;

namespace Classe
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Meu nome é: " + firstName + " " + lastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.firstName = "Henrique";
            person.lastName = "Lima";
            person.Introduce();
        }
    }
}
