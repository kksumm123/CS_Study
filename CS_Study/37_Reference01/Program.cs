using System;

class Player
{
    public int AT = 10;
    public int HP = 100;

    public bool IsDead()
    {
        Console.WriteLine("IsDead 메소드는 ");
        Console.WriteLine("플레이어의 죽음을확인합니다.");
        return HP <= 0;
    }
}

class Program
{
    static int Number = 100;

    static void PlayerTest(int[] _ArrTest)
    {
        _ArrTest[0] = 9999;
    }
    static void ClassTest(Player _Test)
    {
        _Test.AT = 9999;
    }
    static void ATTest(Player _Test)
    {
        Console.WriteLine("공격력 테스트");
        Console.WriteLine("언제 터지나");

        _Test.AT = 1000;
    }

    static void Main(string[] args)
    {
        // Player NewPlayer 이 변수는 어떤 녀석을 가리키는 일을 한다
        // 다른 녀석을 가리킬 수 있다.

        Player NewPlayer = new Player();
        Player NewPlayer_Tmp = NewPlayer;
        NewPlayer.AT = 50;
        Console.WriteLine(NewPlayer.AT);
        // 50 출력

        NewPlayer = new Player();
        Console.WriteLine(NewPlayer.AT);
        // 10 출력

        NewPlayer = NewPlayer_Tmp;
        Console.WriteLine(NewPlayer.AT);
        // 50 출력

        ClassTest(NewPlayer);
        Console.WriteLine(NewPlayer.AT);

        int[] ArrNum = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PlayerTest(ArrNum);
        Console.WriteLine(ArrNum[0]);
        // 9999 출력, 배열도 레퍼런스(참조)형이다 

        // 이 함수는 터질까 ?
        ATTest(null);

        // Player클래스를 할당받지도 않았는데
        // 메소드 호출이된다
        Player NewPlayer3 = null;
        // 다만 메소드 실행단계에서 터진다
        NewPlayer3.IsDead(); 
    }
}