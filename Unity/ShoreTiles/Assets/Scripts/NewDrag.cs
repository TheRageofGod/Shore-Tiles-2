using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDrag : MonoBehaviour
{
    public RaycastHit hitpoint;
    public void Update()
    {
       // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
       // transform.position = hitpoint.point;
        
    }
    private void OnMouseDrag()
    {
        Debug.Log("Fireing");
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = Camera.main.nearClipPlane;
        return mousePos;
    }
}
