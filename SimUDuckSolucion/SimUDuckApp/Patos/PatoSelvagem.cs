using System;

namespace SimUDuck.Patos
{
    public class PatoSelvagem : Pato
    {
        public PatoSelvagem(string nome) : base(nome)
        {
        }

        public override void Voar()
        {
            Console.WriteLine("Planando");
        }
    }
}
