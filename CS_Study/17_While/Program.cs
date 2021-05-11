using System;

namespace _17_While
{
    class Program
    {
        static void Main(string[] args)
        {
            // for, while [tab][tab] 시 예제가 나온다

            /*
                        for (int i = 0; i < length; i++)
                        {

                        }
            */
            // while ( 참/거짓 ) : 조건문 -> 실행코드 -> 조건문 ...
            bool Chk = true;
            while (Chk)
            {
                Console.WriteLine("무한 출력");
                Chk = false;
            }

            Chk = false;
            // do while ( 참/거짓 ) : 실행코드 -> 조건문 -> 실행코드 ....
            int Count = 0;
            do
            {
                Count++;
                Console.WriteLine("Do_While 출력 : {0}", Count);
            } while (Count < 100);
        }
    }
}