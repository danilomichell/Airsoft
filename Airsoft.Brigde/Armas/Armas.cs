using Airsoft.Bridge.Fabricas;

namespace Airsoft.Bridge.Armas;

public class Armas : IArmas
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
}