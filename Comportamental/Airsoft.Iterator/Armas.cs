using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Iterator
{
    public class Armas
    {
        public string Nome { get; set; }
        public float Valor { get; set; }
        public int Ano { get; set; }

        public Armas(string Nome, float Valor, int Ano)
        {
            this.Nome = Nome;
            this.Valor = Valor; 
            this.Ano = Ano;
        }

        public string ArmaToString()
        {
            return $"{Nome}: R${Valor} - Fabricada em {Ano}";
        }
    }
}
