using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample012
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = createlist();
            var order1 = 
                from o in  list
                orderby o.name,o.age
                select o;
            display(order1);
            var order2 =
                from o in list
                orderby o.name descending, o.age descending
                select o;
            display(order2);
            Console.ReadLine();
        }
        static void display(IEnumerable<MyData> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item.name + ":" + item.age);
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