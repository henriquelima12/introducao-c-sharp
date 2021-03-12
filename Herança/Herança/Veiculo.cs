using System;

namespace Herança
{
    class Veiculo
    {
        public string name { get; set; }
        public string brand { get; set; }

        public void Move()
        {
            Console.WriteLine("Veículo em movimento");
        }

        public void Stop()
        {
            Console.WriteLine("Veículo parado");
        }
    }
}
