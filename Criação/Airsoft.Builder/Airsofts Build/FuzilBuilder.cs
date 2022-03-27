using Airsoft.Builder.Airsofts_Build;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    public class FuzilBuilder : AirsoftBuilder
    {
        public override void BuildNome()
        {
            airsoft.Nome = "M4 MPW 12";
        }
        public override void BuildAno()
        {
            airsoft.Ano = "2019";
        }
        public override void BuildPreco()
        {
            airsoft.Preco = 78.95;
        }
        public override void BuildFabricante()
        {
            airsoft.NomeFabricante = "G&G";
        }
        public override void BuildPais()
        {
            airsoft.Pais = "Taiwan";
        }
        public override void BuildTipo()
        {
            airsoft.NomeTipo = "Fuzil de assalto";
        }
        public override void BuildDistancia()
        {
            airsoft.Distancia = 70;
        }
    }
}
