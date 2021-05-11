using System;

namespace _20_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int Var = 1;

            switch (Var)
            {
                case 1:
                    Console.WriteLine("Var = {0}", Var);
                    break; // break를 끝마다 써주어야함
                case 3:
                    Console.WriteLine("Var = {0}", Var);
                    break;
                default:
                    Console.WriteLine("모든 조건이 맞지 않다면");
                    break;
            }
        }
    }
}
