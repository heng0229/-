using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample005
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = cratelist();
            var people1 = list.SingleOrDefault((x) => x.name == "Tom");
            Console.WriteLine($"找到唯一的:{people1.name}");

            var people2 = list.Single((x) => x.name == "Bill");
            Console.WriteLine($"找到唯一的:{people2.name}");
            Console.ReadLine();
        }
        static List<MyData> cratelist()
        {
            return new List<MyData>()
            {
                new MyData{name="Bill",age=47},
                new MyData{name="John",age=37},
                new MyData{name="Tom",age=48},
                new MyData{name="David",age=36},
                new MyData{name="Bill",age=35}
            };
        }
    }
}
