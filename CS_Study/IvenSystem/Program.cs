using System;



// 맵, 캐릭터, 인벤토리, 씨앗, 애완동물...
// 다 만들 수 있는 실력을 가졌다고 해도
// 무엇부터 만드는게 좋을까?
// 그 테크닉을 알려줄 수 있는 사람이 있다면 무조건 도움을 받아라
// 캐릭터 -> FSM(유한 상태기계)
// 기능 하나하나는 어느정도수준까지( 버그가 보이지않는 수준까지)




class Program
{
    static void Main(string[] args)
    {
        // * * * * *
        // * * * * *
        // * * * * *
        // class 인벤, 
        // 아이템이 여러개 있어야한다
        //  - 아이템 배열을 변수로 가졌다.
        // 아이템을 x, y에 맞게 출력하고 싶다
        //  - ItemX 변수를 가졌다.
        Inven NewInven = new Inven(5, 3);

        //Item NewItem = new Item("철검", 100);

        // 이제는 아이템을 넣고 싶다
        // 넣는다, 동사 - 인벤에 아이템을 넣는다.
        // 아래처럼도 사용 가능
        NewInven.Add_Item(new Item("철검", 100));
        NewInven.Add_Item(new Item("갑옷", 100));
        NewInven.Add_Item(new Item("포션", 100), 4);
        /*
            왜 저게 되지?
            Item NewItem = new Item("철검", 100);
            위의 코드는 

            Item NewItem;
            NewItem = new Item("철검", 100);
            로 풀어쓸 수 있다.

            Int A;를 하듯, 변수를 선언, 생성하는 코드인데
            아이템을 따로 가질 게 아니라면,
            무조건 인벤토리에 들어간다면
            아이템이 따로 변수를 할당받아 존재할 필요가 없다!
            
            그러므로 클래스를 담을 변수를 선언하지않고
            곧바로 인벤토리의 아이템배열에 넣는다.
        */


        // 이런 객체간의 구조를 만들 때 도움이 될만한 규칙
        // SOLID - 객체지향 5가지 원리
        // 1. SRP (단일책임의 원칙: Single Responsibility Principle)
        // 2. OCP (개방폐쇄의 원칙: Open Close Principle)
        // 3. LSP(리스코브 치환의 원칙: The Liskov Substitution Principle)
        // 4. ISP(인터페이스 분리의 원칙: Interface Segregation Principle)
        //  ex) 함수를 만들때, 함수를 잘게 쪼개서 만든 다음
        //      그 잘게 쪼갠 함수를 조합하여 새로운 기능을 만들어 내라.
        // 5. DIP(의존성역전의 원칙: Dependency Inversion Principle)
        while (true)
        {
            Console.Clear();

            NewInven.Render();

            NewInven.SelectMove(Console.ReadKey(true).Key);
        }

    }
}