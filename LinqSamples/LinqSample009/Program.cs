using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample009
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = cratelist();
            string name = "Bill";
            bool isAllBill = list.All((x) => x.name == name);
            if (isAllBill)
            {
                Console.WriteLine($"全都是{name}");
            }
            else
            {
                Console.WriteLine($"有些人不叫{name}");
            }
            bool isAllOverForty = list.All((x) => x.age > 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過 40 歲");
            }
            else
            {
                Console.WriteLine("有人不到 40 歲");
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
