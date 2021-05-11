using System;

// 노드는 단순히 자료구조에서만 사용하는 것은 아니다
// 자료구조라고하면
// 자료를 보관해야하므로
// 제네릭으로 만들어짐
class Node<T>
{
    public T Data;

    // 자신안에 자기 자신을 또 가지는 형태
    // 
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(10);
        Node<int> Node2 = new Node<int>(999);
        Node<int> Node3 = new Node<int>(578);  

        Node1.Next = Node2;
        Node2.Next = Node3;

        Node3.Prev = Node2;
        Node2.Prev = Node1;

        Node<int> CurNode = Node1;

        while (CurNode != null)
        {
            Console.WriteLine(CurNode.Data);
            CurNode = CurNode.Next;
        }

        Node<int> RCurNode = Node3;

        while (RCurNode != null)
        {
            Console.WriteLine(RCurNode.Data);
            RCurNode = RCurNode.Prev;
        }
    }
}