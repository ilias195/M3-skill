using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Bitmap : MonoBehaviour
{
    public Byte[] bites = new Byte[8];

    public void SetValues(int[] values)
    {
        for (int i = 0; i < bites.Length && i < values.Length; i++)
        {
            bites[i].SetValue(values[i]);
        }
    }
}