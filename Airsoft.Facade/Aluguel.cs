using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Facade
{
    class Aluguel
    {
        protected Pistola _pistola;
        protected Rifle _rifle;
        protected AssaultRifle _ar;

        public Aluguel(Pistola pistola, Rifle rifle, AssaultRifle ar)
        {
            this._pistola = pistola;
            this._rifle = rifle;
            this._ar = ar;
        }

        public string AlugarArmas()
        {
            string alugar = "armas alugadas: \n";
            alugar += this._pistola.AlugarPistola();
            alugar += "\n";
            alugar += this._ar.AlugarAR();
            return alugar;
        }
    }
}
