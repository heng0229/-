using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample008
{
    class Program
    {
        static List<MyData> createlist()
        {
            return new List<MyData>()
            {
                new MyData(){name="Bill",city="台北"},
                new MyData(){name="John",city="台北"},
                new MyData(){name="Tom",city="高雄"},
                new MyData(){name="David",city="台南"},
                new MyData(){name="Jeff",city="台南"},
            };
        }
        static void Main(string[] args)
        {
            var list = createlist();
            var result = list.GroupBy((x) => x.city);

            foreach (var item in result)
            {
                Console.WriteLine($"住在:{item.Key}");
                foreach (var n in item)
                {
                    Console.WriteLine(n.name);
                }
                Console.WriteLine("-----------------");
            }
            Console.ReadLine();
        }
    }
}
