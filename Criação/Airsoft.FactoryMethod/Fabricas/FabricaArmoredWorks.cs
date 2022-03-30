using Airsoft.FactoryMethod.Armas;

namespace Airsoft.FactoryMethod.Fabricas;
public class FabricaArmoredWorks : FabricaArma
{
    public override IArma CriarArma()
    {
        return new Pitola1911();
    }
}