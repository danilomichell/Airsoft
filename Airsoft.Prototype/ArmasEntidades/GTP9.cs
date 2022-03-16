using Airsoft.Prototype.Fabricas;
using Airsoft.Prototype.Interfaces;

namespace Airsoft.Prototype.ArmasEnidades
{
    public class GTP9 : Pistola
    {
        public GTP9(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo, fabrica, preco, ano)
        {
        }
    }
}
