class Player
{
    private int HP = 100;

    private static int StHP = 100;

    public static void PvP(Player _Left, Player Right)
    {
        // HP = 1000; ( 빨간줄 )
        // 왜 오류가 나는가 ? - 객체화 없이도 사용이 되기때문
        // this.HP = 100 ; ( 빨간줄 )
        // static 멤버함수는 '자신(=this)'의 개념이 없는 함수

        StHP = 50;
        // 정적멤버변수만이
        // 정적멤버함수에서 사용가능
    }

    public void Damage(int _Dmg)
    {
        HP -= _Dmg; // <->  this.HP -= _Dmg;
        // NewPlayer2가 호출했으니까 NewPlayer2.HP 라는 것을 알 수 있다
        // 90% 맞다
    }

    public static void P2Damge(Player _Player, int _Dmg)
    {
        _Player.HP -= _Dmg;
    }

    // 멤버함수에서 멤버 변수를 쓴다면 눈에 보이진 않지만
    // 앞에 this. 생략되어있는 것
    // 사용할 때마다 객체가 붙으면 귀찮아진다
    // 따라서 생략가능
    public void Heal( /*Player this,*/ int _Heal)
    {
        HP += _Heal;
        /*this.HP += _Heal;*/
    }
}

namespace _16_this
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Damage(50);


            NewPlayer2.Heal(/* NewPlayer2, */ 100);
        }
    }
}
