using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Bezeroa : Kontaktua
    {
        public String kategoria{ get; set; }


        public override string gorde()
        {
            return "Bezeroa ondo gorde da";
        }

    }
}
