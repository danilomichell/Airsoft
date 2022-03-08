using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Singleton
{
    class Program
    {
        public static void Main(string[] args)
        {
            AluguelAirsoft aluguel = AluguelAirsoft.GetInstancia();

            var aluguel1 = aluguel.criarAluguelFuzil();
            var aluguel2 = aluguel.criarAluguelPistolal();
            var aluguel3 = aluguel.criarAluguelFuzilPrecisao();

            aluguel.ArmasAlugadas(aluguel1);
            aluguel.ArmasAlugadas(aluguel2);
            aluguel.ArmasAlugadas(aluguel3);
        }
    }
}
