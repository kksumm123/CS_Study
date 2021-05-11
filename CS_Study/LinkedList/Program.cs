using System;
using System.Collections.Generic;

class Node<T>
{
    // 게임의 맵에서 많이 사용한다
    // 몇개든 상관없다
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkedList<T>
{
    public Node<T> First;
    public Node<T> Last;
}

class Program
{
    static void Main(string[] args)
    {
        // 시퀀스 배열형 - list
        // 시퀀스 노드형 - linkedlist
        LinkedList<int> LList = new LinkedList<int>();

        // 노드들을 관리해주는
        // LinkedList<int>
        // LList.First
        // LList.Last
        // 노드 사이사이를 타고 다니는 클래스
        // LinkedListNode
        
        // 최초입력에는 First/Last 차이없다
        LList.AddFirst(10);
        //LList.AddLast(10);

        // 자료의 앞에 붙게됨 (Prev,이전)
        LList.AddFirst(20);
        LList.AddFirst(33);
        LList.AddFirst(44);

        LinkedListNode<int> Cur = LList.First;
        Cur = Cur.Next;
        LList.AddAfter(Cur, 999);


        for (
            LinkedListNode<int> StartNode = LList.First
            ; StartNode != null
            ; StartNode = StartNode.Next )
        {
            Console.WriteLine(StartNode.Value);
        }

        // 다 지워라
        LList.Clear();

        for (
            LinkedListNode<int> StartNode = LList.Last
            ; StartNode != null
            ; StartNode = StartNode.Previous)
        {
            Console.WriteLine(StartNode.Value);
        }

        //LinkedListNode<int> StartNode = LList.First;
    }
}