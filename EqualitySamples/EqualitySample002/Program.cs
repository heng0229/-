using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample002
{
    class Program
    {
        static void Main(string[] args)
        {
            //實質型別
            int i = 10;
            int j = 10;
            Console.WriteLine($"object.ReferenceEquals(i,i) is {object.ReferenceEquals(i, i)}");
            Console.WriteLine($"object.ReferenceEquals(i,j) is {object.ReferenceEquals(i, j)}");
            //比較位置
            MyRectangle r1 = new MyRectangle { width = 5, height = 5 };
            MyRectangle r2 = new MyRectangle { width = 5, height = 5 };
            MyRectangle r3 = r2;
            Console.WriteLine($"object.ReferenceEquals(r1,r2) is {object.ReferenceEquals(r1, r2)}");
            Console.WriteLine($"object.ReferenceEquals(r2,r3) is {object.ReferenceEquals(r2, r3)}");
            Console.ReadLine();
        }
    }
}
