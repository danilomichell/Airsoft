using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    internal class ArmaBuilder : ArmaAbstractBuilder 
    {
        private ArmaAirsoft armaAirsoft = new ArmaAirsoft();

        public override void addArma(string nome,int ano, float preco,string nomeFabricante,string pais, string tipo, int distancia)
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
}
