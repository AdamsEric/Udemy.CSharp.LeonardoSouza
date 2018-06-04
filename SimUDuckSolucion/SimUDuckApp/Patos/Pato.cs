using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    public abstract class Pato : IPato
    {
        #region Atributos

        private string _Nome;

        #endregion

        #region Construtores

        public Pato(string nome)
        {
            this._Nome = nome;
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            get
            {
                return this._Nome;
            }
            set
            {
                this._Nome = value;
            }
        }

        #endregion

        #region Metodos

        public virtual void Grasnar()
        {
            Console.WriteLine("Grasnando");
        }

        public virtual void Voar()
        {
            Console.WriteLine("Voando");
        }

        public virtual void Nadar()
        {
            Console.WriteLine("Nadando");
        }

        public virtual void Nadar(string forma)
        {
            Console.WriteLine("Nadando {0}", forma);
        }

        #endregion

    }
}