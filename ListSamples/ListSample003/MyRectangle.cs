using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample003
{
    class MyRectangle
    {
        public string name { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int Area
        {
            get { return width * height; }
        }
    }
}
