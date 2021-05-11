using System;

class Player
{
    int ATT = 10;
    // 프로퍼티에 대한 변수는 앞에 m_을 붙인다
    static int m_StaticValue = 0;

    // 정적 프로퍼티도 가능
    public static int StaticValue
    {
        get
        {
            return m_StaticValue;
        }
        set
        {
            m_StaticValue = value;
        }
    }

    // 자료형을 선언했다면 이는
    // int 와 관련된 함수라고 명시
    public int ProAT
    {
        // 프로퍼티의 Get 함수는 무조건 int를 리턴
        // 
        get
        {
            return ATT;
        }

        // 무조건 int 하나가 들어온다고 생각
        // 그런 외부 값들을 프로퍼티에서는
        // value 라고 기호로 정의해놨다.
        set
        {
            ATT = value;
        }
    }

    // Get, Set 함수를 만들어 사용하는 것이 좋다
    // Ctrl + Space = 자동완성
    public int GetATT()
    {
        return ATT;
    }

    public void SetATT(int _Value)
    {
        if (_Value > 999)
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            Console.ReadKey(true);
        }
        else
        {
            ATT = _Value;
        }
    }
}

namespace _26_Property
{

    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.SetATT(9999);

            NewPlayer.ProAT = 500;
            int Player_AT = NewPlayer.ProAT;
            Console.WriteLine(Player_AT);

            Player.StaticValue = 100;
        }
    }
}
