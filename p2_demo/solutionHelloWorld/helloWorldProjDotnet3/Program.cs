﻿using System;

namespace helloWorldProjDotnet3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 在内存申请空间然后赋值 （初始值）
            var n = 100;
            var m = 200;
            var sum = 0;

            // 运算
            sum = n + m;

            // .NET 提供的打印的方法
            Console.WriteLine(sum);

            // 处理数字
            Console.WriteLine("请输入一个数字: ");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1) + 20;
            Console.WriteLine(num1);

            // 处理字符串
            Console.WriteLine("请输入一个字符串: ");
            string str2 = Console.ReadLine();
            string num2 = str2 + 20.ToString();
            Console.WriteLine(num2);

            // Pause 输入任意键才能继续
            Console.ReadKey();
        }
    }
}
