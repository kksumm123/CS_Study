// Ctrl + Shift + U - 대문자 변경
struct StructData
{
    public int a;
    public int b;
    // 클래스와 비슷한데 안되는 것
    // 리터럴 초기화가 안된다 -> = @; 안된다 ( int a = 0; )

    public void Func()
    {
        a = 100;
        b = 100;
    }
}

namespace _21_Struct
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }
        static void TestNum(int TestNum)
        {
            TestNum = 1000;
        }

        static void Main(string[] args)
        {
            int Num = 100;

            StructData NewData = new StructData();

            NewData.a = 10;
            NewData.b = 10;

            // 참조형(=레퍼런스형)과 값형
            // 클래스를 객체화화면 참조형
            // Struct는 값형
            Test(NewData);
            TestNum(Num);
        }
    }
}
