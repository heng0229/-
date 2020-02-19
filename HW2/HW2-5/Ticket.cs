using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_5
{
    class Ticket
    {
        public string Name { get; set; }
        public decimal Taipei { get; set; }
        public decimal Hsinchu { get; set; }
        public decimal Taichung { get; set; }
        public decimal Chiayi { get; set; }
        public decimal Tainan { get; set; }
        public decimal Kaohsiung { get; set; }
        public short Taipeicost => Convert.ToInt16(Math.Floor(Taipei * (decimal)1.8));
        public short Taipeicost1 => Convert.ToInt16(Math.Floor(Taipei * (decimal)0.9));
        public short Taipeicost2 => Convert.ToInt16(Math.Floor(Taipei * (decimal)1.62));
        public short Hsinchucost => Convert.ToInt16(Math.Floor(Hsinchu * (decimal)1.8));
        public short Hsinchucost1 => Convert.ToInt16(Math.Floor(Hsinchu * (decimal)0.9));
        public short Hsinchucost2 => Convert.ToInt16(Math.Floor(Hsinchu * (decimal)1.62));
        public short Taichungcost => Convert.ToInt16(Math.Floor(Taichung * (decimal)1.8));
        public short Taichungcost1 => Convert.ToInt16(Math.Floor(Taichung * (decimal)0.9));
        public short Taichungcost2 => Convert.ToInt16(Math.Floor(Taichung * (decimal)1.62));
        public short Chiayicost => Convert.ToInt16(Math.Floor(Chiayi * (decimal)1.8));
        public short Chiayicost1 => Convert.ToInt16(Math.Floor(Chiayi * (decimal)0.9));
        public short Chiayicost2 => Convert.ToInt16(Math.Floor(Chiayi * (decimal)1.62));
        public short Tainancost => Convert.ToInt16(Math.Floor(Tainan * (decimal)1.8));
        public short Tainancost1 => Convert.ToInt16(Math.Floor(Tainan * (decimal)0.9));
        public short Tainancost2 => Convert.ToInt16(Math.Floor(Tainan * (decimal)1.62));
        public short Kaohsiungcost => Convert.ToInt16(Math.Floor(Kaohsiung * (decimal)1.8));
        public short Kaohsiungcost1 => Convert.ToInt16(Math.Floor(Kaohsiung * (decimal)0.9));
        public short Kaohsiungcost2 => Convert.ToInt16(Math.Floor(Kaohsiung * (decimal)1.62));
    }
}
