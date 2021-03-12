using System;

namespace Herança
{
    class Maruti : Carro
    {
        public void MarutiStart()
        {
            Motor MarutiMotor = new Motor();
            MarutiMotor.start();
        }
    }
}
