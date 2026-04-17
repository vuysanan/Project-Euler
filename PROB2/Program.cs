using System;
using static System.Console;
using System.Collections.Generic;

namespace PROB2
{
    class Program
    {
        static void Main(string[] args)
        {            
            int first = 1;
            int second = 2;
            int sumOfEvens = 0;

            while (first <= 4000000)
            {
                if (first % 2 == 0)
                {
                    sumOfEvens += first;
                }

                int next = first + second;
                first = second;
                second = next;
            }

            WriteLine($"The sum of even-valued terms is: {sumOfEvens}");
        }
    }
}