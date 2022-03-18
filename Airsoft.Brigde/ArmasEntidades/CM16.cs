using Airsoft.Bridge.Armas;
using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge.ArmasEnidades
{
    public class CM16 : AssaultRifle
    {
        public CM16(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo, fabrica, preco, ano)
        {
        }
    }
}
