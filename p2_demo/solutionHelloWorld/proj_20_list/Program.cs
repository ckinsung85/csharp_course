using System;
using System.Collections.Generic;

namespace proj_20_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            names.Add("张三");
            names.Add("李四");
            names.Add("王五");

            int num = 0;
            for (int i = 0;i < names.Count;i++)
            {
                if (names[i] == "张三")
                {
                    num++; // num = num + 1
                    Console.WriteLine("组里有张三");
                }

            }

            Console.WriteLine("What is your age?");
            bool statement = true;
            while (statement == true) 
            {
                try
                {
                    int age = int.Parse(Console.ReadLine());
                    statement = false;
                }
                catch
                {
                    Console.WriteLine("Please key in integer number for your age");
                }
            }

            Console.WriteLine("What is your weight?");
            int weight = 0;
            for (bool tf = true; tf == true;)
            {
                try
                {
                    weight = int.Parse(Console.ReadLine());
                    tf = false;
                }
                catch
                {
                    Console.WriteLine("Please key in integer number for your weight");
                    Console.ReadKey();
                    return; // skip all the lines below
                }
            }

            weight = weight + 10;
            Console.WriteLine("Your weight after weight gain is " + weight);

        }

    }
}
