using System;

namespace For99Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "*" + i + "=" + i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
