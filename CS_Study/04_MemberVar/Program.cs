using System;
/*
한글을 보통 사용하지 않는다
쓸 수 없다는 것은 아니지만
일단 모든 이런 시스템 영어의 코드를 쳐졌다.
한글의 처리가, 미흡한 점들이 몇몇 곳에서 있다.

게임을 만들게 되면 
큰 개념

Rpg
    플레이어가 가질 수 있는 세부적인 내용
Gold, 경험치, 공격력, 방어력
명사로 표현되는 것들은 대부분 MemberVar로 표현된다

*/

// 개념 : 플레이어가 있다
class Player
{
    /*
        내용을 채우는 것에 대한 이야기이다.
        개념 : 플레이어는 골드를 가진다.
        세부속성이면서, 명사이면서, 값 
    */
    /*
    멤버변수의 선언은 자료형과 이름으로 선언
    ex)
        int(=자료형) 이름(=식별자)

    선언함과 동시에 초기값(=리터럴 값) 넣어줄 수 있다.

    검색능력도 프로그래머의 능력
    남의 힘을 얼마나 잘 빌려 사용하느냐
    인터넷에 자료들이 굴러다닌다
    
    1. 공짜가 없다
           무언가를 만들기 위해서 메모리를 지불한다.
    2. 

    프로그램 실행하면
    1. 프로그램이 램에 올라간다(복사)



    자료형의 의미
        크기 : 4바이트
        형태 : int=정수
    이름의 의미
        위치 : 주소
    
    int Att = 300;
    int Att
    -> 램에 0000번지(Att's Addr)에 4바이트 만큼의 공간을 만들어라
    = 300;
    -> 0000번지에 300이라는 값을 넣어라

    수학적의미로는 규칙이나 물리법칙

    ecx 0x2162312 cpy 0000
    */

    // 이 아래것들은 쉬운것 ( 바로 와닿기 때문 )
    int Gold; // < MemberVar
    int Exp;
    int Att;
    int Def;
    int HP;
    // 현재 전투가 가능한 상태인지 확인하는 변수, 
    bool isFight;
}

namespace _04_MemberVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
