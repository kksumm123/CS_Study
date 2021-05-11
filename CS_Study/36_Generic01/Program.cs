using System;

// 정적 변수와 정적 함수만을 내부에 넣는다
public static class GTest
{
    // 생성자를 만들 수 없다.
    //public GTest()
    //{ }

    // static class 이므로 정적이 아닌 메소드 생성 불가
    //public void TETE()
    //{ }


    public static void ConsolePrint(int _Value)
    {
        Console.WriteLine(_Value);
    }
    public static void ConsolePrint(string _Text)
    {
        Console.WriteLine(_Text);
    }

    // 제네릭 함수
    // 자료형을 변수처럼 사용하고 싶을 때,
    // 함수의 식별자에 <다양한 자료형을 대표할 이름>
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }

    // 여러개도 사용가능
    public static T ConsolePrint<T, U>(T _Value1, U _Value2)
    {
        Console.WriteLine(_Value1);
        Console.WriteLine(_Value2);
        return _Value1;
    }
    // 리턴값 정의가능, 당연하게도 명칭도 변경가능
    public static void ConsolePrint<T, T2, T3>(T _Value1, T2 _Value2, T3 _Value3)
    {
        Console.WriteLine(_Value1);
        Console.WriteLine(_Value2);
        Console.WriteLine(_Value3);
    }
}

// 인벤은 캐릭터 뿐 아니라
// 상점, 캐쉬아이템, 창고 등 여러가지
class Inven<T>
{
    // 아이템에 따라 각각 캐쉬인벤, 창고인벤 만들지 말고
    // 제네릭을 쓰자

    //GameItem[] ArrInven_Item;
    //CashItem[] ArrInven_Item;
    T[] ArrInvenItem;

    public void ItemIn(T _Inven)
    {

    }
}
class GameItem
{

}
class CashItem
{

}

class Program
{
    static void Main(string[] args)
    {
       GTest.ConsolePrint(1000);

        float Value = 1.2345f;
        // GTest.ConsolePrint(Value); float은 정의되지 않앗으므로 사용불가
        // 제네릭 함수를 만들었더니 사용가능
        GTest.ConsolePrint(Value);

        GTest.ConsolePrint("안녕하세요", "반갑습니다");

        // 명시적 호출 사용가능
        GTest.ConsolePrint<string, string>("명시적 호출도", "사용이 됩니다.");

        //GTest. 입력시 2가지 항목 확인가능
        //     .ConsolePrint
        //     .ConsolePrint<>

        // 클래스는 무 조 건  명시적 호출만 사용가능
        // 클래스는 무 조 건  명시적 호출만 사용가능
        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        GameItem NewGameItem = new GameItem();

        // 마우스를 대 보면 필요 매개변수 GameItem _Inven확인가능
        // NewGameItemInven.ItemIn()
        NewGameItemInven.ItemIn(NewGameItem);

        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        CashItem NewCashItem = new CashItem();
        NewCashItemInven.ItemIn(NewCashItem);
    }
}