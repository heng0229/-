using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample011
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = createlist();
            var order1 = list.OrderBy((x) => x.age);
            display(order1);
            var order2 = list.OrderByDescending((x) => x.age);
            display(order2);
            var order3 = list.OrderBy((x) => x.name).ThenBy((x)=>x.age);
            display(order3);
            var order4 = list.OrderBy((x) => x.name).ThenByDescending((x) => x.age);
            display(order4);
            Console.ReadLine();
        }
        static void display(IEnumerable<MyData> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item.name+":"+item.age);
            }
            Console.WriteLine("--------------");
        }
        static List<MyData> createlist()
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
