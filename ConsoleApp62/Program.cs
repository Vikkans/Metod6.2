using System;

namespace forre
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 6;
            int tal2 = 5;
            Console.WriteLine(Störst(tal1, tal2));
        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }

            else
            {
                return tal2;
            }
        }
    }
}
