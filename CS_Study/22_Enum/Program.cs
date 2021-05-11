using System;

// 기본 자료형 -> 이미 있다.

// 사용자 정의자료형 중 하나
// class    참조형 사용자 정의
// struct   값형 사용자 정의
// enum     값형 사용자정의

// 타 언어에서는 enum = 정수형 상수
// C# 에서는 enum = 열거자 목록 ( 명명된 상수 집합 )
// 보통 어떤 상태를 표현하는 것 중
// 나만의 것을 가지고 싶을 때 사용
// 
enum ITEMTYPE
{
    // 값의 범위를 지정한 새로운 자료형을 만들어 낼 수 있다
    // Switch 문과 궁합이 좋다
    EQUIP,
    POTION,
    QUEST,
    NONESELECT
}

// 일일이
// class EQUIP, class POTION, class QUEST 하지않는다
class Item
{
    //int ItemType = 0; 숫자로 지정 시 가독성이 매우 떨어진다
    public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;

    public void PotionTypeSetting()
    {
        ItemType = ITEMTYPE.POTION;
    }
}

namespace _22_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();

            //NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSetting();
            //Console.WriteLine(ITEMTYPE.POTION);
            Console.WriteLine(NewItem.ItemType);

            // [tab][tab]후 갈색이 되었을 때 자동완성가능
            ITEMTYPE Type = ITEMTYPE.POTION;
            switch (Type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                case ITEMTYPE.NONESELECT:
                    break;
                default:
                    break;
            }
        }
    }
}
