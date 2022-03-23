using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge.Armas;

public class AssaultRifle : Armas
{
    public AssaultRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano) : base(nome, tipo,
        fabrica, preco, ano)
    {
    }
}