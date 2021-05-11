using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    string mName;
    int mGold;

    // 프로퍼티를 무작정 만들 필요는 없다
    // 필요할 때 만들면 된다.
    public string Name
    {
        get
        {
            return mName;
        }
        set
        {
            mName = value;
        }
    }

    public int Gold
    {
        get
        {
            return mGold;
        }
        set
        {
            mGold = value;
        }
    }

    public Item(string _Name, int _Gold)
    {
        mName = _Name;
        mGold = _Gold;
    }
}