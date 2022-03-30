using Airsoft.FactoryMethod.Armas;

namespace Airsoft.FactoryMethod.Fabricas;

public class FabricaKnight : FabricaArma
{
    public override IArma CriarArma()
    {
        return new M110();
    }
}