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
        public List<AirsoftItem> pedido;
        public bool Status { get; set; }
        public double PrecoPedido { get; set; }

        public void AddAirsoftNota(int tipoAirsoft)
        {
            var airsoftsPedido = new List<AirsoftItem>();
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
                    airsoftsPedido.Add(pistola);
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
                    airsoftsPedido.Add(rifle);
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
                    airsoftsPedido.Add(sniper);
                    Console.WriteLine($"{sniper.Tipo} {sniper.Nome} de airsoft adicionado ao pedido.");
                    break;
            }
        }

        public bool Pagamento(double pagamento)
        {
            if (pagamento == PrecoPedido)
            {
                Status = true;
                Console.WriteLine("A nota foi paga na totalidade e não terá troco.");
            }
            else if (pagamento > PrecoPedido)
            {
                Status = true;
                var troco = pagamento - PrecoPedido;
                Console.WriteLine($"A nota foi paga na totalidade e o troco será de R${troco}.");
            }

            return Status;
        }

        public NotaMemento CriarMemento()
        {
            Console.WriteLine("Nota salva!");
            return new NotaMemento(pedido, Status, PrecoPedido);
        }

        public void RetornarNotaAnterior(NotaMemento notaMemento)
        {
            Console.WriteLine("Nota recuperada a partir do seu último salvamento.");
            pedido = notaMemento.RetornarListaAnterior();
            PrecoPedido = notaMemento.RetornarPrecoAnterior();
            Status = notaMemento.RetornarStatusAnterior();
        }

    }
}
