using System;

namespace InOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Input number A:" + A);

            Console.WriteLine("Input String str:");
            string str = Console.ReadLine();
            Console.WriteLine("Your Input Stirng str:" + str);
        }
    }
}