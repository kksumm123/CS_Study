using System;

class Player
{
    int ATT, HP;

    public void Test(int _Dmg)
    {
        _Dmg = 1000;
    }
    public int Test2(int _Dmg)
    {
        _Dmg = 1000;

        return _Dmg;
    }
}
namespace _11_Memory01_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            int Value = 100;
            NewPlayer.Test(Value);

            Console.WriteLine(Value);

            Value = NewPlayer.Test2(Value);

            Console.WriteLine(Value);
        }
    }
}
