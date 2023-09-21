using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariketa2
{
    internal class Ariketa2
    {
        public string Label { get; set; }
        public float Zenbakia {  get; set; }

        public static float eragiketa(List<Ariketa2> objetuak)
        {
            float result = (objetuak[0].Zenbakia + (2 * objetuak[1].Zenbakia) + (3 * objetuak[2].Zenbakia) + (4 * objetuak[3].Zenbakia)) / 4;
            return result;
            //return "(" + objetuak[0].Zenbakia + " + (" + objetuak[1].Zenbakia + "x2)" + " + (" + objetuak[2].Zenbakia + "x3)" + " + (" + objetuak[3].Zenbakia + "x4)/4 = " + result;
        }
    }
}
