namespace Airsoft.FactoryMethod;

public class Cm16 : IArma
{
    public string ExibirInfo()
    {
        return "Informações da arma: \n" +
               "Nome: CM16 \nTipo: Assault Rifle \nFábrica: G&G \nPreço: R$70 \nAno: 2015\n";
    }
}