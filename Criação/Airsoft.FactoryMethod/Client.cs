using Airsoft.FactoryMethod.Fabricas;

namespace Airsoft.FactoryMethod;

public class Client
{
    public void Main()
    {
        ClientMethod(new FabricaGg());
        ClientMethod(new FabricaArmoredWorks());
        ClientMethod(new FabricaKnight());
    }

    public void ClientMethod(FabricaArma fabrica)
    {
        var arma = fabrica.CriarArma();
        var aluguel = arma.AlugarArma("Paulo", 25.00, 3);
        Console.WriteLine(arma.ExibirInfo());
        Console.WriteLine(aluguel);
    }
}