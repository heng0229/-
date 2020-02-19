using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    class Program
    {,
        static void Main(string[] args)
        {
            int i = 1;
            int result = 0;
            while(i < 11)
            {
                result = result + i;
                //Console.WriteLine($"加總結果為{result}+{i}={result = result + i}");
                i++;
            }
            Console.WriteLine($"加總結果為{result}");
            Console.ReadLine();
        }
    }
}
