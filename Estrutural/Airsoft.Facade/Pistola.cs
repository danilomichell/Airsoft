namespace Airsoft.Facade
{
    public class Pistola
    {
        public double Preco { get; set; } = 34.5;
        public string AlugarPistola()
        {
            return "pistola alugada";
        }

        public double RetornarPreco()
        {
            return Preco;
        }
    }
}
