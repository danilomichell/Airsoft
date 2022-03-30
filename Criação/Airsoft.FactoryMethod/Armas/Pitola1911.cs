namespace Airsoft.FactoryMethod.Armas;

public class Pitola1911 : IArma
{
    public string AlugarArma(string pessoa, double preco, int horas)
    {
        return "Aluguel: \n" +
               $"Nome Da Pessoa: {pessoa} \nTipo: Pistola \nFábrica: Amorer Works \nValor do Aluguel: R${preco} \nAno: 1911\nTempo Alugado: {horas} horas";
    }

    public string ExibirInfo()
    {
        return "Informações da arma: \n" +
               "Nome: GTP9 \nTipo: Pistola \nFábrica: Amorer Works \nPreço: R$35 \nAno: 1911\n";
    }
}