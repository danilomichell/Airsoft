namespace Airsoft.Builder;

internal class ArmaBuilder : ArmaAbstractBuilder
{
    private readonly ArmaAirsoft armaAirsoft = new();

    public override void addArma(string nome, int ano, float preco, string nomeFabricante, string pais, string tipo,
        int distancia)
    {
        armaAirsoft.Nome = nome;
        armaAirsoft.Ano = ano;
        armaAirsoft.Preco = preco;
        armaAirsoft.NomeFabricante = nomeFabricante;
        armaAirsoft.Pais = pais;
        armaAirsoft.NomeTipo = tipo;
        armaAirsoft.Distancia = distancia;
    }

    public override ArmaAirsoft GetAirsoft()
    {
        return armaAirsoft;
    }
}