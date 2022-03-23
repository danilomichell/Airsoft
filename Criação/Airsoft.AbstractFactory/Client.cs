namespace Airsoft.AbstractFactory;

internal class Client
{
    public void Main()
    {
        ClientMethod(new FabricaGg());
    }

    public void ClientMethod(IFabricaArmas fabrica)
    {
        var prodA = fabrica.CriarAssaultRifle();

        Console.WriteLine(prodA.ExibirInfoAssaultRifle());
        Console.WriteLine();

        var prodB = fabrica.CriarPistola();

        Console.WriteLine(prodB.ExibirInfoPistola());
        Console.WriteLine();
    }
}