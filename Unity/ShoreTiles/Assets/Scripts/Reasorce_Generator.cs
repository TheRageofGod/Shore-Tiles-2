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
            Reasorces = Reasorces + 3;
            GenCount =  1;
        }
    }
}
