namespace Airsoft.Builder;

internal class ArmaBuilder : ArmaAbstractBuilder
{
    private readonly ArmaAirsoft _armaAirsoft = new();

    public override void AddArma(string nome, int ano, float preco, string nomeFabricante, string pais, string tipo,
        int distancia)
    {
        _armaAirsoft.Nome = nome;
        _armaAirsoft.Ano = ano;
        _armaAirsoft.Preco = preco;
        _armaAirsoft.NomeFabricante = nomeFabricante;
        _armaAirsoft.Pais = pais;
        _armaAirsoft.NomeTipo = tipo;
        _armaAirsoft.Distancia = distancia;
    }

    public override ArmaAirsoft GetAirsoft()
    {
        return _armaAirsoft;
    }
}