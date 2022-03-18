#pragma warning disable CS8618
using Airsoft.Prototype.Fabricas;

namespace Airsoft.Prototype.Interfaces
{
    public class Armas
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public FabricaArmas Fabrica { get; set; }
        public double Preco { get; set; }
        public DateTime Ano { get; set; }

        public Armas(string nome, string tipo, FabricaArmas fabrica, double preco, DateTime ano)
        {
            Nome = nome;
            Tipo = tipo;
            Fabrica = fabrica;
            Preco = preco;
            Ano = ano;
        }


        public string ExibirInfo()
        {
            return $"Nome: {Nome} \nTipo: {Tipo} \nFábrica: {Fabrica.Nome} \nPreço: R${Preco} \nAno: {Ano}";
        }

        public Armas ShallowCopy()
        {
            Console.WriteLine("Aque está a copia(Shallow): ");
            return (Armas)this.MemberwiseClone();
        }

        public Armas DeepCopy()
        {
            var clone = (Armas)this.MemberwiseClone();
            clone.Nome = Nome;
            clone.Tipo = Tipo;
            clone.Ano = Ano;
            clone.Preco = Preco;
            clone.Fabrica = new FabricaArmas() { Nome = Fabrica.Nome };
            Console.WriteLine("Aque está a copia(Deep): ");
            Console.WriteLine(clone.ExibirInfo() + "\n");
            return clone;
        }
    }
}
