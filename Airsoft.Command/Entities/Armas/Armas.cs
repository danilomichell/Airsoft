using Airsoft.Command.Interfaces;

namespace Airsoft.Command.Entities.Armas
{
    public class ArmasCommand : IArmas
    {
        public ArmasCommand(string nome, string tipo, FabricaArmas fabrica, double preco, int ano)
        {
            Nome = nome;
            Tipo = tipo;
            Fabrica = fabrica;
            Preco = preco;
            Ano = ano;
        }

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }
        public int Ano { get; set; }
        public int DuracaoLocacao { get; set; } = 0;
        public FabricaArmas Fabrica { get; set; }
        public Pessoa? Locatario { get; set; }

        public string AlugarArma(Pessoa pessoa)
        {
            Locatario = pessoa;
            DuracaoLocacao = 5;
            return $"A arma foi alugada para {pessoa.Nome} e vai terminar em {DuracaoLocacao} horas";
        }

        public string ExibirInfo()
        {
            return $"Nome: {Nome} \nTipo: {Tipo} \nFábrica: {Fabrica.Nome} \nPreço: R${Preco} \nAno: {Ano}";
        }
    }
}
