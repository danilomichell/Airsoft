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

    public void Pagamento(int tipoOp, double valor, int dividir)
    {
        switch (tipoOp)
        {
            case 0:
                if (valor == PrecoAluguel)
                {
                    Console.WriteLine($"Valor recebido no pagamento: R$ {Math.Round(valor, 2)}");
                    Console.WriteLine("O aluguel foi pago na sua totalidade. Não precisará de troco.");
                    StatusNota = true;
                }
                else if (valor > PrecoAluguel)
                {
                    double troco = valor - PrecoAluguel;
                    Console.WriteLine($"Valor recebido no pagamento: R$ {Math.Round(valor, 2)}");
                    Console.WriteLine($"O aluguel foi pago na sua totalidade. O troco será de: R$ {troco}");
                    StatusNota = true;
                }
                break;

            case 1:
                if (dividir > 5)
                {
                    Console.WriteLine("Quantidade de parcelas maior que o aceitável.");
                }
                else
                {
                    StatusNota = true;
                    double valorParc = PrecoAluguel / dividir;
                    Console.WriteLine($"Valor total: {Math.Round(PrecoAluguel, 2)} dividido para {dividir} vezes de R${Math.Round(valorParc, 2)}");
                }
                break;
        }
    }

    public AirsoftItem RetornarAirsoft()
    {
        return Builder.RetornarAirsoft();
    }
}