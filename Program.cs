using System;
using static System.Console;
namespace PROB0
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (long i = 1; i <= 947000; i += 2)
            {
                sum += i*i;
            }
            WriteLine(sum);
        }
    }
}