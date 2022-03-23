using Airsoft.Prototype.Interfaces;

#nullable disable
namespace Airsoft.Prototype.Fabricas;

public class FabricaArmas
{
    public string Nome { get; set; }

    public static Armas CriarRifle(string nome, FabricaArmas fabrica, double preco, DateTime data)
    {
        return new Armas(nome, "Rifle", fabrica, preco, data);
    }

    public static Armas CriarPistola(string nome, FabricaArmas fabrica, double preco, DateTime data)
    {
        return new Armas(nome, "Pistola", fabrica, preco, data);
    }

    public static Armas CriarAssaultRifle(string nome, FabricaArmas fabrica, double preco, DateTime data)
    {
        return new Armas(nome, "AssaultRifle", fabrica, preco, data);
    }
}