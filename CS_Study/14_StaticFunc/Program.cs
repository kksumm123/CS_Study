using System;

public class Player
{
    int ATT = 20;
    int HP = 100;

    public void Damage(int _Dmg)
    {
        HP -= _Dmg;
        Console.WriteLine(HP);
    }

    // 

    public static void PvP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.ATT;
        _Right.HP -= _Left.ATT;
    }

    //public static void PvE(Player _Left, Monster _Right)
    //{
    //    _Left.HP -= _Right.ATT;
    //    _Right.HP -= _Left.ATT;
    //}
}

public class Monster
{
    int ATT = 50;
    int HP = 100;
}

namespace _14_StaticFunc
{
    class Program
    {
        // 이 Main 함수는 클래스에 속한 정적함수이다
        // 어떤 클래스에 존재하는 Main이름을 가진
        // 정적멤버함수에서부터 C#프로그램은 시작한다
        static void Main(string[] args)
        {
            // F12를 누르면 해당 클래스로 이동가능
            // 해당 클래스의 세부내용 알 수 있다
            //Console.WriteLine = 정적 멤버함수 - 객체화 하지않고 사용
            Console.WriteLine("Learing static Func.");

            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

            // 객체화를 하지 않고도 사용할 수 있다?
            //Player.PvP(NewPlayer1, NewPlayer2);
        }
    }
}
