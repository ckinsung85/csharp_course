using System;

namespace proj_10_writeInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名: ");
            string name = Console.ReadLine();

            Console.WriteLine("请输入你的故乡: ");
            string address = Console.ReadLine();

            Console.WriteLine("请输入你的爱好: ");
            string hobby = Console.ReadLine();

            string info1 = "你的名字是: " + name;
            string info2 = "你的故乡是: " + address;
            string info3 = "你的爱好是: " + hobby;

            Console.WriteLine(info1);
            Console.WriteLine(info2);
            Console.WriteLine(info3);

            bool statement = true;
            if (statement)
            {
                Console.WriteLine("statement is true: Print " + statement.ToString());
            }
            else
            {
                Console.WriteLine("statement is false: Print " + statement.ToString());
            }

            bool isCheck1 = name == "张三";
            if (isCheck1)
            {
                Console.WriteLine("名字是张三");
            }

            bool isCheck2 = name != "张三";
            if (isCheck2)
            {
                Console.WriteLine("名字不是张三");
            }

            if (address != "淡边")
            {
                Console.WriteLine("家乡不是淡边");
            }

            if (name == "张三")
            {
                Console.WriteLine("名字是张三");
            }
            else if (name == "李四")
            {
                Console.WriteLine("名字是李四");
            }
            else
            {
                Console.WriteLine("名字都不是张三李四");
            }

            // Pause 输入任意键才能继续
            Console.ReadKey();
        }
    }
}
