using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Bitmap : MonoBehaviour
{
    public Byte[] bytes = new Byte[8];
    public int[] values = new int[8];   

    void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            bytes[i].SetValue(values[i]);
        }
    }
}