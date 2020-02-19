using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = cratelist();
            var min = list.Where((x) => x.name=="Bill").Min((x)=>x.age);
            Console.WriteLine($"所有Bill中最小年齡是:{min}");

            int total = list.Where((x) => x.name == "Bill").Sum((x) => x.age);
            Console.WriteLine($"所有Bill的年齡總和是:{total}");

            var average = list.Where((x) => x.name == "Bill").Average((x) => x.age);
            Console.WriteLine($"所有Bill的年齡的平均值是:{average}");

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
