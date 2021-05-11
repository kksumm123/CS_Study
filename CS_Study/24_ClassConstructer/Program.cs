// 클래스와 상속클래스, 그 둘의 생성자는 누가 먼저 만들어지나?
// 부모클래스의 생성자가 먼저 만들어진다

class FightUnit
{
    protected int ATT;

    public FightUnit()
    {
        int a = 0;
    }
}

class Player : FightUnit
{
    // 생성자 - 객체가 만들어지는 순간 한 번만 실행
    // f10 디버깅으로 진입확인가능
    // 작성하지 않아도, 눈에 보이지않지만 만들어진다 (ex this.)
    // 특징
    // - 리턴값이 없다, void, int, etc...
    // - 함수의 이름이 클래스명

    // 접근제한지정자 private 가능, 클래스명 객체명 = new 생성자; 불가
    public Player()
    {
        int a = 0;
    }
}

namespace _24_ClassConstructer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(); // Classname InstanceName = new Constructer;
        }
    }
}
