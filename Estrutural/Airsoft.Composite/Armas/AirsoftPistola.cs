using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Airsoft.Composite.Armas
{
    public class AirsoftPistola 
    {
       protected ArmaAirsoft AdicionarPistola(int airsoftPistola)
        {
            var pistola = new ArmaAirsoft();
            switch (airsoftPistola)
            {
                case 1:
                    pistola.Nome = "1911 AW1102";
                    pistola.Ano = "2020";
                    pistola.Preco = 49.80;
                    pistola.Fabricante = "Armorer Workrs";
                    pistola.Pais = "Taiwan";
                    pistola.Tipo = "Pistola";
                    pistola.Distancia = 30;
                    break;

                case 2:
                    pistola.Nome = "Glock 19";
                    pistola.Ano = "2019";
                    pistola.Preco = 38.39;
                    pistola.Fabricante = "WE";
                    pistola.Pais = "Taiwan";
                    pistola.Tipo = "Pistola";
                    pistola.Distancia = 25;
                    break;

                case 3:
                    pistola.Nome = "P226 Sig Sauer";
                    pistola.Ano = "2015";
                    pistola.Preco = 39.59;
                    pistola.Fabricante = "KJW";
                    pistola.Pais = "Taiwan";
                    pistola.Tipo = "Pistola";
                    pistola.Distancia = 25;
                    break;
            }
            return pistola;
        }
    }
}
