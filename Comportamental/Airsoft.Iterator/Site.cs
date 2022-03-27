using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Iterator
{
    public class Site
    {
        public List<Armas> Armas { get; set; }

        public Site()
        {
            Armas = new List<Armas>();
        }

        public void AddArma(Armas arma)
        {
            Armas.Add(arma);
        }

        public void RemoveArma()
        {
            Armas.RemoveAt(0);
        }

        public void PrintLista()
        {
            foreach (Armas arma in Armas)
            {
                Console.WriteLine(arma.ArmaToString());
            }
        }

        public Iterator CreateIterator()
        {
            Iterator iterator = new Iterator(Armas);
            return iterator;
        }
    }
}
