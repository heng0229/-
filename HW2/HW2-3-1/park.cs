using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_3_1
{
    class park
    {
        private int _remainder;
        public int getparkingfee(int minutes)
        {
            _remainder = minutes / 30;
            return getperiodhalfhours(8) * 60 + getperiodhalfhours(4) * 40
                + _remainder * 30;
        }
        private int getperiodhalfhours(int period)
        {
            var result = _remainder - period;
            if (result < 0)
            { result = 0; }
            _remainder -= result;
            return result;
        }
    }
}
