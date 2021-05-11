using System;


// interface - 사용자 정의 자료형
// 함수의 사용을 강제한다
interface QuestUnit
{
    // 멤버변수 불가 
    //int A = 0;

    // 함수의 형태만 물려줄 수 있는 문법
    void Talk(QuestUnit _OtherUnit);
    void WL(string _TEXT);
    // 빨간줄 - 인터페이스 멤버에는 정의를 사용할 수 없다.
    //void Talk(QuestUnit _OtherUnit)
    //{

    //}
}

class FightUnit
{
    int ATT;
    int DMG;

    public void Damage()
    {

    }
}

// 인터페이스는 함수구현을 강제할 수 있다.
// 인터페이스를 받으면 무조건 구현해야한다
// 인터페이스는 상속의 개념보다는 포함의 개념이다
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void WL(string _TEXT)
    {
        Console.WriteLine("test");
        Console.WriteLine(_TEXT);
    }
}

class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void WL(string _TEXT)
    {
        Console.WriteLine("test");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();
        // 불가
        // QuestUnit QuestUnit = new QuestUnit();

        NewPlayer.WL("TEXT");
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}