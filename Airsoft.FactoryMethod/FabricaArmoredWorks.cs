namespace Airsoft.FactoryMethod
{
    public class FabricaArmoredWorks : FabricaArma
    {
        public override IArma CriarArma()
        {
            return new Pitola1911();
        }
    }
}
