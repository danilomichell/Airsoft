using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Airsoft.Memento
{
    public class ArmaMemento : Imemento
    {
        public ArmaMemento(ArmaOriginadora arma, string name, string descricao, double preco, string fabricante, string pais, string tipo, int distancia)
        {
            Arma = arma;
            Name = name;
            Descricao = descricao;
            Preco = preco;
            Fabricante = fabricante;
            Pais = pais;
            Tipo = tipo;
            Distancia = distancia;
        }

        private ArmaOriginadora Arma { get; }
        private string Name { get; }
        private string Descricao { get;}
        private double Preco { get; }
        private string Fabricante { get; }
        private string Pais { get; }
        private string Tipo { get; }
        private int Distancia { get; }

    }
}
