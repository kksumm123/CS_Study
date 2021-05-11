// 상속 - 코드 재활용성 향상을 위해
// 똑같은 코드 2번 입력이 싫어서 = 함수도 마찬가지
// 어떤 계열이 있느냐를 파악하는 감
// FightUnit = 부모       - 상속클래스
// Player, Monster = 자식 - 피상속 클래스

// 공통되는 기능을 하는 멤버 변수과, 멤버 함수를 걷어낸다
/*class Player
{
    int LV = 1;
    int ATT = 10;
    int HP = 100;

    public void Damage(int _Dmg )
    {
        HP -= _Dmg;
    }
}

class Monster
{
    int ATT = 10;
    int HP = 100;

    public void Damage(int _Dmg)
    {
        HP -= _Dmg;
    }
}*/

class FightUnit
{
    //        public    protected   private(default)
    //범위    외부까지  자식까지    나까지 
    protected int ATT = 10;
    protected int HP = 100;

    /*public void Damage(int _Dmg)
    {
        HP -= _Dmg;
    }*/
    public void Damage(FightUnit _Other)
    {
        // 인자가 FightUnit 이지만
        // NewPlayer.Damage(NewMonster); - 사용가능

        // FightUnit이지만
        // 이 안에서 class Player의 기능을 쓰고 싶은 것
        // 다운캐스팅 - 최대한 지'양'해라
        // Player를 Monster로 변경할 수도 있다.
        // 왜냐? _Other로 들어올 객체가 
        // Player와 Monster 두가지

        HP -= _Other.ATT;
    }
}

// 내려준다, 상속시킨다
// C#에서 클래스 상속은 오직 하나만 가능
// 클래스 상속을 여러개 받는 언어도 존재
// C#은 아니다
class Player : FightUnit
{
    int LV = 1;
    int EXP = 0;

    void Heal()
    {
        HP = 100;
        // FightUnit 클래스의 
        // HP 멤버변수의 접근제한 지정자를 
        // protected로 해야 사용가능
    }
}

class Monster : FightUnit
{
    int EXP = 10;

}


namespace _23_Inharitance
{

    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();


            // FightUnit FU = NewMonster;
            // 업캐스팅 - 클래스 몬스터의 부분은 포기하겠다

            NewPlayer.Damage(/*FU*/ NewMonster);
            NewMonster.Damage(/*FU*/ NewPlayer);
        }
    }
}
