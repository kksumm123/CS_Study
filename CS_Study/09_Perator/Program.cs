class Player
{
    int HP = 100;

    void Damage(int _HP)
    {
        HP = _HP - 10;
    }
}

namespace _09_Perator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // 산술연산자
            Result = Left + Right;
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;

            // 비교연산자 - 논리형으로 리턴
            bool B_Result = true;
            B_Result = false;

            B_Result = Left > Right;
            B_Result = Left < Right;
            B_Result = Left <= Right;
            B_Result = Left >= Right;
            B_Result = Left == Right;
            B_Result = Left != Right;


            // bool 논리 연산자
            B_Result = !true;
            // AND 연산자, 전부 True
            B_Result = true && false;
            // OR 연산자, 하나라도 true면 true
            B_Result = true || false;
            // XOR 연산자, 서로 다른 경우 true, 같으면 false
            B_Result = true ^ false;
        }
    }
}
