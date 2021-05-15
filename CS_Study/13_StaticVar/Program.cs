// static

/*
    메모리의 구조 
    코드 영역 : 상수, 클래스 그 자체 함수의 내용, 수정이 불가능한 곳
    데이터 영역 : 정적멤버변수
    힙 영역 : new 클래스명()으로 만들어진 클래스 객체들
    스택 영역 : 함수의 실행 메모리영역 ( ex 지역변수 )
 */


class SidePlayer
{
    // 정적 멤버 변수 (static)
    // 객체귀속 x, 클래스 귀속, 전체 객체가 공유
    public static int PlayerCount;

    public int X = 0;
    public int Y = 0;
    public int HP = 100;

    public void Gravity()
    {
        Y -= 200;
    }


}
class Player
{
    // 앞에 static이 붙은 경우
    // 정적 멤버변수라고 한다
    // 일반적인 멤버변수와 다르게
    // 객체화를 하지않고 사용가능
    // 클래스의 이름만으로 사용 가능
    public static int PlayerCount = 0;

    public int ATT = 10;
    public int HP = 100;

    // 정적멤버변수 클래스 내부 안에서는 사용가능
    public void Setting(int _ATT, int _HP)
    {
        PlayerCount = 100;

        ATT = _ATT;
        HP = _HP;
    }

}

// 몬스터가 일정마리수 죽으면 무언가 발동되는 경우
class Monster
{
    static int MonsterDeathCount = 0;

    public void Death()
    {
        MonsterDeathCount += 1;
    }
}

namespace _13_StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 모든 객체가 공유하고 싶은 변수를 만들 때 사용
            SidePlayer NewSidePlayer1 = new SidePlayer();
            SidePlayer NewSidePlayer2 = new SidePlayer();
            SidePlayer NewSidePlayer3 = new SidePlayer();
            SidePlayer.PlayerCount = 3;

            // 플레이어를 3번 new 하게 되면
            // 플레이어가 3개 생김
            Player NewPlayer1 = new Player();
            Player.PlayerCount = 1;
            Player NewPlayer2 = new Player();
            Player.PlayerCount = 2;
            Player NewPlayer3 = new Player();
            Player.PlayerCount = 3;

            // 위 방식으로 객체화를 사용하지 않고 사용
            // Wrong Ex) NewPlayer2.PlayerCount++; - Occur Error
            // 정적 멤버변수는 데이터영역(메모리의 구조)에 들어간다

            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 50);
            NewPlayer3.Setting(100, 500);

            // 어느 클래스가 공유하고 싶은 값,
            // ex) 몬스터 클래스라면, 현존하는 몬스터의 수
            // 모든 객체가 공유하는 하나의 값

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            // 모든 객체가 값을 공유할 필요가 있는 데이터를 정의
            NewMonster1.Death();
            NewMonster2.Death();
            NewMonster3.Death();
        }
    }
}

