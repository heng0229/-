using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample005
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約", "台北" };
            var Distinct = list.Distinct();
            foreach (var item in Distinct)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
