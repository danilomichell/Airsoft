namespace Airsoft.Singleton;

internal class Program
{
    public static void Main(string[] args)
    {
        var aluguel = AluguelAirsoft.GetInstancia();

        var aluguel1 = aluguel.criarAluguelFuzil();
        var aluguel2 = aluguel.criarAluguelPistolal();
        var aluguel3 = aluguel.criarAluguelFuzilPrecisao();

        aluguel.ArmasAlugadas(aluguel1);
        aluguel.ArmasAlugadas(aluguel2);
        aluguel.ArmasAlugadas(aluguel3);
    }
}