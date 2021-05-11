using System;
using System.Collections.Generic;

class GTest<T>
{
    T Data;

}

// var = readonly struct System.Collections.Generic.KeyValuePair<TKey, TValue>
namespace System
{
    namespace Collections
    {
        namespace Generic
        {
            struct MyTest<TKey, TValue>
            {

            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*
        클래스도 자료형이므로 제네릭 사용이 가능
        이를 응용
        GTest<GTest<GTest<float>>> NewTest1;
        GTest<GTest<int>> NewTest2;
        */

        Dictionary<string, List<int>> NewDic;
        List<Dictionary<string, int>> NewList;
        List<Dictionary<string, LinkedList<Dictionary<string, string>>>> NewMonster;

        Dictionary<string, int> DicTest = new Dictionary<string, int>();

        // 웬만하면 그냥 순회방식을 사용해라.
        List<int> ListTest = new List<int>();
        LinkedList<int> LinkedListTest = new LinkedList<int>();

        DicTest.Add("일", 1);
        DicTest.Add("이", 2);
        DicTest.Add("삼", 3);
        DicTest.Add("사", 4);
        DicTest.Add("오", 5);

        ListTest.Add(1);
        ListTest.Add(2);
        ListTest.Add(3);
        ListTest.Add(4);
        ListTest.Add(5);

        LinkedListTest.AddLast(1);
        LinkedListTest.AddLast(2);
        LinkedListTest.AddLast(3);
        LinkedListTest.AddLast(4);
        LinkedListTest.AddLast(5);

        // var은 그 시점에서 가장 알맞은 자료형이 되어준다.
        // Struct 자료형
        // int Number = 100;
        // var AA = Number; - var은 int

        // foreach 는 자동적으로 반복하는 문장으로써
        // in을 통해 각 배열디느 딕셔너리든 리스트든
        // 내부의 자료를 그대로 순회할 수 있게 처리
        // var은 그때의 가장 적합한 자료형으로 처리된다
        // in은 자료구조에서 빼온다 라고 이해해도 된다
        // 대신 루프에 대한 제어가 어렵다
        // 정말 특별한 경우가 아니먼 거의 사용되지 않는다

        Console.WriteLine();
        Console.WriteLine("ListTest");
        foreach (var item in ListTest)
        { // var = int32
            if (item == 3)
                break;

            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("LinkedListTest");
        foreach (var item in LinkedListTest)
        { // var = int32
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("DicTest");
        foreach (var item in DicTest)
        { // var = readonly struct System.Collections.Generic.KeyValuePair<TKey, TValue>
            Console.WriteLine(item);
        }

        Console.WriteLine();
        foreach (KeyValuePair<string, int> item in DicTest)
        {
            Console.WriteLine(item.Key);
        }

        // 하얀색은 네임스페이스
        System.Collections.Generic.MyTest<int, int> Test;
    }
}