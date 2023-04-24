using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPoint : MonoBehaviour
{
    public GameManager Gm;
    public Vector3 point;
    
    private void OnTriggerEnter(Collider other)
    {
      
        if(other.tag == "Unit")
        {
            Debug.Log("Enter");
        }
    }
    private void OnTriggerExit(Collider other)
    {

        Gm.isDragging = false;
        Debug.Log("Exit");
    }
}
