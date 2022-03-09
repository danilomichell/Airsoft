using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.AbstractFactory
{
    public interface FabricaArmas
    {
        public Pistola CriarPistola();
        public Rifle CriarRifle();
        public AssaultRifle CriarAssaultRifle();
    }
}
