using SimUDuck.Patos;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pato patoSelvagem = new PatoSelvagem();
            //Console.WriteLine("Pato Selvagem");
            //patoSelvagem.Grasnar();
            //patoSelvagem.Voar();
            //patoSelvagem.Nadar();
            //Console.WriteLine();

            //PatoCabecaVermelha patoCabecaVermelha = new PatoCabecaVermelha();
            //Console.WriteLine("Pato Cabeça Vermelha");
            //patoCabecaVermelha.Grasnar();
            //patoCabecaVermelha.Voar();
            //patoCabecaVermelha.Nadar();
            //patoCabecaVermelha.Nadar("cachorrinho");
            //patoCabecaVermelha.Andar(); // Classe "Pato" não contém uma definição do método Andar

            Simulador simulador = new Simulador();
            simulador.Executar(new PatoSelvagem("Pato Selvagem"));
            simulador.Executar(new PatoCabecaVermelha("Pato Cabeça Vermelha"));
            simulador.Executar(new PatoReal("Pato Real"));

            PatoReal patoReal = new PatoReal("Pato Real");
            PatoSelvagem patoSelvagem = new PatoSelvagem("Pato Selvagem");

            Console.ReadLine();
        }
    }
}