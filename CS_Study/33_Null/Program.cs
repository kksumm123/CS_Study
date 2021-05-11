using System;

class Player
{
    private int mATT;
    
    public int ATT
    { 
        get { return mATT; }
        set { mATT = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer1 = new Player();
        
        // 가리키는게 없이 비워놓겠다
        // 참조형의 데이터 구조를 가리키는 자료형들은
        // 대표적으로 클래스
        // new 하게되면 클래스본체를 복사해서 그 주소를 가리킨다

        // null 하게되면
        Player NewPlayer2 = null;

        Console.WriteLine(NewPlayer1.ATT);
        
        // System.NullReferenceException 오류 발생
        Console.WriteLine(NewPlayer2.ATT);


        // 오류가 나는걸 어디에 쓰느냐?

        // 예를들면 인벤토리

        // '비어있는' 아이템 클래스가 들어있는 것
    }
}