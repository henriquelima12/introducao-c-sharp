using System;

namespace Classes
{
    public class Pessoa
    {
        private DateTime _birthdate;

        public int idade()
        {
            return 19;
        }

        //1º método get e set
        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        //2º método get e set
        public DateTime BirthDate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        //3º método get e set
        public DateTime Birthdate { get; set; }
    }

    class PersonTeste
    {
        static void main(string[] args)
        {
            var person = new Pessoa();
            person.Birthdate = new DateTime(2001, 7, 22);
            Console.WriteLine(person.idade());
        }
        
        
    }
}