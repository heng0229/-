﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int result = 0;
            for(i=1;i<11;i++)
            {
                result = result + i;
                //Console.WriteLine($"加總結果為{result}+{i}={result = result + i}");
            }
            Console.WriteLine($"加總結果為{result}");
            Console.ReadLine();
        }
    }
}
