using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Henrique";
            var lastName = "Lima";
            var fullName = firstName + "" + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "João", "Maria", "Antônio" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);
        }
    }
}
