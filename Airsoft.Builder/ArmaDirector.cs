using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    internal class ArmaDirector
    {
        public void Construct(ArmaBuild builder,string nomeArma, int ano, float preco,String nomeFabri,string pais,string nomeTipo,int distancia)
        {
            builder.addArma(nomeArma,ano,preco);
            builder.addFabricante(nomeFabri,pais);
            builder.addTipo(nomeTipo,distancia);
        }
    }
}
