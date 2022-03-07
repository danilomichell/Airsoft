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

            ArmaBuild builder1 = new ArmaBuild();

            diretor.Construct(builder1, "MPW 12", 2019, 100, "G&G", "EUA","Fuzil assalto",50);
        }
    }

}
