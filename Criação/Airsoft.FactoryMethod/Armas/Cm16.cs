namespace Airsoft.FactoryMethod.Armas;

public class Cm16 : IArma
{
    public string AlugarArma(string pessoa, double preco, int horas)
    {
        return "Aluguel: \n" +
               $"Nome Da Pessoa: {pessoa} \nTipo: Pistola \nFábrica: Amorer Works \nValor do Aluguel: R${preco} \nAno: 1911\nTempo Alugado: {horas} horas";
    }
    public string ExibirInfo()
    {
        return "Informações da arma: \n" +
               "Nome: CM16 \nTipo: Assault Rifle \nFábrica: G&G \nPreço: R$70 \nAno: 2015\n";
    }
}