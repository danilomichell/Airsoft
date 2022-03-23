namespace Airsoft.Composite.Armas;

internal class Arma
{
    public ArmaAirsoft AdicionarRifle()
    {
        var rifle = new ArmaAirsoft
        {
            Nome = "M4 MPW 12",
            Ano = "2019",
            Preco = 70.00,
            Fabricante = "G&G",
            Pais = "Taiwan",
            Tipo = "Rifle de assalto",
            Distancia = 60
        };
        return rifle;
    }

    public ArmaAirsoft AdicionarPistola()
    {
        var pistola = new ArmaAirsoft
        {
            Nome = "1911 AW1102",
            Ano = "2020",
            Preco = 40.80,
            Fabricante = "Armorer Workrs",
            Pais = "Taiwan",
            Tipo = "Pistola",
            Distancia = 30
        };
        return pistola;
    }

    public ArmaAirsoft AdicionarSniper()
    {
        var sniper = new ArmaAirsoft
        {
            Nome = "M24",
            Ano = "2020",
            Preco = 85.90,
            Fabricante = "Tokio Marui",
            Pais = "Japão",
            Tipo = "Fuzil de precisão",
            Distancia = 100
        };
        return sniper;
    }

    public ArmaAirsoft AdicionarArmaManual(string nome, string ano, double preco, string fabricante, string pais,
        string tipo, int distancia)
    {
        var novaArma = new ArmaAirsoft
        {
            Nome = nome,
            Ano = ano,
            Preco = preco,
            Fabricante = fabricante,
            Pais = pais,
            Tipo = tipo,
            Distancia = distancia
        };
        return novaArma;
    }
}