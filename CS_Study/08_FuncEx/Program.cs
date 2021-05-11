using System;

class Player
{
    // 디폴트 접근제한 지정자 = private
    // 일반적으로 멤버변수들은
    // 외부에서 접근하지 못하게 하는 것이 좋다

    private int LV = 1;
    private int ATT = 10;
    private int HP = 500;

    // 함수로 지정해서 사용하는 것이 좋다
    public void LVUp()
    {
        ATT = ATT + 10;
        HP = 500;
    }
    public void SetHP(int _HP)
    {
        // 장점, 디버깅이 쉽다.
        HP = _HP;
    }

    // 함수는 보통 선언과 내용으로 나뉘게 된다
    //public[접근제한자] void[리턴값] Damage[이름 혹은 식별자] ()[인자값]
    // 함수란 보통 클래스 외부와의 소통을 위해 만든다
    // int _Dmg 
    public void Damage(int _Dmg)
    {
        HP = HP - _Dmg;
    }




    // 플레이어의 레벨이 몇인지 알고 싶다
    // 리턴값 사용
    // 외부에 알려주는 함수이기때문에
    // 알려주는 순간 함수가 끝난다
    // 리턴값은 자신이 리턴해주려는 자료형과
    // 동일한 자료형이어야한다. [ void -> int ]
    public int GetLV()
    {
        return LV;
    }
}

namespace _08_FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.SetHP(0);

            // 이런식으로 외부의 값을 받아서 
            // 객체 내부의 상태를 변화시키기위해
            // 함수를 선언하는 경우가 많다
            NewPlayer.Damage(20);

            Console.WriteLine("레벨 : {{0}} {0}", NewPlayer.GetLV());
        }
    }
}
