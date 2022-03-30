using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge;

internal class Client
{
    public double ValorTotal { get; set; }
    public void Main()
    {
        ClientMethod(new FabricaArmas());
    }

    public void ClientMethod(FabricaArmas fabrica)
    {
        var prodA = new FabricaArmas {Nome = "G&G"};
        var pistola = prodA.CriarPistola("GTP9", "Pistola", prodA, 70, DateTime.Now);
        ValorTotal += pistola.Preco;

        Console.WriteLine(pistola.ExibirInfo());
        Console.WriteLine();

        var rifle = prodA.CriarRifle("GTP9", "Rifle", prodA, 70, DateTime.Now);
        ValorTotal += rifle.Preco;

        Console.WriteLine(rifle.ExibirInfo());
        Console.WriteLine();

        Console.WriteLine($"Valor total do aluguel: R${ValorTotal}");
    }
}