using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    public GameManager Gm;
    public Enemy Enemy;
    void Update()
    {
        if(Gm.attackAccess == true)
        {
            AttackFunction();
        }
    }

    private void AttackFunction()
    {
        Enemy.Damage();
    }

    
}
