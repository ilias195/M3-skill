using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    public int value = 0;
    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0;
        if (bits[0].state)
        {
            value += 1;
        }
        if (bits[1].state)
        {
            value += 2;
        }
        if (bits[2].state)
        {
            value += 4;
        }
        if (bits[3].state)
        {
            value += 8;

        }
        if (bits[4].state)
        {
            value += 16;
        }
        if (bits[5].state)
        {
            value += 32;
        }
        if (bits[6].state)
        {
            value += 64;
        }
        if (bits[7].state)
        {
            value += 128;
        }

            
    }
    public void SetValue(int MyValue)
    {
        value = MyValue;

        if (MyValue >= 128)
        {
            MyValue -= 128;
            bits[7].state = true;

        }
        else
        {
            bits[7].state = false;
        }
        if (MyValue >= 64)
        {
            MyValue -= 64;
            bits[6].state = true;

        }
        else
        {
            bits[6].state = false;
        }

        if (MyValue >= 32)
        {
            MyValue -= 32;
            bits[5].state = true;

        }
        else
        {
            bits[5].state = false;
        }
        if (MyValue >= 16)
        {
            MyValue -=16;
            bits[4].state = true;

        }
        else
        {
            bits[4].state = false;
        }

        if (MyValue >= 8)
        {
            MyValue -= 8;
            bits[3].state = true;

        }
        else
        {
            bits[2].state = false ;
        }

        if(MyValue >= 4)
        {
            MyValue -= 4;
            bits[1].state = true;
        }
        
          if(MyValue >= 2)
        {
            MyValue -= 2;
            bits[0].state = true;

        }
        else
        {
            bits[0].state = false ;
        }

    }
    public string getHex()
    {
        return value.ToString("X2");
    }


}

