using System;

namespace _18_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            초기화문
            -> 조건 -> 실행코드 -> 증감
            -> 조건 -> .....
            for ( 초기화문; 조건문; 변화문 )
            {
                실행코드
            }
            */
            // for문의 장점 = 접근성
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("for문 출력 : {0}", i);
            }
        }
    }
}
