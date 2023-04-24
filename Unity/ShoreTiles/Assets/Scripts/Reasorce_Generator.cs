using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reasorce_Generator : MonoBehaviour
{
    public int Reasorces;
    public int GenCount;
   public void Generate()
    {
        if (GenCount <= 0)
        {
            Reasorces = Reasorces + 1;
            GenCount =  1;
        }
    }
}
