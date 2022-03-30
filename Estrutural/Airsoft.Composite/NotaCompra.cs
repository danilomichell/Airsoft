using Airsoft.Composite.Armas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Airsoft.Composite;

public class NotaAluguel
{
    public List<Kit> Itens;
    public double ValorTotal { get; set; }
    public bool StatusNota { get; set; }
    public DateTime DiaAluguel;

    public NotaAluguel()
    {
        Itens = new List<Kit>();
    }

    public void CriarNota(int classe, int modelo, bool mira, bool silenciador, bool colete, int pistola)
    {
        Itens.Add(AddAirsoftNota(classe, modelo, mira, silenciador, colete, pistola));
        DiaAluguel = DateTime.Now;
    }

    private Kit AddAirsoftNota(int classe, int modelo, bool mira, bool silenciador, bool colete, int pistola)
    {
        var Kit = new Kit();
        switch (classe)
        {
            case 1:
                var fuzil = new AirsoftRifle();
                Kit = fuzil.CriarKitAssalt(modelo, mira, silenciador, colete, pistola);
                ValorTotal += Kit.PrecoKit;
                break;

            case 2:
                var sniper = new AirsoftFuzilPrecisao();
                Kit = sniper.CriarKitSniper(modelo, mira, colete, pistola);
                ValorTotal += Kit.PrecoKit;
                break;
        }

        return Kit;

    }

    public void Pagamento(int tipoOp, double valor, int dividir)
    {
        switch (tipoOp)
        {
            case 0:
                if (valor == ValorTotal)
                {
                    Console.WriteLine($"Valor recebido no pagamento: R$ {Math.Round(valor, 2)}");
                    Console.WriteLine("O aluguel foi pago na sua totalidade. Não precisará de troco.");
                    StatusNota = true;
                }
                else if (valor > ValorTotal)
                {
                    double troco = valor - ValorTotal;
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
                    double valorParc = ValorTotal / dividir;
                    Console.WriteLine($"Valor total: {Math.Round(ValorTotal, 2)} dividido para {dividir} vezes de R${Math.Round(valorParc, 2)}");
                }
                break;
        }
    }
}