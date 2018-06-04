using System;
using SimUDuck.Patos;

namespace SimUDuck
{
    public class Simulador
    {
        public void Executar(Pato pato)
        {
            Console.WriteLine(pato.Nome);
            pato.Grasnar();
            pato.Nadar();
            pato.Voar();
            Console.WriteLine();
        }
    }
}
