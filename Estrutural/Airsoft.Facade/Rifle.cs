namespace Airsoft.Facade
{
    public class Rifle
    {
        public double Preco { get; set; } = 44.5;
        public string AlugarRifle()
        {
            return "Rifle alugado";
        }

        public double RetornarPreco()
        {
            return Preco;
        }
    }
}
