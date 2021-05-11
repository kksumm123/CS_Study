using System;

enum DMGTYPE
{
    P_DMG,
    M_DMG,
    FIRE_DMG,
    ICE_DMG
}

class Player
{
    // 물방
    int P_Def = 5;
    // 마방
    int M_Def = 5;
    // 화염 저항
    int Fire_Res = 5;

    int HP = 500;

    

    // 함수 오버로딩 - 이름은 같지만 요구인자값, 형이 다른 것
    // 같은 이름의 함수가 2개인데 빨간줄이 안그인다
    // 최종적으로 컴퓨터는 아래의 함수를
    // Damageint로 인식
    public void Damage(int _Damage)
    {
        HP -= _Damage;
    }

    // 요구 파라미터가 같아도 자료형이 다르면 인식
    // Damagefloatint로 인식
    public void Damage(float _Damage, int _Type)
    {

    }

    // Damageintint 로 인식
    public void Damage(int _Dmg, DMGTYPE _Type)
    {
        // 속성별 저항, 방어력의 응용
        switch (_Type)
        {
            case DMGTYPE.P_DMG:
                _Dmg -= P_Def;
                break;
            case DMGTYPE.M_DMG:
                _Dmg -= M_Def;
                break;
            case DMGTYPE.FIRE_DMG:
                _Dmg -= Fire_Res;
                break;
            default:
                break;
        }

        Damage(_Dmg);
    }


    // 스태틱함수도 가능
    static void Func(int _Value)
    {

    }
    static void Func(int _Value, int _Value2)
    {

    }

    // 생성자도 가능
    public Player()
    {

    }
    public Player(int _HP)
    {
        HP = _HP;
    }
}



namespace _29_OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);

            // NewPlayer.Damage();
            // 입력하여 빨간줄에서 화살표로 Damage함수의 종류 확인가능
            NewPlayer.Damage(100, DMGTYPE.FIRE_DMG);
        }
    }
}