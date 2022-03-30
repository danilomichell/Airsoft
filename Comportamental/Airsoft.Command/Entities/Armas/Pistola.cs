namespace Airsoft.Command.Entities.Armas;

public class Pistola : ArmasCommand
{
    public Pistola(string nome, string tipo, FabricaArmas fabrica, double preco, int ano) : base(nome, tipo,
        fabrica, preco, ano)
    {
    }
}