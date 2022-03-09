using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.AbstractFactory
{
     class M4A1 : Rifle
    {
        public string exibirInfoRifle()
        {
            return "Nome: M4A1 \nTipo: Rifle \nFábrica: G&G \nPreço: R$50 \nAno: 2018";
        }
    }
}
