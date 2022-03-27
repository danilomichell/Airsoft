#nullable disable
using Airsoft.Builder.Airsofts_Build;

namespace Airsoft.Builder;

public class NotaAluguelDiretor
{
    public List<AirsoftItem> Itens;
    public double PrecoAluguel { get; set; }
    public bool StatusNota  = false;
    public AirsoftBuilder Builder;

    public NotaAluguelDiretor()
    {
        Itens = new List<AirsoftItem>();
    }

    public void AddItemLista()
    {
        Builder.BuildNome();
        Builder.BuildAno();
        Builder.BuildPreco();
        Builder.BuildFabricante();
        Builder.BuildPais();
        Builder.BuildTipo();
        Builder.BuildDistancia();
        Itens.Add(RetornarAirsoft());
        PrecoAluguel += RetornarAirsoft().Preco;

    }

    public void Pagamento(double valor)
    {
        if (valor == PrecoAluguel)
        {
            Console.WriteLine($"Valor recebido no pagamento: R$ {valor}");
            Console.WriteLine("O aluguel foi pago na sua totalidade. Não precisará de troco.");
            StatusNota = true;
        }
        else if (valor > PrecoAluguel)
        {
            double troco = valor - PrecoAluguel;
            Console.WriteLine($"Valor recebido no pagamento: R$ {valor}");
            Console.WriteLine($"O aluguel foi pago na sua totalidade. O troco será de: R$ {troco}");
            StatusNota = true;
        }
    }

    public AirsoftItem RetornarAirsoft()
    {
        return Builder.RetornarAirsoft();
    }
}