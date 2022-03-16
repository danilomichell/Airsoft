using Airsoft.Prototype.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Prototype.Interfaces
{
    public class Rifle : Armas
    {
        public Rifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo, fabrica, preco, ano)
        {
        }
    }
}
