using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = cratelist();
            var people1 = list.LastOrDefault((x) => x.age > 35);
            Console.WriteLine($"大於35歲的人最後一個被找到的是:{people1.name}");

            var people2 = list.Last((x) => x.age > 50);
            Console.WriteLine($"大於50歲的人最後一個被找到的是:{people2.name}");
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
