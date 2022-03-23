namespace Airsoft.AbstractFactory;

public interface FabricaArmas
{
    public Pistola CriarPistola();
    public Rifle CriarRifle();
    public AssaultRifle CriarAssaultRifle();
}