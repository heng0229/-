
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint v0 = 0;
            //uint v1 = 1;
            //uint temp = 0;
            //while (v1 <= 1836311903)
            //{
            //    Console.WriteLine(v1.ToString());
            //    temp = v1;
            //    v1 += v0;
            //    v0 = temp;
            //}
            Int64 p1 = 1, p2 = 1, x = 0;
            //string value = "";
            Console.Write($"{p1}、{p2}");
            while (x < 1836311903)
            {
                x = p1 + p2;
                p1 = p2;
                p2 = x;

                Console.Write($"、{p2}");
                //if (value == "")
                //{
                //    value += x.ToString();
                //}
                //else
                //{
                //    value += "、";
                //    value += x.ToString();
                //}
            }
            Console.Read();
        }
    }
}
