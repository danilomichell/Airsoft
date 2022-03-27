using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Airsoft.Composite.Armas;

public class AirsoftRifle : AirsoftPistola
{
    public Kit CriarKitAssalt(int plataforma, bool mira, bool silenciador, bool colete, int pistola)
    {
        var KitAssalt = new Kit
        {
            Plataforma = AdicionarRifle(plataforma),
            MiraOptica = mira,
            Silenciador = silenciador,
            Colete = colete
        };

        if (pistola > 0 && pistola <= 3)
        {
            KitAssalt.Secundaria = AdicionarPistola(pistola);
            KitAssalt.PrecoKit += KitAssalt.Secundaria.Preco;
        }
        else
        {
            KitAssalt.PrecoKit += 0;
        }

        if (mira is not false && colete is not false )
        {
            KitAssalt.PrecoKit += KitAssalt.Plataforma.Preco + 10.00 + 10.00;
        }
        else if (mira is false || silenciador is false)
        {
            KitAssalt.PrecoKit += KitAssalt.Plataforma.Preco + 10.00;
        }

        return KitAssalt;

    }

    private ArmaAirsoft AdicionarRifle(int airsoftRifle)
    {
        var rifle = new ArmaAirsoft();
        switch (airsoftRifle)
        {
            case 1:
                rifle.Nome = "M4 MPW 12";
                rifle.Ano = "2019";
                rifle.Preco = 70.00;
                rifle.Fabricante = "G&G";
                rifle.Pais = "Taiwan";
                rifle.Tipo = "Rifle de assalto";
                rifle.Distancia = 60;
                break;
            case 2:
                rifle.Nome = "AK-102";
                rifle.Ano = "2021";
                rifle.Preco = 95.80;
                rifle.Fabricante = "LCT";
                rifle.Pais = "Taiwan";
                rifle.Tipo = "Rifle de assalto";
                rifle.Distancia = 60;
                break;
            case 3:
                rifle.Nome = "Scar H - MK17";
                rifle.Ano = "2018";
                rifle.Preco = 98.70;
                rifle.Fabricante = "WE";
                rifle.Pais = "Taiwan";
                rifle.Tipo = "Rifle de assalto";
                rifle.Distancia = 60;
                break;
        }

        return rifle;
    }
}