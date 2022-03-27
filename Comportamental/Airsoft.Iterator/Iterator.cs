using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Iterator
{
    public class Iterator
    {
        public List<Armas> Armas { get; set; }
        public int Idx { get; set; }

        public Iterator(List<Armas> Armas)
        {
            Idx = 0;
            this.Armas = Armas;
        }

        public bool HasNext()
        {
            return Idx < Armas.Count;
        }

        public Armas Next()
        {
            if (HasNext())
            {
                Armas arma = Armas[Idx];
                Idx++;
                return arma;
            }
            return null;
        }
    }
}
