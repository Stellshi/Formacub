using System;

namespace Formacub
{
    class Program
    {
        static void Main()
        {
            int i;
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
        }
    }
}
