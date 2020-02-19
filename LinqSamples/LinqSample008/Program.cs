using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample008
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = cratelist();
            string name = "David";
            var person = list.Any((x) => x.name == name);
            if (person)
            {
                Console.WriteLine($"找到了:{name}");
            }
            else
            {
                Console.WriteLine($"找不到:{name}");
            }
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
