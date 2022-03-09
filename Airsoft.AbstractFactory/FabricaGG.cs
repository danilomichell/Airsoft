using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Airsoft.AbstractFactory
{
    public class FabricaGG : FabricaArmas
    {
        public Rifle CriarRifle()
        {
            return new M4A1();
        }

        public Pistola CriarPistola()
        {
            return new GTP9();
        }

        public AssaultRifle CriarAssaultRifle()
        {
            return new CM16();
        }
    }
}