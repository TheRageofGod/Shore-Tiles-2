using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 offset;
    public bool isDragging;
    //public Camera cam;
    //public GameManager manager;

    
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {


            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {

                isDragging = true;
                offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

        }
        if (isDragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            //transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }
}
