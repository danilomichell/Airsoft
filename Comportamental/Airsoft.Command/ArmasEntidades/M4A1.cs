using Airsoft.Command.Entities;
using Airsoft.Command.Entities.Armas;

namespace Airsoft.Command.ArmasEntidades;

internal class M4A1 : Rifle
{
    public M4A1(string nome, string tipo, FabricaArmas fabrica, double preco, int ano) : base(nome, tipo, fabrica,
        preco, ano)
    {
    }
}