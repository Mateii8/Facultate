using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorValutar
{
    public class Conversii
    {
        private RateSchimb rateSchimb;
        public Conversii(RateSchimb rate)
        {
            rateSchimb=rate;
        }
        public decimal Converteste(string dinMoneda,string inMoneda,decimal suma)
        {
            return rateSchimb.Converteste(suma, dinMoneda, inMoneda);
        }
    }
}
