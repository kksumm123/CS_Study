using System;

// 최악의 생각들
// 나대면 안된다. - 질문을 해야 한다
// 정답을 말해야 한다
// 모른다고 말하면 안된다



// 자료 구조를 직접 만들어 보는 것은
// 게임 프로그래머의 언어와 같이 기초소양

// 자료 구조에 대해서 알아보자
// 데이터 값의 모임,
// 데이터 간의 관계,
// 데이터에 적용할 함수나 명령

// 총알 1000발이 발사, 어떻게 관리하지?
// NPC가 500명, 그중에서 '피오나'라는 이름의 NPC, 어떻게 찾지?

// 인벤토리도 자료구조로 볼 수 있고
// 스킬도 자료구조로 볼 수 있다.

class MyDataStruct<T>
{
    // 삽입()
    public void Push(T _Data)
    {
        if (/*내 크기를 넘어가면*/true)
        {
            this.Expend(/*적절한 수*/_Data);
        }
        // 여러가지 예외처리할 것이 있다
    }

    // 탐색()
    public T Find(T _Data)
    {
        return _Data;
    }
    
    // 확장()
    public void Expend(T _Data)
    { }
}

class Program
{
    static void Main(string[] args)
    {
        // 자료구조이다, 다만 불편한 자료구조
        int[] arr = new int[10];

        // 자료구조에는 컨테이너라는 용어를 사용
        // 시퀀스 컨테이너,
        //      데이터를 선형으로 저장,
        //      삽입된 요소의 순서가 그대로 유지
        //      종류
        //          1.vector(c++) <-> (C#) list
        //          2.deque
        //          3.list
        //          4.forward_list
        // 연관 컨테이너,
        //      키(key)와 값(value)처럼 관련있는 데이터를 하나의 쌍으로 저장
        //      삽입되는 요소의 위치를 지정 불가
        //      이진 탐색 트리(balanced binary search tree)나 해시 테이블(hash table)을 이용하여 구현
        //      종류 
        //          1.set
        //          2.multiset
        //          3.map (java, c++)
        //          4.multimap
        //          5.SortedList
        //          6.Dictionary(hashmap)
        // 어댑터 컨테이너 - 시퀀스or연관에서 변형이 이루어지면 어댑터
        //      기존 컨테이너의 인터페이스를 제한하여 만든 기능이 제한되거나 변형된 컨테이너
        //      각각의 기초가 되는 클래스의 인터페이스를 제한하여, 특정 형태의 동작만을 수행
        //      종류
        //          1.stack
        //          2.queue
        //          3.priority_queue

        // 데이터의 메모리 구조는
        // 배열형,
        // 노드형



        // 자료구조라는 건 
        // int 10개
        // 0 1 2 3 4 5 6 7 8 9

        // 자료구조에는 다음의 구조나 인터페이스를 지원한다
        // 삽입()
        // 탐색()
        // 확장() - 자동으로 이루어지기에 확장은 요즘 잘 사용하지않는다,
        //          100개가 필요해? 내가 100개짜리로 늘어날게, 하지
        //          일일히 길이를 선언해주지않는다


        // 이것 또한 자료구조
        MyDataStruct<int> MDS = new MyDataStruct<int>();
        MDS.Push(100);
        MDS.Find(50);
        MDS.Expend(100);

    }
}