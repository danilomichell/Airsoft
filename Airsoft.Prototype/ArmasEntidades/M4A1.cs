using Airsoft.Prototype.Fabricas;
using Airsoft.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Prototype.ArmasEnidades
{
    class M4A1 : Rifle
    {
        public M4A1(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo, fabrica, preco, ano)
        {
        }
    }
}
