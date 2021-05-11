using System;
using System.Collections.Generic;
using System.Linq;

class Zone
{
    public string Name = "None";

    public List<Zone> LinkZone = new List<Zone>();

    public Zone Update()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("이곳은 " + Name + "입니다.");

            Console.WriteLine("이동 가능한 장소");

            for (int i = 0; i < LinkZone.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + LinkZone[i].Name);
            }

            //ConsoleKey.D1
            // 형변환, 가능한, 가능하지않은 녀석들이 있다.
            // enum은 int 변환이 된다.
            int Number = (int)Console.ReadKey(true).Key;
            Number -= 49;

            return (Number > (LinkZone.Count - 1) ? this : LinkZone[Number]);
        }
    }

    public Zone(string _Name)
    {
        Name = _Name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zone NewZone0 = new Zone("태초마을");
        Zone NewZone1 = new Zone("초보사냥터");
        Zone NewZone2 = new Zone("중급사냥터");
        Zone NewZone3 = new Zone("중급마을");
        Zone NewZone4 = new Zone("고급사냥터");

        NewZone0.LinkZone.Add(NewZone1);
        NewZone0.LinkZone.Add(NewZone2);

        NewZone1.LinkZone.Add(NewZone0);
        NewZone1.LinkZone.Add(NewZone3);

        NewZone2.LinkZone.Add(NewZone0);
        NewZone2.LinkZone.Add(NewZone3);

        NewZone3.LinkZone.Add(NewZone1);
        NewZone3.LinkZone.Add(NewZone2);
        NewZone3.LinkZone.Add(NewZone4);

        NewZone4.LinkZone.Add(NewZone3);

        Zone StartZone = NewZone0;

        while (true)
        {
            StartZone = StartZone.Update();
        }
    }
}