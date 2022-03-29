using Airsoft.Command.Entities;
using Airsoft.Command.Entities.Armas;

namespace Airsoft.Command.ArmasEntidades;

public class Gtp9 : Pistola
{
    public Gtp9(string nome, string tipo, FabricaArmas fabrica, double preco, int ano) : base(nome, tipo, fabrica,
        preco, ano)
    {
    }
}