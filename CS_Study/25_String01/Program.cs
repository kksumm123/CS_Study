using System;

// 언어는 숨쉬는 것
// 면접시 언어를 잘 못해서.... = 숨을 잘 못쉬어서

// 프로그래밍의 기본기 3가지
// 디버깅 - 95%
// 문자열 - 3%
// 파일입출력 - 2%

namespace _25_String01
{
    enum TEST
    {
        A01
    }


    class Program
    {
        static void Main(string[] args)
        {
            // 정적자료형 int(=4byte), double(=8byte), char(=1byte)
            // '동적' 기본 자료형 - 자료의 길이에 따라 변함
            string TEST = "ayheargerlgvnxdfkl";
            Console.WriteLine(TEST);
            // 자료형이 다르면 C#은 대입할 수 없다.
            //int A = "하하하하";
            //int B = TEST.A01;

            // int AAA = 1000; 자료형도 사실 구조체다.
            // 구조체 내부의 멤버변수나 함수가 존재하고
            // 그것을 통해 문자열로 변환이 된다.
            int AAA = new int();
            AAA = 1000;
            // TEST = AAA; - 빨간줄
            TEST = AAA.ToString();
            Console.WriteLine(TEST);

            string Left = "안녕하세요";
            string Right = " 날씨가 좋네요";

            string Result = Left + Right + AAA.ToString();
            //Console.WriteLine(Result);
            Console.WriteLine(Left + Right + AAA.ToString());

        }
    }
}
