using Airsoft.Command.Entities;

namespace Airsoft.Command;

internal class Client
{
    public void Main()
    {
        ClientMethod(new FabricaArmas());
    }

    public static void ClientMethod(FabricaArmas fabrica)
    {
        var prodA = new FabricaArmas {Nome = "G&G"};
        var pistola = prodA.CriarPistola("GTP9", "Pistola", prodA, 70, 1998);
        var pessoa = new Pessoa(1, "Paulo", DateTime.Now);
        var receiver = new Receiver();

        Console.WriteLine(receiver.Handle(pistola));
        Console.WriteLine(receiver.Alugar(pistola, pessoa));
        Console.WriteLine();
    }
}