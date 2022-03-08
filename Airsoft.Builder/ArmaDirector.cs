using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    internal class ArmaDirector
    {    
        public void Construct(ArmaBuilder builder,string nomeArma, int ano, float preco,String nomeFabri,string pais,string nomeTipo,int distancia)
        {
            builder.addArma(nomeArma,ano,preco,nomeFabri,pais,nomeTipo,distancia);
        }

        public void FuzilConstruct(ArmaBuilder builder)
        {
            builder.addArma("Fuzil MPW 12", 2019, 50, "G&G", "Tawian", "Fuzil assalto", 70);
        }

        public ArmaAirsoft returnAirsoft(ArmaBuilder builder)
        {
            return builder.GetAirsoft();
        }
    }
}
