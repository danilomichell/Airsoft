using Airsoft.Command.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Command.Interfaces
{
    public interface IArmas
    {
        string ExibirInfo();
        string AlugarArma(Pessoa pessoa);
    }
}
