using Airsoft.Prototype.Fabricas;

namespace Airsoft.Prototype;

public class Client
{
    public void Main()
    {
        ClientMethod(new FabricaArmas());
    }

    public void ClientMethod(FabricaArmas fabrica)
    {
        var prodA = new FabricaArmas { Nome = "G&G" };
        var pistola = FabricaArmas.CriarPistola("GTP9", prodA, 70, DateTime.Now);

        Console.WriteLine(pistola.ExibirInfo() + "\n");

        var rifle = FabricaArmas.CriarRifle("M4A1", prodA, 70, DateTime.Now);

        Console.WriteLine(rifle.ExibirInfo() + "\n");

        var rifleClone = rifle.DeepCopy();

        rifleClone.Preco = 12;

        Console.WriteLine(rifleClone.ExibirInfo() + "\n");

        var assaultRifle = FabricaArmas.CriarAssaultRifle("CM16", prodA, 70, DateTime.Now);

        Console.WriteLine(assaultRifle.ExibirInfo() + "\n");

        var assaultShallow = assaultRifle.ShallowCopy();

        Console.WriteLine(assaultShallow.ExibirInfo() + "\n");
    }
}