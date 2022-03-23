namespace Airsoft.AbstractFactory;

internal class Client
{
    public void Main()
    {
        ClientMethod(new FabricaGG());
    }

    public void ClientMethod(FabricaArmas fabrica)
    {
        var prodA = fabrica.CriarAssaultRifle();

        Console.WriteLine(prodA.exibirInfoAssaultRifle());
        Console.WriteLine();

        var prodB = fabrica.CriarPistola();

        Console.WriteLine(prodB.exibirInfoPistola());
        Console.WriteLine();
    }
}