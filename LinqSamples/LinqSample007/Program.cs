using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample007
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            var list = cratelist();
            var person = list.ElementAtOrDefault(index);
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為:{index} 的人是{person.name}-{person.age}");
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
