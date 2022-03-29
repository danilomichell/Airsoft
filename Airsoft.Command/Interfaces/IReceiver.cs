using Airsoft.Command.Entities;
using Airsoft.Command.Entities.Armas;

namespace Airsoft.Command.Interfaces
{
    public interface IReceiver<T> where T : ArmasCommand
    {
        string Handle(T command);
        string Alugar(T command, Pessoa pessoa);
    }
}
