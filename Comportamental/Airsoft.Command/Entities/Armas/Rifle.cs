namespace Airsoft.Command.Entities.Armas;

public class Rifle : ArmasCommand
{
    public Rifle(string nome, string tipo, FabricaArmas fabrica, double preco, int ano) : base(nome, tipo, fabrica,
        preco, ano)
    {
    }
}