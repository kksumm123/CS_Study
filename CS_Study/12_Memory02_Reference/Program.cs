using System;

class Player
{
    public int ATT = 10, HP = 100;

    public void ATT_Func(Monster _Monster)
    {
        _Monster.HP -= ATT;
    }
}
class Monster
{
    public int ATT = 10, HP = 100;

    public void ATT_Func(Player _Player)
    {
        _Player.HP -= ATT;
    }
}

namespace _12_Memory02_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            메모리의 구조 ( [코드 : 상수, 클래스]
                            , [데이터]
                            , [힙 : new Class(); 로 선언된 객체화된 값]
                            , [스택])
            */
            // 클래스가 객체화되면 [ Player NewPlayer = new Player(); ]
            // 레퍼런스 형이라고 하는 자료형이 되고

            // int, bool 같은 자료형은 값형이라고 하는 자료형이다

            // 값형과 레퍼런스 형은
            // 메모리의 위치와 사용법이 다르기 때문에
            // 다르게 동작한다

            // 레퍼런스형은 힙(=메모리 구조중 하나)에 생성된
            // 어떤 메모리의 위치를 가리키는 값
            /*
                int Value 100;
                위치 : 0x0041000
                크기 : 4
                값 : 100

                Player NewPlayer = new Player();
                위치 : 0x0050000
                크기 : 클래스의 크기만큼
                값 : 0x2010000
            */

            // ATT = 10, HP = 100
            Monster NewMonster = new Monster();

            // ATT = 10, HP = 100
            Player NewPlayer = new Player();

            // 아래 함수를 통과하면 값이 변경됨
            NewMonster.ATT_Func(NewPlayer);
            Console.WriteLine(NewPlayer.HP);

            NewPlayer.ATT_Func(NewMonster);
            Console.WriteLine(NewMonster.HP);

            // 둘의 HP는 90으로 깍임.
        }
    }
}
