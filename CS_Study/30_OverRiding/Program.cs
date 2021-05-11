using System;


//
// 플레이어의 무기 공격력을 추가하여 대미지를 입히고 싶다.
//
// 오버라이딩 - OverRiding
// 다형성(동적바인딩)의 핵심 문법 중 하나
// 다형성 - 업캐스팅, 오버라이딩, ...

// 업캐스팅이 다형성인 이유
// Damage(FightUnit _Other) 실체는 FightUnit 이지만
// 실제론 Player일수도, Monster일수도

class FightUnit
{
    // private - 내부까지
    // protected - 자식까지
    // public - 외부까지
    protected string Name = "NONE";
    protected int ATT = 10;
    protected int HP = 100;

    //public static virtual void TEST()
    //{
    // this. 가 없어서 virtual 안됨.
    //}


    // 플레이어와 몬스터는 FightUnit 될 수 있다
    // 이것이 업캐스팅 (UpCasting)
    // 피상속 클래스의 코드 간략화 (코드재활용성, 적게치고 최대한의 효과) 
    public void Damage(FightUnit _Other)
    {
        int New_ATT = _Other.DMGATT;
        Console.WriteLine(Name + "는 " + _Other.Name + "에게 " + New_ATT + " 데미지를 입었습니다.");
        HP -= _Other.ATT;
    }

    // 프로퍼티도 오버라이딩이 가능
    public virtual int DMGATT
    {
        get
        {
            return ATT;
        }
    }

    // 이 문법(오버라이딩)의 핵심은
    // 같은 이름의 함수나 프로퍼티를 
    // 자식클래스에서 같은 이름의 함수나 프로퍼티를 재구현 했다면
    // 자식클래스에서 같은 이름의 함수나 프로퍼티를 호출해주세요.
    //public virtual int GetATT()
    //{
    //    Console.WriteLine("파이트유닛의 GetATT");
    //    return ATT;
    //}

    // 오버로딩을 이용해서도 해결 가능
    // 효율적이지 않은 방법
    // 이유 - Player만의 멤버변수를 쓰려면 public 또는 Get함수를 써야한다
    /*public void Damage(Player _Other)
    {
        Console.WriteLine(_Other.Name + "가 " + _Other.ATT + " 데미지를 입혔습니다.");
        HP -= _Other.ATT;
    }*/
}

class Player : FightUnit
{
    int Item_ATT = 5;

    // 오버라이딩 - OverRiding
    // 다형성의 핵심 문법 중 하나
    // 나는 부모클래스의 GetATT를 재구현했다.
    //public override int GetATT()
    //{
    //    Console.WriteLine("플레이어의 GetATT");
    //    return ATT + Item_ATT;
    //}
    public override int DMGATT
    {
        get
        {
            return ATT + Item_ATT;
        }
    }

    public Player()
    {
        Name = "이름 업쪄";
    }

    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    int MonsterLV = 2;

    //public override int GetATT()
    //{
    //    Console.WriteLine("몬스터의 GetATT");
    //    return ATT + MonsterLV;
    //}
    public override int DMGATT
    {
        get
        {
            return ATT + MonsterLV;
        }
    }

    public Monster(string _Name, int _MonsterStartLV)
    {
        Name = _Name;
        MonsterLV = _MonsterStartLV;
    }
}

namespace _30_OverRiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("오크", 2);
            // FightUnit NewUnit = NewMonster;

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
