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
        Console.WriteLine(arma.exibirInfo());
    }
}