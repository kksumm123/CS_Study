using System;
using System.Collections.Generic;
using System.Text;

// 잘못 쓰기도 힘들게 만들어라
// 잘못 쓰기도 힘들게 만들어라
// 잘못 쓰기도 힘들게 만들어라
// 잘못 쓰기도 힘들게 만들어라
// 잘못 쓰기도 힘들게 만들어라
// 잘못 쓰기도 힘들게 만들어라

// 나는 아이템을 담아두는 인벤토리를 만들고 싶다.
// 나는 인벤토리가 만들어질 때, 
// 먼저 최대 몇개를 담을 수 있는지부터
// 정하지 않으면, new도 하면 안된다고 생각한다.

// 인자값을 주지않으면 만들어지지 않는,
// 생성자 사용

// 이때, 숫자는 2개 필요한데
// x와 y
// 담을 수 있는 아이템의 총 개수는 
// x * y
// int x와 y를 받아서 인벤토리 생성

class Inven
{
    Item[] Arr_Item;
    int ItemX;
    int SelectIndex;

    // 객체의 교류
    // 인벤은 아이템이 필요해요
    public void Add_Item(Item _Item)
    {
        for (int i = 0; i < Arr_Item.Length; i++)
        {
            if ( Arr_Item[i] == null )
            {
                Arr_Item[i] = _Item;
                break;
            }
        }
    }
    public void Add_Item(Item _Item, int _Order)
    {
        if (_Order < Arr_Item.Length && Arr_Item[_Order] == null)
        {
            Arr_Item[_Order] = _Item;
        }
    }

    // 인벤토리 이동을 방향키로 구현했을 때,
    // 사용자가 다른 키로 바꾸고싶다면 ?
    // 그때마다 새로 하드코딩할 것인가 ?
    

    public bool OverCheck(int _SelectIndex)
    {
        if (0 > _SelectIndex || _SelectIndex >= Arr_Item.Length)
        {
            return true;
        }
        return false;
    }

    public void SelectMove(ConsoleKey Key)
    {
        switch (Key)
        {
            case ConsoleKey.LeftArrow:
                SelectMoveLeft();
                break;
            case ConsoleKey.RightArrow:
                SelectMoveRight();
                break;
            case ConsoleKey.UpArrow:
                SelectMoveUp();
                break;
            case ConsoleKey.DownArrow:
                SelectMoveDown();
                break;
            default:
                break;
        }
    }
    
    void SelectMoveLeft()
    {
        int CheckIndex = SelectIndex;
        
        CheckIndex -= 1;

        if (OverCheck(CheckIndex) == true)
        { 
            return;
        }

        SelectIndex = CheckIndex;
    }
    void SelectMoveRight()
    {
        int CheckIndex = SelectIndex;

        CheckIndex += 1;

        if (OverCheck(CheckIndex) == true)
        {
            return;
        }

        SelectIndex = CheckIndex;
    }
    void SelectMoveUp()
    {
        int CheckIndex = SelectIndex;

        CheckIndex -= ItemX;

        if (OverCheck(CheckIndex) == true)
        {
            return;
        }

        SelectIndex = CheckIndex;
    }
    void SelectMoveDown()
    {
        int CheckIndex = SelectIndex;

        CheckIndex += ItemX;

        if (OverCheck(CheckIndex) == true)
        {
            return;
        }

        SelectIndex = CheckIndex;
    }


    public void Render()
    {
        for (int i = 0; i < Arr_Item.Length; i++)
        {
            if (i != 0 && i % ItemX == 0)
            {
                Console.WriteLine("");
            }
            
            if (SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if ( Arr_Item[i] == null)
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }
        }

        Console.WriteLine();
        if ( Arr_Item[SelectIndex] != null )
        {
            Console.WriteLine("현재 선택된 아이템");
            Console.WriteLine("이름 : " + Arr_Item[SelectIndex].Name);
            Console.WriteLine("가격 : " + Arr_Item[SelectIndex].Gold);
        }
        else
        {
            Console.WriteLine("현재 선택된 아이템");
            Console.WriteLine("비어있음");
        }
    }


    // 인벤토리를 new 하려면
    // x와 y를 넣어줘야한다
    // 실수를 막기 위해서, 예외상황을 만들지 않기 위해서
    public Inven(int _X, int _Y)
    {
        // 초보 프로그래머가 가장 주의해야할 것
        // 방어코드는 선택이 아니다.
        // 방어코드란?
        // switch 문의 default, 프로그램이 터지거나 오작동하지 않게
        // 들어오는 값들을 체크해서 문제가 없게 만드는 코드
        // 검사하고 사용한다

        // 함수를 짤 때, 항상 자신만의 디폴트를 만들어야한다.
        if ( _X < 1)
        {
            _X = 1;
        }
        if (_Y < 1)
        {
            _Y = 1;
        }

        ItemX = _X;
        Arr_Item = new Item[ (_X * _Y) ];
    }
}