using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.AbstractFactory
{
    internal class GTP9: Pistola
    {
        public string exibirInfoPistola()
        {
            return "Nome: GTP9 \nTipo: Pistola \nFábrica: G&G \nPreço: R$30 \nAno: 2019";
        }

    }
}
