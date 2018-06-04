using SimUDuck.Patos;
using System.Collections.Generic;

namespace SimUDuck.Fabrica
{
    public class FabricaPatos<T>
    {
        public List<PatoSelvagem> ObterPatos()
        {
            List<PatoSelvagem> patos = new List<PatoSelvagem>();
            patos.Add(new PatoSelvagem("Pato Selvagem"));
            return patos;
        }
    }
}
