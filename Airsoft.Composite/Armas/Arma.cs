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
            pistola.Nome = "1911 AW1102";
            pistola.Ano = "2020";
            pistola.Preco = 40.80;
            pistola.Fabricante = "Armorer Workrs";
            pistola.Pais = "Taiwan";
            pistola.Tipo = "Pistola";
            pistola.Distancia = 30;
            return pistola;
        }

        public ArmaAirsoft AdicionarSniper()
        {
            var sniper = new ArmaAirsoft();
            sniper.Nome = "M24";
            sniper.Ano = "2020";
            sniper.Preco = 85.90;
            sniper.Fabricante = "Tokio Marui";
            sniper.Pais = "Japão";
            sniper.Tipo = "Fuzil de precisão";
            sniper.Distancia = 100;
            return sniper;
        }

        public ArmaAirsoft AdicionarArmaManual(string nome, string ano, double preco, string fabricante, string pais, string tipo, int distancia )
        {
            var novaArma = new ArmaAirsoft();
            novaArma.Nome = nome;
            novaArma.Ano = ano;
            novaArma.Preco = preco;
            novaArma.Fabricante = fabricante;
            novaArma.Pais = pais;
            novaArma.Tipo = tipo;
            novaArma.Distancia = distancia;
            return novaArma;
        }
    }
}
