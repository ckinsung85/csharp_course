using System;

namespace proj_9_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
