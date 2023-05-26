using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabChecker : MonoBehaviour
{
    public bool isStopped;
    public Enemy enemy;
    public GameObject col;
    public bool validTarget;
    private Collider target;
    private void Update()
    {
        if (validTarget == true && enemy.canDamage == true) 
        {
            Debug.Log("Kill");
            target.gameObject.GetComponent<NewDrag>().DestroyThis();
            validTarget = false;
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Unit")
        {
            target = collision;
            isStopped = true;
            validTarget = true;
        }
    }
    private void OnTriggerStay(Collider collision)
    {
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Unit") 
        { 
            isStopped = false;
            validTarget = false;
        }
    }
}


