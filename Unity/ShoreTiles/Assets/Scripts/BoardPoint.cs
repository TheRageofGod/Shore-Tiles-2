using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPoint : MonoBehaviour
{
    public GameManager Gm;
    
    public Vector3 point;
    public bool validPoint = false;
    public bool touching;

    private void Update()
    {
        //if (Gm.instanced == false)
        //{
        //    validPoint = false;
        //}
        if(Gm.instanced == true)
        {
            validPoint = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(WaitToCheckSpaces());
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        
    }
    private void OnTriggerExit(Collider other)
    {
       
        Gm.isDragging = false;
        validPoint = false;

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Unit")
        {
            touching = true;
        }
        else
        {
            touching = false;   
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("Detect Point") && touching == false)
        {
            validPoint = true;
        }

    }

    IEnumerator WaitToCheckSpaces()
    {

        yield return new WaitForSeconds(0.1f);
        if(Gm.instanced == false)
        validPoint = false;
    }
}
