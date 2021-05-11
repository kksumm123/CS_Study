using System;

/*
    객체지향 프로그래밍에서는 
    가장 처음으로 해야 할 일이

    ' 내가 rpg를 만들고 싶다. '
    클래스를 선언한다.
    class Dragon
    {
        int ATT; // 멤버변수
        Int HP; // 멤버변수

        // 멤버함수
        void Damage()
        {
            HP = HP - 10;
        }
    }
*/

class Player
{ // 클래스 내부

    /*
        접근제한 지정자
         - 객체지향의 캡슐화, 은닉화를 대표하는 문법
    */
    // 접근제한 지정자의 종류
    public int ATT; // 외부에도 공개
    private int DEF; // 내부에만 공개
    protected int HP; // 자식에게만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}

namespace _07_ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체이름. 으로 사용한다

            NewPlayer.ATT = 1000;
            NewPlayer.Fight();
        }
    }
}
