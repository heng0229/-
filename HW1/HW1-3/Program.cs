using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "", value = "";
            Console.WriteLine("輸入一串數字:");
            string input = Console.ReadLine();
            string[] array = input.Split(',');
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                value = array[i];

                if (a == "")
                {
                    a += value.ToString();
                }
                else
                {
                    a += ",";
                    a += value.ToString();
                }
            }
            Console.WriteLine("結果"+a);
            Console.ReadLine();
        }
    }
}
