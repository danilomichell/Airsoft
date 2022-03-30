using Airsoft.FactoryMethod.Armas;

namespace Airsoft.FactoryMethod.Fabricas;

public class FabricaGg : FabricaArma
{
    public override IArma CriarArma()
    {
        return new Cm16();
    }
}