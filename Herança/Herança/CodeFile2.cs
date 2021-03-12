using System;

namespace Herança
{
    class Carro : Veiculo
    {
        public double speed { get; set; }
        public double distance { get; set; }
        public double time { get; set; }

        public void calcularVelocidade()
        {
            Console.WriteLine("A fórmula para calcular velocidade é: distance/time");
        }
    }
}