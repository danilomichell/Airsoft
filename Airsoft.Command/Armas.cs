

using Airsoft.Command.Fabricas;
using System;

namespace Airsoft.Command
{

    public class Armas : ICommand
    {
        public Armas(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano)
        {
            Nome = nome;
            Tipo = tipo;
            Fabrica = fabrica;
            Preco = preco;
            Ano = ano;
        }

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public FabricaArmas Fabrica { get; set; }
        public double Preco { get; set; }
        public DateTime Ano { get; set; }


        public string ExibirInfo()
        {
            return $"Nome: {Nome} \nTipo: {Tipo} \nFábrica: {Fabrica.Nome} \nPreço: R${Preco} \nAno: {Ano}";
        }
        public void Execute()
        {
            ExibirInfo();
        }
    }
}