using System;

class Program
{
    // continue, break - 현재 반복문만을 빠져나감


    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            if (i == 50)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}