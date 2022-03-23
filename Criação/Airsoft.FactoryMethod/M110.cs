namespace Airsoft.FactoryMethod;

public class M110 : IArma
{
    public string ExibirInfo()
    {
        return "Informações da arma: \n" + "Nome: M4A1 \nTipo: Fuzil de precisão \nFábrica: Knight's Armament Company \nPreço: R$80 \nAno: 2008\n";
    }
}