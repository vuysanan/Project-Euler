using static System.Console;

namespace PROB3
{
    class Program
    {
        static void Main(string[] args)
        {
            long givenNumber = 600851475143;
            int factor = 2;
            int max = -9999;

            while (givenNumber > 1)
            {
                if (givenNumber % factor == 0)
                {
                    max = factor;
                    givenNumber = givenNumber / factor;
                }
                else
                {
                    factor++;
                }
            }

            WriteLine(max);
        }
    }
}