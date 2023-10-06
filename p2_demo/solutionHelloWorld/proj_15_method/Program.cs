using System;

namespace proj_15_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (; true;)
            //{
            //    GetUserInfo();
            //}


            //for (; false;)
            //{
            //    GetUserInfo();
            //}

            for (int i = 0; i < 3; i++)
            {
                GetUserInfo();
            }


            Console.ReadKey();
        }

        private static void GetUserInfo()
        {

            Console.WriteLine("请输入你的姓名: ");
            string name = Console.ReadLine();

            Console.WriteLine("请输入你的故乡: ");
            string address = Console.ReadLine();

            Console.WriteLine("请输入你的爱好: ");
            string hobby = Console.ReadLine();

            // 修改名字sd
            // (name, address) = ChangeData(name, address);

            string info1 = "你的名字是: " + name;
            string info2 = "你的故乡是: " + address;
            string info3 = "你的爱好是: " + hobby;

            Console.WriteLine(info1);
            Console.WriteLine(info2);
            Console.WriteLine(info3);

        }

        private static (string, string) ChangeData(string name, string address)
        {

            string name1 = "Michael " + name;
            string address1 = "101 " + address;

            return (name1, address1);
        }
    }
}
