namespace Airsoft.FactoryMethod.Armas;

public class M110 : IArma
{
    public string AlugarArma(string pessoa, double preco, int horas)
    {
        return "Aluguel: \n" +
               $"Nome Da Pessoa: {pessoa} \nTipo: Pistola \nFábrica: Amorer Works \nValor do Aluguel: R${preco} \nAno: 1911\nTempo Alugado: {horas} horas";
    }
    public string ExibirInfo()
    {
        return "Informações da arma: \n" +
               "Nome: M4A1 \nTipo: Fuzil de precisão \nFábrica: Knight's Armament Company \nPreço: R$80 \nAno: 2008\n";
    }
}