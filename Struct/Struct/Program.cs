using System;

namespace Struct
{
    struct Employee
    {
        public string empNumber;
        public string empName;
        public string position;

        public Employee(string empNumber, string empName, string position)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.position = position;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            var number = a.empNumber = "1";
            var name = a.empName = "nome";
            var position = a.position = "first";

            Console.WriteLine("Number= " +number+ ", Name= " +name+ ", Position= " +position);
        }
    }
}
