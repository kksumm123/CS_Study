// 메모리를 왜 알아야 하느냐?
// 모든 프로그램의 근간이 되는 개념
// 모든 프로그램은 메모리에 올라가므로
// 메모리를 안다는 것은 코드의 동작원리를 아는 것과 같다

class Player
{
    int HP = 500;

    public void Damage(int _Dmg)
    {
        HP -= _Dmg;
    }

}

namespace _10_Memory00_Func_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 객체를 만들었다는 것은 메모리를 지불했다는 것
            Player NewPlayer = new Player();

        }
    }
}
