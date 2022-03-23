namespace Airsoft.Builder;

internal class ArmaDirector
{
    public void Construct(ArmaBuilder builder, string nomeArma, int ano, float preco, string nomeFabri, string pais,
        string nomeTipo, int distancia)
    {
        builder.AddArma(nomeArma, ano, preco, nomeFabri, pais, nomeTipo, distancia);
    }

    public void FuzilConstruct(ArmaBuilder builder)
    {
        builder.AddArma("Fuzil MPW 12", 2019, 50, "G&G", "Tawian", "Fuzil assalto", 70);
    }

    public ArmaAirsoft ReturnAirsoft(ArmaBuilder builder)
    {
        return builder.GetAirsoft();
    }
}