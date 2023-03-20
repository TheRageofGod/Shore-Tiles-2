using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    
    public int Health;
    public int Damage;
    public float movementSpeed = 0.35f;
    private bool isStopped;

    void Update()
    {
        if(!isStopped)
        transform.Translate(new Vector3(movementSpeed * 0, 1, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            isStopped = true;
        }
    }
}
