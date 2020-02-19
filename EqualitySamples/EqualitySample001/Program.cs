using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample001
{
    class Program
    {
        static void Main(string[] args)
        {
            //實質型別
            int i = 10;
            int j = 10;
            Console.WriteLine($"object.Equals(i,j) is {object.Equals(i,j)}");
            //比較位置
            MyRectangle r1 = new MyRectangle { width = 5, height = 5 };
            MyRectangle r2 = new MyRectangle { width = 5, height = 5 };
            MyRectangle r3 = r2;
            Console.WriteLine($"object.Equals(r1,r2) is {object.Equals(r1, r2)}");
            Console.WriteLine($"object.Equals(r2,r3) is {object.Equals(r2, r3)}");
            Console.ReadLine();
        }
    }
}
