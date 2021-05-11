using System;

class Program
{
    // 배열을 언제 사용하느냐
    class Item
    {
        public string Name;
        public int ATT;
        public int DEF;
    }


    static void Main(string[] args)
    {
        // 배열은 기본 자료형에 속한다.
        // 특정 자료형이 연속으로 나열된 것
        // 선언 방식 - 자료형[]

        // 모든 자료형은 구조체 or 클래스
        // 기본 자료형도 마찬가지
        // 즉, 멤버변수, 멤버함수가 있다는 것 (.ToString, .Type, .Length, etc )


        int[] Arr_int = new int[10];
        // 기본적으로 0이 들어간다 = [0][0][0][0][0][0][0][0][0][0]

        for (int i = 0; i < Arr_int.Length; i++)
        {
            Console.WriteLine(Arr_int[i]);
        }


        // 클래스도 배열이 된다
        Item[] Arr_Item = new Item[10];
        // 담을 수 잇는 공간 10개 생성
        // 아이템이라는 메모리를 가리킬 수 있는 
        // 참조형 10개 생성 - new Item()과 헷갈리지 말자

        // Item NewItem = new Item(); 에서
        // Item NewItem 은 Item[] Arr_Item 와 같다
        // new Item()이 붙어야 비로소 객체화

        for (int i = 0; i < Arr_Item.Length; i++)
        {
            Arr_Item[i] = new Item();
        }

        Arr_Item[0].Name = "포션";
        Arr_Item[1].Name = "철검";
        Arr_Item[2].Name = "전설의 검";
        Arr_Item[3].Name = "갑옷";
        Arr_Item[4].Name = "전설의 갑옷";

        for (int i = 0; i < Arr_Item.Length; i++)
        {
            Console.WriteLine(Arr_Item[i].Name);
        }
    }
}