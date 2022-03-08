using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArmaDirector diretor = new ArmaDirector();

            ArmaBuilder builder1 = new ArmaBuilder();

            //diretor.Construct(builder1, "MPW 12", 2019, 100, "G&G", "EUA","Fuzil assalto",50);
            diretor.FuzilConstruct(builder1);
            Console.WriteLine(diretor.returnAirsoft(builder1).Nome);
        }
    }

}
