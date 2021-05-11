using System;

class Player
{
    // 멤버변수 = 클래스 내부에 있어서 멤버변수
    int ATT;
    int HP;

    void Fight()
    {
        int Dmg;

        Console.WriteLine("플레이어가 싸운다.");
    }
}
// 게임에서 사용하기 위해 여기까지 설계했다.

namespace _06_LocalVar
{
    /*
    C# = 고지식한 객체지향언어
    클래스밖에 모르는 바보

    프로그램의 시작조차도
    클래스안에 묶어놔야 한다.

    */
    class Program
    {
        // 시작용 함수가 있는 것이고
        static void Main(string[] args)
        {
            /*
            클래스 안에 있으면 멤버변수
            함수 안에 있는 녀석들을 지역변수

            선언되면 메모리화 되고, 함수가 끝나면 사라진다

            
            지역변수 규칙 - 내부에서만 사용가능
             */
            int ATT = 0;
            ATT = 50;

            // 객체화라고 하는 굉장히 중요한 작업
            // 클래스 = 설계도
            // Player의 설계대로 플레이어를 만드는데
            // 그 이름을 NewPlayer1, 2 라고 해라.
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
        }
    }
}
