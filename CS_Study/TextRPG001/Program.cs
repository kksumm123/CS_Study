using System;

// 상속 - 코드 재활용성을 향상시키기 위한 문법
class FightUnit
{
    protected string Name = "None";
    protected int ATT = 10;
    protected int HP = 50;
    protected int m_Max_HP = 100;

    public int Max_HP
    {
        get
        {
            return m_Max_HP;
        }
        set
        {
            m_Max_HP = value;
        }
    }

    public bool IsDead()
    {
        /*bool boolDeath = HP <= 0;*/
        return HP <= 0; /*boolDeath;*/
    }

    public void StatusRender()
    {
        Console.WriteLine(Name + "---------");
        Console.WriteLine("공격력 : " + ATT);
        Console.WriteLine("HP : " + HP + "/" + m_Max_HP);
        Console.WriteLine("------------------");
    }

    public void Damage(FightUnit _Other)
    {
        HP -= _Other.ATT;
        Console.WriteLine("");
        Console.WriteLine(Name + "가 " + _Other.ATT + " 의 데미지를 입었습니다.");
        Console.ReadKey(true);
    }
}

// 클래스는 웬만하면 자기의 일은 스스로 하자
// 캡슐화 - 멤버변수나 멤버함수로써 전해주자
class Player : FightUnit
{
    Inven PlayerInven = new Inven(5, 3);

    public Inven P_Inven
    {
        get
        {
            return PlayerInven;
        }
    }

    public void PrintHP()
    {
        Console.WriteLine("HP : {0} / {1}", HP, m_Max_HP);
        Console.ReadKey(true);
    }
    public void Rest(/*Player this*/)
    {
        if (HP == m_Max_HP)
        {
            Console.WriteLine("이미 푹 쉬었습니다.");
        }
        else
        {
            this.HP = m_Max_HP;
        }
        PrintHP();
    }

    public Player()
    {
        Name = "플레이어";
    }
}

class Monster : FightUnit
{

    public Monster(string _Name)
    {
        Name = _Name;
    }
}

// 보통 enum 생성시
// 에러나 잘못된 선택에 관한 것도 만든다
enum STARTSELECT
{
    SELECT_TOWN,
    SELECT_BATTLE,
    NONESELECT
}

namespace TextRPG001
{
    class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을로 간다");
            Console.WriteLine("2. 사냥터로 간다");
            Console.WriteLine("어디로 가시겠습니까?");

            ConsoleKeyInfo CKL = Console.ReadKey(true);

            switch (CKL.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey(true);
                    return STARTSELECT.SELECT_TOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("사냥터로 이동합니다.");
                    Console.ReadKey(true);
                    return STARTSELECT.SELECT_BATTLE;
                default:
                    return STARTSELECT.NONESELECT;
            }
        }

        static void Shop(Inven _ShopInven, Player _Player)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("상점주인의 물건");
                _ShopInven.Render();
                Console.WriteLine("-----------------------");
                Console.WriteLine("플레이어의 물건");
                _Player.P_Inven.Render();
                Console.ReadKey(true);
            }
        }
        static STARTSELECT Town(Player _Player)
        {
            Inven ShopInven = new Inven(5,2);

            ShopInven.Add_Item(new Item("철검", 100));
            ShopInven.Add_Item(new Item("갑옷", 100));
            ShopInven.Add_Item(new Item("하하호호", 10));

            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("1. 여관에 들른다");
                Console.WriteLine("2. 상점에 들른다");
                Console.WriteLine("3. 마을 밖으로 나간다");
                Console.WriteLine("어디로 가시겠습니까?");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("여관에 들릅니다");
                        Console.ReadKey(true);
                        _Player.Rest();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("상점으로 이동합니다.");
                        Console.ReadKey(true);
                        Shop(ShopInven, _Player);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("마을밖으로 나갑니다.");
                        Console.ReadKey(true);
                        return STARTSELECT.NONESELECT;
                    default:
                        break;
                }
            }
        }
        static STARTSELECT Battle(Player _Player)
        {
            /*Console.WriteLine("아직 개장하지 않았습니다.");
            Console.ReadKey(true);*/
            Console.Clear();

            Monster NewMonster = new Monster("오크");

            // 1. 죽을때 까지 싸운다
            // 1-1. 권장 : 플레이어 한대, 몬스터 한대
            // 2. 한쪽이 죽으면 마을로 이동
            // 2-1. 플레이어 생존, 몬스터 사망
            // 2-2. 플레이어 사망, 몬스터 생존

            while (false == NewMonster.IsDead() && false == _Player.IsDead()) // 캐릭터 or 몹 누군가 죽을 때까지
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();

                NewMonster.Damage(_Player);
                if (false == NewMonster.IsDead())
                {
                    _Player.Damage(NewMonster);
                }
            }
            if (NewMonster.IsDead())
            {
                Console.WriteLine("플레이어의 승리");
            }
            else
            {
                Console.WriteLine("몬스터의 승리");
            }
            Console.WriteLine("전투가 종료되었습니다.");
            Console.ReadKey(true);
            return STARTSELECT.SELECT_TOWN;

        }
        static void Main(string[] args)
            {
            // 마을, 사냥터 존재 - 화면에서 어느 맵으로 갈지 선택
            /*
            1. 마을로 간다
            2. 사냥터로 간다

            마을의 내용
            마을에 도착했습니다.
                1. 여관에 들른다.
                2. 공격력을 강화한다
                3. 나간다

            사냥터의 내용
            사냥터에 도착했습니다.
                몬스터가 등장했다!
                    @@ 대미지를 입혔다! xx는 @@의 HP가 남았다.
            */

            /*while (true)
            {
                // 객체화 없이 사용가능한
                // static 함수(정적함수),
                // static 멤버변수(정적멤버변수)
                ConsoleKeyInfo KeyInfo = Console.ReadKey();

                Console.WriteLine(KeyInfo.Key);
            }*/

            Player NewPlayer = new Player();
            
            int HP = NewPlayer.Max_HP;
            NewPlayer.P_Inven.Add_Item(new Item("철검", 100));
            NewPlayer.P_Inven.Add_Item(new Item("갑옷", 100));

            STARTSELECT SelectCheck = STARTSELECT.NONESELECT;

            while (true)
            {
                switch (SelectCheck)
                {
                    case STARTSELECT.NONESELECT:
                        SelectCheck = StartSelect();
                        break;
                    case STARTSELECT.SELECT_TOWN:
                        SelectCheck = Town(NewPlayer);
                        break;
                    case STARTSELECT.SELECT_BATTLE:
                        SelectCheck = Battle(NewPlayer);
                        break;
                }
            }
        }
    }
}
