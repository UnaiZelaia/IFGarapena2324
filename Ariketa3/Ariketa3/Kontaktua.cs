using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Kontaktua
    {
        public String Nan { get; set; }
        public String izena {  get; set; }
        public String abizena { get; set; }
        public virtual String email { get; set; }
        public String izenOsoa { get; }
        


        public virtual String gorde()
        {
            return "Kontaktua ondo gorde da";
        }







    }
}
