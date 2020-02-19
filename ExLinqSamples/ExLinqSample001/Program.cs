using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = cratelist();
            int total = list.Sum((x) => x.age);
            Console.WriteLine($"年齡總和為:{total}");

            var minage = list.Min((x) => x.age);
            Console.WriteLine($"最小年齡為:{minage}");

            var maxage = list.Max((x) => x.age);
            Console.WriteLine($"最大年齡為:{maxage}");

            int count = list.Count();
            Console.WriteLine($"list總個數為:{count}");
            int countofBill = list.Count((x) => x.name == "Bill");
            Console.WriteLine($"list中的Bill總數量為:{countofBill}");

            var average = list.Average((x) => x.age);
            Console.WriteLine($"年齡的平均值為:{average}");

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
