using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CatalogoArmas catalogo = new CatalogoArmas();
            Arma arma = new Arma();
            catalogo.AddItem(arma.AdicionarRifle());
            catalogo.AddItem(arma.AdicionarPistola());

            Console.WriteLine($"Nome da arma: {catalogo.Item.Nome}");
            Console.WriteLine($"Ano: { catalogo.Item.Ano}");
            Console.WriteLine($"Preço: R${catalogo.Item.Preco}");
            Console.WriteLine($"Fabricante: {catalogo.Item.Fabricante}");
            Console.WriteLine($"País: {catalogo.Item.Pais}");
            Console.WriteLine($"Tipo da arma: {catalogo.Item.Tipo}");
            Console.WriteLine($"Distância em metros: {catalogo.Item.Distancia}m");

        }
    }

}
