using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ariketa1
{
    internal class Esaldia
    {
        private string esaldiaLotuta;
        public string EsaldiaLotuta
        {
            get { return esaldiaLotuta; }
        }
        public String hitzBakarra
        {
            get; set;
        }
        public void lotuHitzak()
        {
            esaldiaLotuta += hitzBakarra + " ";
        }
    }
}
