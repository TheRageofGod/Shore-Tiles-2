using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;


public class Enemy : MonoBehaviour
{
    public int damage;
    public int health = 2;
    public CrabChecker check;
    public GameObject checker;
    public GameManager Gm;
    public GameObject crab;
    public bool canDamage = false;
    public Phase phase;
   
    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
        if (phase == Phase.ENEMYPHASE)
        {
            canDamage = true;
        }
        else
        {
            canDamage = false;
        }
    }
    public void EnemyAI()
    {
        if (check.isStopped == false)
        {
            Turn();
            check.isStopped = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Unit")
        {
            Damage();
        }
        
    }
    
    public void Damage()
    {
       
        health = health - 1;
        
        
    }
    
    public void Turn()
    {
        transform.position = checker.transform.position;
    }

    private void Die()
    {
        Gm.EnemyCount = Gm.EnemyCount - 1;
        Destroy(crab);
    }
}
