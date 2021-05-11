using System;
/*
    RPG를 만든다 -> 프로젝트를 만든다
    주인공이 있다 -> Class
    주인공이 공격력이 있다. -> MemberVar
    주인공이 공격력으로 때린다 -> MemberFunc
 
    멤버함수 - 행동에 대해 설명
    지형에서 움직인다
    몬스터를 공격한다
    Npc와 대화한다
    스킬을 사용한다
*/

class Player
{
    // 명사 만으로는 부족해
    int ATT;
    int HP;

    // 행동으로 나타나게 된다.
    // 굉장히 다양한 방법으로 함수를 선언할 수 있지만 
    void Move() /*void[=리턴값] Move[=이름]() */
    {

    }

    void Fight()
    {

    }

    void Talk()
    {

    }

    void UsingSkill()
    {

    }
}
namespace _05_MemberFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
