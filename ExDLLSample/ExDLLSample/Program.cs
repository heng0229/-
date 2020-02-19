using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ExDLLSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle();
            rect.width = 10;
            rect.height = 10;
            Console.WriteLine($"面積為:{rect.getarea()}");
            Console.WriteLine("面積為:" + rect.getarea());
            Console.ReadLine();
        }
    }
}
