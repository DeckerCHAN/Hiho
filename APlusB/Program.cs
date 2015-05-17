using System;

namespace APlusB
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            while (!String.IsNullOrEmpty(line = Console.ReadLine()))
            {
                var a = Convert.ToInt64(line.Split(' ')[0]);
                var b = Convert.ToInt64(line.Split(' ')[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}
