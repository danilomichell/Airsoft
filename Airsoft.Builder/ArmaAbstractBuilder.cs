using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    internal abstract class ArmaAbstractBuilder
    {
        public abstract void addArma(string nome,int ano,float preco);
        public abstract void addFabricante(string nome, string pais);
        public abstract void addTipo(string nome, int distancia);
        public abstract ArmaAirsoft GetAirsoft();
    }
}
