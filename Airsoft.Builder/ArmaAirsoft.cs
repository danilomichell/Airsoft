using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    internal class ArmaAirsoft
    {
        public string Nome { get; set; }
        public int Ano { get; set; }
        public float Preco { get; set; }
        public Fabricante Fabricante { get; set; }
        public Tipo Tipo { get; set; }
    }
}
