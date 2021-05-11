using System;

// Static Class란
// 정적멤버변수와 정적멤버함수 만
// 가질 수 있는 클래스
static class StClass
{
    // 일반 멤버변수는 선언만 해도 오류가 난다
    int TEST = 100;

}

class Player
{
    // 함수의 위치는 문법적으로 어디든 상관없다
    // static void main 이 있는 곳이 프로그램의 시작점
    static void Main(string[] args)
    {
        Console.WriteLine("프로그램의 시작");
    }
}

namespace _15_StaticClass
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램의 시작");
        }
        */
    }
}
