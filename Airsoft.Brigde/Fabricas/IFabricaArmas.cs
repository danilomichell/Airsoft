using Airsoft.Bridge.Armas;
using Airsoft.Bridge.Fabricas;

namespace Airsoft.Brigde.Fabricas;

public interface IFabricaArmas
{
    public Rifle CriarRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data);

    public Pistola CriarPistola(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data);

    public AssaultRifle CriarAssaultRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data);
}