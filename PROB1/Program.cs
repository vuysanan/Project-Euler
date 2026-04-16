using System;
using static System.Console;

namespace PROB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 0;

            for (i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            WriteLine(sum);
        }
    }
}