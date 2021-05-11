//using _28_Partial;


// C#에는 특별한 문법이 있다.
// 클래스가 너무 길어지고 함수가 너무 많아진 경우
// 파일을 나눠서 저장, 관리 할 수 있다.

class Program
{
    static void Main(string[] args)
    {
        // using _28_Partial 추가하여
        // 네임스페이스 생략가능
        //_28_Partial.Player NewPlayer1 = new _28_Partial.Player();
        Player NewPlayer = new Player();

        NewPlayer.Fund1();
        NewPlayer.Damage();
        NewPlayer.EventStart();
    }
}
