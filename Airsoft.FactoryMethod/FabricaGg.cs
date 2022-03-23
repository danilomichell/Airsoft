namespace Airsoft.FactoryMethod
{
    public class FabricaGg : FabricaArma
    {
        public override IArma CriarArma()
        {
            return new Cm16();
        }
    }
}
