using Airsoft.Prototype.ArmasEnidades;
using Airsoft.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618
namespace Airsoft.Prototype.Fabricas
{
    public class FabricaArmas
    {
        public string Nome { get; set; }

        public static Rifle CriarRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new M4A1(nome, tipo, fabrica, preco, data);
        }

        public static Pistola CriarPistola(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new GTP9(nome, tipo, fabrica, preco, data);
        }

        public static AssaultRifle CriarAssaultRifle(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime data)
        {
            return new CM16(nome, tipo, fabrica, preco, data);
        }
    }
}
