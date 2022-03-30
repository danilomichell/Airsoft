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
            alugar += "\n";
            alugar += $"Valor de R${_pistola.RetornarPreco() + _ar.RetornarPreco() + _rifle.RetornarPreco()}";
            return alugar;
        }

        public string PrecoKit()
        {
            return $"O preço do aluguel de um kit é R${_pistola.RetornarPreco() + _ar.RetornarPreco() + _rifle.RetornarPreco()}";
        }
    }
}
