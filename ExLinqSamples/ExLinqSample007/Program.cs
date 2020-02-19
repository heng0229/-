using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample007
{
    class Program
    {
        static List<MyData> createlist()
        {
            return new List<MyData>()
            {
                new MyData(){name="Bill",age=47},
                new MyData(){name="John",age=37},
                new MyData(){name="Tom",age=48},
                new MyData(){name="David",age=36},
            };
        }
        static void Main(string[] args)
        {
            var list = createlist();
            var result1 = list.Where((x) => x.age > 40).ToList();
            var result2 = list.Where((x) => x.age > 40).ToArray();

            var result3 = list.Where((x) => x.age > 40).ToDictionary((x) => x.name);
            foreach(var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.name + "--" + item.Value.age);
            }
            Console.WriteLine("-----------------");

            var result4 = list.ToDictionary((x) => x.name, (y) => y.age);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
    }
}
