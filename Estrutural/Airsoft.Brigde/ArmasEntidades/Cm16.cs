using Airsoft.Bridge.Armas;
using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge.ArmasEntidades;

public class Cm16 : AssaultRifle
{
    public Cm16(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo, fabrica,
        preco, ano)
    {
    }
}