using System;

namespace SimUDuck.Patos
{
    public class PatoCabecaVermelha : Pato
    {
        public PatoCabecaVermelha(string nome) : base(nome)
        {
        }

        public override void Grasnar()
        {
            Console.WriteLine("Grasnar forte");
        }

        public void Andar()
        {
            Console.WriteLine("Andando");
        }
    }
}
