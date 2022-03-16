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

            Console.WriteLine(catalogo.Item.Nome);

        }
    }

}
