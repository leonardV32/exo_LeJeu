using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    private int MyInt, MySecondInt;
    public int result;
    // Start is called before the first frame update

    public void GetSum()
    {
        result = MyInt + MySecondInt;
    }


    public Test(int Int, int Sec)
    {
        MyInt = Int;
        MySecondInt = Sec;
    }
}
