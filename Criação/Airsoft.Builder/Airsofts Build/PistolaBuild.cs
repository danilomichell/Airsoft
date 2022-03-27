using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder.Airsofts_Build
{
    public class PistolalBuilder : AirsoftBuilder
    {
        public override void BuildNome()
        {
            airsoft.Nome = "1911 AW HI-CAPA 1102";
        }
        public override void BuildAno()
        {
            airsoft.Ano = "2020";
        }
        public override void BuildPreco()
        {
            airsoft.Preco = 45.7;
        }
        public override void BuildFabricante()
        {
            airsoft.NomeFabricante = "Armorer Works";
        }
        public override void BuildPais()
        {
            airsoft.Pais = "Taiwan";
        }
        public override void BuildTipo()
        {
            airsoft.NomeTipo = "Pistola";
        }
        public override void BuildDistancia()
        {
            airsoft.Distancia = 20;
        }
    }
}
