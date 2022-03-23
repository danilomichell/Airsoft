using Airsoft.Bridge.Armas;
using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge.ArmasEntidades;

internal class M4A1 : Rifle
{
    public M4A1(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo, fabrica,
        preco, ano)
    {
    }
}