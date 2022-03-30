namespace Airsoft.Facade
{
    public class Aluguel
    {
        private readonly Pistola _pistola;
        private readonly Rifle _rifle;
        private readonly AssaultRifle _ar;
        public double ValorTotal { get; set; }

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

        public string PrecoPistolaComRifle()
        {
            return $"O preço do aluguel de um kit pitola e rifle juntos é R${_pistola.RetornarPreco() + _rifle.RetornarPreco()}";
        }
    }
}
