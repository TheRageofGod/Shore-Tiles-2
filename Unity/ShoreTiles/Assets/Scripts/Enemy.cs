using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public int health;

    public void EnemyAI()
    {

    }
   public void Damage()
    {
        if ( health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(this);
    }
}
