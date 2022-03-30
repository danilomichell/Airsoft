namespace Airsoft.Command.Entities.Armas;

public class AssaultRifle : ArmasCommand
{
    public AssaultRifle(string nome, string tipo, FabricaArmas fabrica, double preco, int ano) : base(nome, tipo, fabrica, preco, ano)
    {
    }
}