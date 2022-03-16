using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Composite
{
    internal class Arma
    {
        public ArmaAirsoft AdicionarRifle()
        {
            var rifle = new ArmaAirsoft();
            rifle.Nome = "M4 MPW 12";
            rifle.Ano = "2019";
            rifle.Preco = 70.00;
            rifle.Fabricante = "G&G";
            rifle.Pais = "Taiwan";
            rifle.Tipo = "Rifle de assalto";
            rifle.Distancia = 60;
            return rifle;
        }

        public ArmaAirsoft AdicionarPistola()
        {
            var pistola = new ArmaAirsoft();
            pistola.Nome = "1911 1102";
            pistola.Ano = "2020";
            pistola.Preco = 40.80;
            pistola.Fabricante = "Armorer Workrs";
            pistola.Pais = "Taiwan";
            pistola.Tipo = "Pistola";
            pistola.Distancia = 30;
            return pistola;
        }
    }
}
