using Airsoft.Command.ArmasEntidades;
using Airsoft.Command.Entities.Armas;

namespace Airsoft.Command.Entities
{
#pragma warning disable CS8618
    public class FabricaArmas
    {
        public string Nome { get; set; }

        public Rifle CriarRifle(string nome, string tipo, FabricaArmas fabrica, double preco, int data)
        {
            return new M4A1(nome, tipo, fabrica, preco, data);
        }

        public Pistola CriarPistola(string nome, string tipo, FabricaArmas fabrica, double preco, int data)
        {
            return new Gtp9(nome, tipo, fabrica, preco, data);
        }

        public AssaultRifle CriarAssaultRifle(string nome, string tipo, FabricaArmas fabrica, double preco, int data)
        {
            return new Cm16(nome, tipo, fabrica, preco, data);
        }
    }
}
