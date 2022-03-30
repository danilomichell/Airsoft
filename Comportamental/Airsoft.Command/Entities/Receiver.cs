using Airsoft.Command.Interfaces;
using Airsoft.Command.Entities.Armas;

namespace Airsoft.Command.Entities
{
    public class Receiver : IReceiver<ArmasCommand>
    {
        public string Alugar(ArmasCommand command, Pessoa pessoa)
        {
            return command.AlugarArma(pessoa);
        }

        public string Handle(ArmasCommand command)
        {
            return command.ExibirInfo();
        }
    }
}
