using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder.Airsofts_Build
{
    public class SniperBuild : AirsoftBuilder
    {
        public override void BuildNome()
        {
            airsoft.Nome = "M110";
        }
        public override void BuildAno()
        {
            airsoft.Ano = "2018";
        }
        public override void BuildPreco()
        {
            airsoft.Preco = 130;
        }
        public override void BuildFabricante()
        {
            airsoft.NomeFabricante = "Ares";
        }
        public override void BuildPais()
        {
            airsoft.Pais = "E.U.A";
        }
        public override void BuildTipo()
        {
            airsoft.NomeTipo = "Fuzil de precisão";
        }
        public override void BuildDistancia()
        {
            airsoft.Distancia = 100;
        }
    }
}
