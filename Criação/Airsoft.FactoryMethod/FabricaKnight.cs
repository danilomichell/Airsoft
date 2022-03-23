namespace Airsoft.FactoryMethod;

public class FabricaKnight : FabricaArma
{
    public override IArma CriarArma()
    {
        return new M110();
    }
}