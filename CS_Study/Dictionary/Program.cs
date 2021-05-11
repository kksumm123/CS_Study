using System;
using System.Collections.Generic;

// 딕셔너리를 그냥 사용하는 것보다
// 클래스로 감싸는게 좋다
// 왜냐? containskey로 키유무를 확인해야하니까
// 추가, 삭제, 출력 등 작업에 키 유무가 필수적

class DicTest
{
    Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Print(string _Name)
    {
        if (false == NewDic.ContainsKey(_Name))
            return;

        Console.WriteLine(NewDic[_Name]);
    }
    public void Add(string _Name, int Value)
    {
        if (NewDic.ContainsKey(_Name))
            return;

        NewDic.Add(_Name, Value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 연관 배열
        // string - 키
        // int - 벨류
        Dictionary<string, int> NewDic = new Dictionary<string,int>();

        NewDic.Add("1 입니다", 1);
        NewDic.Add("2 입니다", 2);
        // 중복된 키 사용 불가
        // 같은 키를 넣어줄 일이 있으면
        // 딕셔너리 사용 X
        if (false == NewDic.ContainsKey("뭘까요"))
            NewDic.Add("뭘까요", 3421421);

        // 인덱서
        // 연산자 겹지정
        // 딕셔너리는 찾는다 라는 작업에 특화된 녀석
        // 키가 없으면 KeyNotFoundException 에러
        // ContainsKey 메소드로 유무확인가능
        string Key = "당연히 없는 값";

        if (NewDic.ContainsKey(Key))
            Console.WriteLine(NewDic[Key]);

        Key = "뭘까요";
        if (NewDic.ContainsKey(Key))
            Console.WriteLine(NewDic[Key]);
        NewDic.Remove("뭘까요");
        if (NewDic.ContainsKey(Key))
            Console.WriteLine(NewDic[Key]);

        DicTest NewTest = new DicTest();
        NewTest.Add("중복키", 1);
        NewTest.Add("중복키", 2);
        NewTest.Add("중복키", 3);
        NewTest.Add("중복키", 4);
        NewTest.Print("중복키");

    }
}