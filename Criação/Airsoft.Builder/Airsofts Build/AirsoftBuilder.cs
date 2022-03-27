using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder.Airsofts_Build
{
    public abstract class AirsoftBuilder
    {
        protected AirsoftItem airsoft = new AirsoftItem();
        public abstract void BuildNome();
        public abstract void BuildAno();
        public abstract void BuildPreco();
        public abstract void BuildFabricante();
        public abstract void BuildPais();
        public abstract void BuildTipo();
        public abstract void BuildDistancia();
        public AirsoftItem RetornarAirsoft()
        {
            return airsoft;
        }
    }
}
