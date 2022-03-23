namespace Airsoft.FactoryMethod;

public class Pitola1911 : IArma
{
    public string ExibirInfo()
    {
        return "Informações da arma: \n" +
               "Nome: GTP9 \nTipo: Pistola \nFábrica: Amorer Works \nPreço: R$35 \nAno: 1911\n";
    }
}