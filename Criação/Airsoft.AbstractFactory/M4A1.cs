namespace Airsoft.AbstractFactory;

public class M4A1 : IRifle
{
    public string ExibirInfoRifle()
    {
        return "Nome: M4A1 \nTipo: Rifle \nFábrica: G&G \nPreço: R$50 \nAno: 2018";
    }
}