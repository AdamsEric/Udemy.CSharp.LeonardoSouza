using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    class PatoReal : Pato
    {
        public PatoReal(string nome) : base(nome)
        {
        }

        public override void Grasnar()
        {
            Console.WriteLine("Pato Real Grasnando");
        }

        public override void Nadar()
        {
            Console.WriteLine("Pato Real Nadando");
        }

        public override void Nadar(string forma)
        {
            Console.WriteLine("Pato Real Nadando {0}", forma);
        }

        public override void Voar()
        {
            Console.WriteLine("Pato Real Voando");
        }
    }
}
