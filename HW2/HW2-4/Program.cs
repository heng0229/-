using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入四個數字:");
            string input1 = Console.ReadLine().Replace("1", "一").Replace("2", "二").Replace("3", "三")
                .Replace("4", "四").Replace("5", "五").Replace("6", "六").Replace("7", "七")
                .Replace("8", "八").Replace("9", "九").Replace("0", "零");
            Console.WriteLine(input1);

            //Console.Write("請輸入四位數:");
            //string input2 = Console.ReadLine();
            //input2.ToList();
            //foreach (var i in input2)
            //{
            //    string value = i.ToString();
            //    int w = int.Parse(value);
            //    Console.Write(nw(w));
            //}
            Console.ReadLine();
        }
        private static string nw(int w)
        {
            switch (w)
            {
                case 1:
                    return "一";
                case 2:
                    return "二";
                case 3:
                    return "三";
                case 4:
                    return "四";
                case 5:
                    return "五";
                case 6:
                    return "六";
                case 7:
                    return "七";
                case 8:
                    return "八";
                case 9:
                    return "九";
                default:
                    return "零";
            }
        }
    }
}
