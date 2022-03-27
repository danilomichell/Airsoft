using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Airsoft.Composite.Armas
{
    public  class AirsoftFuzilPrecisao : AirsoftPistola
    {
        public Kit CriarKitSniper(int plataforma, bool silenciador, bool colete, int pistola)
        {
            var KitSniper = new Kit
            {
                Plataforma = AdicionarSniper(plataforma),
                Silenciador = silenciador,
                Colete = colete
            };

            if (pistola > 0 && pistola <= 3)
            {
                KitSniper.Secundaria = AdicionarPistola(pistola);
            };

            if (pistola > 0 && pistola <= 3)
            {
                KitSniper.Secundaria = AdicionarPistola(pistola);
                KitSniper.PrecoKit += KitSniper.Secundaria.Preco;
            };

            if (colete is not false)
            {
                KitSniper.PrecoKit += KitSniper.Plataforma.Preco + 10.00;
            }
            else
            {
                KitSniper.PrecoKit += KitSniper.Plataforma.Preco;
            }

            return KitSniper;

        }

        private ArmaAirsoft AdicionarSniper(int airsoftRifle)
        {
            var sniper = new ArmaAirsoft();
            switch (airsoftRifle) {
                case 1:
                    sniper.Nome = "M24";
                    sniper.Ano = "2020";
                    sniper.Preco = 100.90;
                    sniper.Fabricante = "Tokio Marui";
                    sniper.Pais = "Japão";
                    sniper.Tipo = "Fuzil de precisão";
                    sniper.Distancia = 120;
                    break;

                case 2:
                    sniper.Nome = "M110";
                    sniper.Ano = "2018";
                    sniper.Preco = 159.50;
                    sniper.Fabricante = "Ares";
                    sniper.Pais = "E.U.A";
                    sniper.Tipo = "Fuzil de precisão DMR";
                    sniper.Distancia = 110;
                    break;

                case 3:
                    sniper.Nome = "Dragunov";
                    sniper.Ano = "2019";
                    sniper.Preco = 159.50;
                    sniper.Fabricante = "King Arms";
                    sniper.Pais = "Japão";
                    sniper.Tipo = "Fuzil de precisão DMR";
                    sniper.Distancia = 110;
                    break;
            }
            return sniper;
        }
    }
}
