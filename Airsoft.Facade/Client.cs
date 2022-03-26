using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Facade
{
    class Client
    {
        public static void ClientMethod(Aluguel facade)
        {
            Console.WriteLine(facade.AlugarArmas());
        }
    }
}
