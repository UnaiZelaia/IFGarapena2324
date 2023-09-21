using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariketa2
{
    internal class Eragiketa
    {


        public float a
        {
            get; set;   
        }
        public float b
        {
            get;set;
        }
        public float c
        {
            get;set;
        }
        public float d
        {
            get;set;
        }




        public String eragiketaEgin(List<int> objetuak)
        {
            float result = (objetuak.IndexOf(0) + (2 * objetuak.IndexOf(1)) + (3 * this.c) + (4 * this.d)) / 4;
            return "(" + this.a + " + (" + this.b + "x2)" + " + (" + this.c + "x3)" + " + (" + this.d + "x4)/4 = " + result;
        }
    }
}
