﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.AbstractFactory
{
    internal class CM16: AssaultRifle
    {
        public string exibirInfoAssaultRifle()
        {
            return "Nome: CM16 \nTipo: Assault Rifle \nFábrica: G&G \nPreço: R$70 \nAno: 2015";
        }
    }
}