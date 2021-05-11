class Player
{

}

class Pet
{

}
class Monster
{

}

//Item NewItem = new Item("철검", 100);

// 이제는 아이템을 넣고 싶다
// 넣는다, 동사 - 인벤에 아이템을 넣는다.
// 아래처럼도 사용 가능
//
//NewInven.Add_Item(new Item("철검", 100));

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