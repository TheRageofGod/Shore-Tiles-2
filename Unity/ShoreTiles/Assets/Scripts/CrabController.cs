using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrabController : MonoBehaviour
{
    
    public int Health;
    public int Damage;
    public float movementSpeed = 0.35f;
    private bool isStopped;
    public GameObject checker;

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
      isStopped = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isStopped = false;
    }
    public void Turn()
    {
        transform.position = checker.transform.position;
    }
}
