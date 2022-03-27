using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Composite
{
    public class Kit
    {
        public ArmaAirsoft Plataforma { get; set; }
        public ArmaAirsoft? Secundaria { get; set; }
        public bool? MiraOptica { get; set; }
        public bool? Silenciador { get; set; }
        public bool? Colete { get; set; }
        public double PrecoKit { get; set; }
    }
}
