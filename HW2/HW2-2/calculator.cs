using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_2
{
    class calculator
    {
        private int _remainder;
        public calculator(int total)
        {
            _remainder = total;
            onethousand = GetNumber(1000);
            fivehundred = GetNumber(500);
            onehundred = GetNumber(100);
            fifty = GetNumber(50);
            ten = GetNumber(10);
            five = GetNumber(5);
            one = _remainder;
        }
        public int onethousand { get; private set; }
        public int fivehundred { get; private set; }
        public int onehundred { get; private set; }
        public int fifty { get; private set; }
        public int ten { get; private set; }
        public int five { get; private set; }
        public int one { get; private set; }

        private int GetNumber(int money)
        {
            var result = _remainder / money;
            _remainder = _remainder % money;
            return result;
        }
    }
}
