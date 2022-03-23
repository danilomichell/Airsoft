using System;


namespace Airsoft.Command.Fabricas
{

    public class FabricaArmas : ICommand
    {
        public string Nome { get; set; }

        public FabricaArmas(string nome)
        {
            Nome = nome;
        }


        public static Armas CriarRifle(string nome, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new Armas(nome, "Rifle", fabrica, preco, data);
        }

        public static Armas CriarPistola(string nome, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new Armas(nome, "Pistola", fabrica, preco, data);
        }

        public static Armas CriarAssaultRifle(string nome, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new Armas(nome, "AssaultRifle", fabrica, preco, data);
        }

        public void Execute()
        {
            CriarAssaultRifle();
        }
    }
}