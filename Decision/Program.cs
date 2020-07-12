using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 局部变量定义 */
            int a = 10;

            /* 使用 if 语句检查布尔条件 */
            if (a < 20)
            {
                /* 如果条件为真，则输出下面的语句 */
                Console.WriteLine("a 小于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);
            Console.ReadLine();
        }
    }
}
