namespace Airsoft.Singleton;
#nullable disable
public class AluguelAirsoft
{
    private static AluguelAirsoft _instancia;

    protected AluguelAirsoft()
    {
        Itens = new List<AluguelAirsoft>();
    }

    public AluguelAirsoft(string nomeArma, int ano, double preco, string nomeFabri, string pais, string nomeTipo,
        int distancia)
    {
        Nome = nomeArma;
        Ano = ano;
        Preco = preco;
        NomeFabricante = nomeFabri;
        Pais = pais;
        NomeTipo = nomeTipo;
        Distancia = distancia;
    }

    protected string Nome { get; set; }
    protected int Ano { get; set; }
    protected double Preco { get; set; }
    protected string NomeFabricante { get; set; }
    protected string Pais { get; set; }
    protected string NomeTipo { get; set; }
    protected int Distancia { get; set; }
    public double PrecoAluguel { get; set; }
    public bool StatusAluguel { get; set; }

    public List<AluguelAirsoft> Itens;

    public static AluguelAirsoft GetInstancia()
    {
        return _instancia ??= new AluguelAirsoft();
    }

    public void CriarAluguelFuzil()
    {
        var airsoft = new AluguelAirsoft("Fuzil MPW 12", 2019, 50.98, "G&G", "Tawian", "Fuzil assalto", 70);
        Itens.Add(airsoft);
        PrecoAluguel += airsoft.Preco;
    }

    public void CriarAluguelPistolal()
    {
        var airsoft = new AluguelAirsoft("1911", 1911, 35.5, "Amorer Works", "U.S.A", "Pistola", 30);
        Itens.Add(airsoft);
        PrecoAluguel += airsoft.Preco;
    }

    public void CriarAluguelFuzilPrecisao()
    {
        var airsoft = new AluguelAirsoft("M110", 2008, 84.65, "Knight's Armament Company", "U.S.A", "D.M.R", 100);
        Itens.Add(airsoft);
        PrecoAluguel += airsoft.Preco;
    }

    public void ArmasAlugadas(AluguelAirsoft arma)
    {
        Console.WriteLine($"Nome da airsoft: {arma.Nome}\nPreço: R${arma.Preco}");
    }

    public void Pagamento(double valor)
    {
        if (valor == PrecoAluguel)
        {
            Console.WriteLine($"Valor recebido no pagamento: R$ {valor}");
            Console.WriteLine("O aluguel foi pago na sua totalidade. Não precisará de troco.");
            StatusAluguel = true;
        }
        else if (valor > PrecoAluguel)
        {
            double troco = valor - PrecoAluguel;
            Console.WriteLine($"Valor recebido no pagamento: R$ {valor}");
            Console.WriteLine($"O aluguel foi pago na sua totalidade. O troco será de: R$ {troco}");
            StatusAluguel = true;
        }
    }
}