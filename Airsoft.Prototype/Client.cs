using Airsoft.Prototype.ArmasEnidades;
using Airsoft.Prototype.Fabricas;
using Airsoft.Prototype.Interfaces;

namespace Airsoft.Prototype
{
    class Client
    {
        public void Main()
        {
            ClientMethod(new FabricaGG());
        }

        public void ClientMethod(FabricaArmas fabrica)
        {

            var prodA = new FabricaArmas() {Nome = "G&G"};
            var pistola = FabricaArmas.CriarPistola("GTP9", "Pistola", prodA, 70, DateTime.Now);

            Console.WriteLine(pistola.ExibirInfo());
            Console.WriteLine();

            
            var rifle = FabricaArmas.CriarRifle("GTP9", "Rifle", prodA, 70, DateTime.Now);       

            Console.WriteLine(rifle.ExibirInfo());
            Console.WriteLine();

            rifle.DeepCopy();
        }
    }
}
