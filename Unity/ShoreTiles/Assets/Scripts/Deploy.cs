using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy : MonoBehaviour
{
    public GameManager Gm;
    void Update()
    {
        if(Gm.deployAccess == true) { Deployment(); }
    }

    private void Deployment()
    {
        throw new NotImplementedException();
    }
}
