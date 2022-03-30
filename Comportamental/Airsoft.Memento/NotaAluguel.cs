using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Airsoft.Memento
{
    public class NotaAluguel
    {
        public List<AirsoftItem> Pedido;
        public bool Status { get; set; }
        public double PrecoPedido { get; set; }
        public DateTime DiaAluguel;
        public DateTime DiaPagamento;
        public DateTime HorarioSalvamento;

        public NotaAluguel()
        {
            Pedido = new List<AirsoftItem>();
            DiaAluguel = DateTime.Now;
        }

        public void AddAirsoftNota(int tipoAirsoft)
        {
            switch (tipoAirsoft) { 

                case 1:
                    var pistola = new AirsoftItem()
                    {
                        Nome = "1911 AW1102",
                        Ano = "2020",
                        Preco = 40.80,
                        Fabricante = "Armorer Workrs",
                        Pais = "Taiwan",
                        Tipo = "Pistola",
                        Distancia = 30
                    };
                    PrecoPedido += pistola.Preco;
                    Pedido.Add(pistola);
                    Console.WriteLine($"{pistola.Tipo} {pistola.Nome} de airsoft adicionado ao pedido.");
                    break;

                case 2:
                    var rifle = new AirsoftItem
                    {
                        Nome = "M4 MPW 12",
                        Ano = "2019",
                        Preco = 70.00,
                        Fabricante = "G&G",
                        Pais = "Taiwan",
                        Tipo = "Rifle de assalto",
                        Distancia = 60
                    };
                    PrecoPedido += rifle.Preco;
                    Pedido.Add(rifle);
                    Console.WriteLine($"{rifle.Tipo} {rifle.Nome} de airsoft adicionado ao pedido.");
                    break;

                case 3:
                    var sniper = new AirsoftItem
                    {
                        Nome = "M24",
                        Ano = "2020",
                        Preco = 85.90,
                        Fabricante = "Tokio Marui",
                        Pais = "Japão",
                        Tipo = "Fuzil de precisão",
                        Distancia = 100
                    };
                    PrecoPedido += sniper.Preco;
                    Pedido.Add(sniper);
                    Console.WriteLine($"{sniper.Tipo} {sniper.Nome} de airsoft adicionado ao pedido.");
                    break;
            }
        }

        public void Pagamento(int tipoOp,double pagamento,int dividir)
        {
            DiaPagamento = DateTime.Now;
            switch (tipoOp)
            {
                case 0:
                    if (pagamento == PrecoPedido)
                    {
                        Console.WriteLine($"Valor recebido no pagamento: R$ {Math.Round(pagamento, 2)}");
                        Console.WriteLine("O aluguel foi pago na sua totalidade. Não precisará de troco.");
                        Console.WriteLine($"Data pagamento: {DiaPagamento}");
                        Status = true;
                    }
                    else if (pagamento > PrecoPedido)
                    {
                        double troco = pagamento - PrecoPedido;
                        Console.WriteLine($"Valor recebido no pagamento: R$ {Math.Round(pagamento, 2)}");
                        Console.WriteLine($"O aluguel foi pago na sua totalidade. O troco será de: R$ {troco}");
                        Console.WriteLine($"Data pagamento: {DiaPagamento}");
                        Status = true;
                    }
                    break;

                case 1:
                    if (dividir > 5)
                    {
                        Console.WriteLine("Quantidade de parcelas maior que o aceitável.");
                    }
                    else
                    {
                        Status = true;
                        double valorParc = PrecoPedido / dividir;
                        Console.WriteLine($"Valor total: {Math.Round(PrecoPedido, 2)} dividido para {dividir} vezes de R${Math.Round(valorParc,2)}");
                    }
                    break;
            }
        }

        public NotaMemento CriarMemento()
        {
            HorarioSalvamento = DateTime.Now;
            Console.WriteLine("Nota salva!");
            return new NotaMemento(Pedido, Status, PrecoPedido, DiaAluguel);
        }

        public void RetornarNotaAnterior(NotaMemento notaMemento)
        {
            Console.WriteLine($"Nota recuperada a partir do seu último salvamento feito em {HorarioSalvamento}.");
            Pedido = notaMemento.RetornarListaAnterior();
            PrecoPedido = notaMemento.RetornarPrecoAnterior();
            Status = notaMemento.RetornarStatusAnterior();
            HorarioSalvamento = DateTime.Now;
        }

    }
}
