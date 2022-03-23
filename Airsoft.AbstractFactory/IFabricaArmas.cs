namespace Airsoft.AbstractFactory;

public interface IFabricaArmas
{
    public IPistola CriarPistola();
    public IRifle CriarRifle();
    public IAssaultRifle CriarAssaultRifle();
}