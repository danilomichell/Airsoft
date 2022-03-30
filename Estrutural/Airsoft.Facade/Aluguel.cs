namespace Airsoft.Facade
{
    public class Aluguel
    {
        private readonly Pistola _pistola;
        private readonly Rifle _rifle;
        private readonly AssaultRifle _ar;

        public Aluguel()
        {
            _pistola = new Pistola();
            _rifle = new Rifle();
            _ar = new AssaultRifle();
        }

        public string AlugarArmas()
        {
            var alugar = "armas alugadas: \n";
            alugar += _pistola.AlugarPistola();
            alugar += "\n";
            alugar += _ar.AlugarAR();
            alugar += "\n";
            alugar += _rifle.AlugarRifle();
            return alugar;
        }
    }
}
