﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = cratelist();

            IEnumerable<MyData> people =
                from data in list
                where data.name == "Bill"
                select data;

            foreach (MyData person in people)
            {
                Console.WriteLine($"{person.name} 是 {person.age} 歲");
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
