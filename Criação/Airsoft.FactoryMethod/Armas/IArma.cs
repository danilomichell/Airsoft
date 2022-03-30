namespace Airsoft.FactoryMethod.Armas;

public interface IArma
{
    string ExibirInfo();

    string AlugarArma(string pessoa, double preco, int horas);
}