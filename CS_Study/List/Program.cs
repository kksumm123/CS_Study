using System;
using System.Collections.Generic;

class Item
{

}

class MyList<T>
{
    T Data;
    int Capa;
    int Count;
}


// 배열형 (시퀀스sequence)
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> NewMyList = new MyList<int>();


            // 자료형이 매번 바뀔 수 있으므로
            // list는 제네릭 클래스이다

            // List<Item> NewList = new List<Item>();
            List<int> NewList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                NewList.Add(i);
                Console.WriteLine((i + 1) + "번째");
                Console.WriteLine("Capacity : " + NewList.Capacity); // 배열의 크기
                Console.WriteLine("Count : " + NewList.Count); // 자료의 크기
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // 내부에 자료의 유무 리턴
            if (NewList.Contains(8))
            {
                Console.WriteLine("있다");
            }
            else
            {
                Console.WriteLine("없다");
            }

            // 클래스인데 이런 문법이 왜 가능하죠?
            // 인덱서 혹은 연산자 겹지정이라고 부른다
            Console.WriteLine(NewList[5]);

            // Console.WriteLine(NewList[999]);
            // OutofRange, 인덱스넘어가면 터진다

            // Capacity가 16이니 [12] 가능할까?
            // Console.WriteLine(NewList[12]);
            // 배열의 크기가 16인 것
            // 자료의 개수는 10

            Console.WriteLine("");
            Console.WriteLine("");

            NewList.Remove(10); // 10이 있다면 지운다.
            NewList.RemoveAt(1); // index 1의 자료를 지운다
            // NewList.RemoveAll 다른 리스트 혹은 배열을 넣어줬을 때, 
            //                      비교해서 중복이 있으면 지운다

            NewList.RemoveRange(0, 4); // index0 부터 4개 지워라

            for (int i = 0; i < NewList.Count; i++)
            {
                Console.WriteLine(NewList[i]);
            }
            
            // ToString이 내용을 문자열로 바꿔주는 것처럼
            // 자료를 배열로 바꾸는 것
            int[] Arr = NewList.ToArray();

            // 다 지워라
            NewList.Clear();
            for (int i = 0; i < NewList.Count; i++)
            {
                Console.WriteLine(NewList[i]);
            }
        }
    }
}
