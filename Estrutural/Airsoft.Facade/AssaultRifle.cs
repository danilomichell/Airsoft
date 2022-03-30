namespace Airsoft.Facade
{
    public class AssaultRifle
    {
        public double Preco { get; set; } = 45;
        public string AlugarAR()
        {
            return "rifle de assalto alugado";
        }

        public double RetornarPreco() => Preco;
    }
}
