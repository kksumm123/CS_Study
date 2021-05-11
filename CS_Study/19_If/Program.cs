using System;

namespace _19_If
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl + r + r - 참조되는 모든 단어 변경가능
            int test = 100;

            if (test == 100)
            {
                Console.WriteLine("{0} = 100", test);
            }
            else if (test != 100)
            {
                Console.WriteLine("{0} != 100", test);
            }
            else
            {
                Console.WriteLine("test = {0}", test);
            }
        }
    }
}