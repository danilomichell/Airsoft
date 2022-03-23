namespace Airsoft.AbstractFactory;

public class FabricaGg : IFabricaArmas
{
    public IRifle CriarRifle()
    {
        return new M4A1();
    }

    public IPistola CriarPistola()
    {
        return new Gtp9();
    }

    public IAssaultRifle CriarAssaultRifle()
    {
        return new Cm16();
    }
}