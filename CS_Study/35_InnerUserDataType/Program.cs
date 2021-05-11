using System;




class Player
{
    // 플레이어만 사용한다
    // 다른 곳에 정의될 수도 있다.
    // 따라서 class Player 안에 넣어둔다
    // 그 클래스가 혼자서 사용할 때,
    // 정의까지 넣는다
    public enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        ARCHER,
        MAGICIAN,
        ROGUE
    }
    //직업과 관련된 멤버변수도 필요


    void ClassChange() // 직업을 바꿔주는 메소드
    {

    }
}

class Inven
{
    private int SelectIndex;
    public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();

        // 클래스 자기자신도 this로 넘어갈 수 있다.
        NewInvenSlot.Select(this);
    }

    public class InvenSlot
    {
        int Index;
        // 클래스 안에 클래스 가능
        // 접근제한지정자는 일반 private 쓴다
        // 그러다가 getset 함수도 만들고
        // 그래도 도저히 아무래도 안된다면 public
        public void Select(Inven _Inven)
        {
            // 자기클래스 내부에 있는 클래스더라도
            // 다른 클래스이다
            // SelectIndex = 100; - 빨간줄

            // 내부 클래스에서 바깥 클래스(Inven)의 멤버변수를
            // 마지 public 처럼 사용했다
            _Inven.SelectIndex = 100;
        }
    }
    // 퍼블릭 주고 사용할거면 밖에 있는것과 무슨 상관이 잇냐?
    // 이름겹침에서 자유롭다

    // 온전히 하나의 클래스가 자신의 내부에서 
    // 모든걸 처리할 수 있게 하려면
    // 자신과 밀접한 관련된 자료형들도
    // 내부에 포함하는 것이 좋다
    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN
    }

    void SelectMove(/*방향을 의미할만한 인자값*/)
    {

    }
}


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        Inven NewInven = new Inven();
        Inven.INVENDIR ID = Inven.INVENDIR.ID_LEFT;

    }
}