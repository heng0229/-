using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            string odd = "";
            string even = "";
            Console.WriteLine("請輸入整數:");
            string input = Console.ReadLine();
            string[] array = input.Split(',');
            int[] myInts = Array.ConvertAll(array, int.Parse);
            Array.Sort(myInts);
            for (int i = 0; i < myInts.Length; i++)
            {
                value = myInts[i];
                if (value % 2 == 0)
                {
                    if (even == "")
                    {
                        even += value.ToString();
                    }
                    else
                    {
                        even += ",";
                        even += value.ToString();
                    }
                }
                else
                {
                    if (odd == "")
                    {
                        odd += value.ToString();
                    }
                    else
                    {
                        odd += ",";
                        odd += value.ToString();
                    }
                }
            }
            Console.WriteLine("奇數:" + odd);
            Console.WriteLine("偶數:" + even);
            Console.ReadLine();
        }
    }
}
