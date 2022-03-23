namespace Airsoft.Builder;

internal abstract class ArmaAbstractBuilder
{
    public abstract void addArma(string nome, int ano, float preco, string nomeFabricante, string pais, string tipo,
        int distancia);

    public abstract ArmaAirsoft GetAirsoft();
}