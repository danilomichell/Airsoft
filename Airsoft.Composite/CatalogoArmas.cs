using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airsoft.Composite
{
    public class CatalogoArmas
    {
        public int Count { get; set; }
        public bool First { get; set; }
        public ArmaAirsoft? Item { get; set; }
        public ArmaAirsoft? Son { get; set; }

        public void AddItem(ArmaAirsoft rifle)
        {
            if (Count == 0)
            {
                First = true;
                Item = rifle;
            }
            else
            {
                Son = rifle;

            }
        }

    }
}
