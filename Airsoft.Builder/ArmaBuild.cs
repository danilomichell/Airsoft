using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    internal class ArmaBuild : ArmaAbstractBuilder
    {
        private ArmaAirsoft armaAirsoft = new ArmaAirsoft();

        public override void addArma(string nome,int ano, float preco)
        {
            armaAirsoft.Nome = nome;
            armaAirsoft.Ano = ano;
            armaAirsoft.Preco = preco;
        }

        public override void addFabricante(string nome,string pais)
        {
            armaAirsoft.Fabricante.NomeFabricante = nome;
        }

        public override void addTipo(string nomeTipo,int distacia)
        {
            armaAirsoft.Tipo.NomeTipo = nomeTipo;
            armaAirsoft.Tipo.Distancia = distacia;
        }

        public override ArmaAirsoft GetAirsoft()
        {
            return armaAirsoft;
        }

        

    }
}
