namespace Airsoft.Singleton;
#nullable disable
public class AluguelAirsoft
{
    private static AluguelAirsoft _instancia;

    protected AluguelAirsoft()
    {
    }

    public AluguelAirsoft(string nomeArma, int ano, float preco, string nomeFabri, string pais, string nomeTipo,
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
    protected float Preco { get; set; }
    protected string NomeFabricante { get; set; }
    protected string Pais { get; set; }
    protected string NomeTipo { get; set; }
    protected int Distancia { get; set; }

    public static AluguelAirsoft GetInstancia()
    {
        return _instancia ??= new AluguelAirsoft();
    }

    public AluguelAirsoft CriarAluguelFuzil()
    {
        return new AluguelAirsoft("Fuzil MPW 12", 2019, 50F, "G&G", "Tawian", "Fuzil assalto", 70);
    }

    public AluguelAirsoft CriarAluguelPistolal()
    {
        return new AluguelAirsoft("1911", 1911, 35.5F, "Amorer Works", "U.S.A", "Pistola", 30);
    }

    public AluguelAirsoft CriarAluguelFuzilPrecisao()
    {
        return new AluguelAirsoft("M110", 2008, 80F, "Knight's Armament Company", "U.S.A", "D.M.R", 100);
    }

    public void ArmasAlugadas(AluguelAirsoft arma)
    {
        Console.WriteLine($"Nome da airsoft: {arma.Nome}\nPreço: R${arma.Preco}");
    }
}