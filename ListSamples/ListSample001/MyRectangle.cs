using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample001
{
    class MyRectangle
    {
        public string name { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int GetArea()
        {
            return width * height;
        }
    }
}
