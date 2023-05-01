using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPoint : MonoBehaviour
{
    public GameManager Gm;
    public Vector3 point;
    public bool validPoint = false;

    
    private void OnTriggerEnter(Collider other)
    {

        
    }
    private void OnTriggerExit(Collider other)
    {
       
        Gm.isDragging = false;

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Unit")
        {
            validPoint = true;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("DetectPoint"))
        {
            validPoint = true;
        }
    }
}
