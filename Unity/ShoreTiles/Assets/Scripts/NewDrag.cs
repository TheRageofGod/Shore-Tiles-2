using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDrag : MonoBehaviour
{
  
    public GameManager Gm;
    public Vector3 SavePoint;
    public int count;

    public int movementValue = 2;
    public int moves = 0;
    public bool movement = true;

    public Vector3 releasePoint;
    public bool placed = false;
    public GameObject[] detectPoints;
    
    public void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
    }
    public void Update()
    {
        if(moves >= movementValue)
        {
            movement = false;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.gameObject.tag == "Unit" && Gm.deployAccess == true)
                {
                    Debug.Log("Hit");
                    Gm.isDragging = true;
                    
                }
                if (Gm.isDragging == true && movement == true)
                {
                    hit.transform.position = GetMousePos();

                }

            }


        }
        else if(Input.GetMouseButtonUp(0))
        {
            if (Gm.isDragging == false)
            {
                transform.position = releasePoint;
                placed = true;/*Gm.snapPoint[Gm.snapPoint.Count - 1];*/
            }
            
        }
       
    }

    public void FixedUpdate()
    {
        foreach (GameObject detectPoint in detectPoints)
        {
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Grid")
        {
            if(other.GetComponent<BoardPoint>().validPoint)
            {
                releasePoint = other.transform.position;
            }

        }

    }
    private void OnMouseUp()
    {
        Gm.isDragging = false;

    }
    private void OnMouseDrag()
    {

        transform.position = GetMousePos();
        //Gm.snapPoint = GetMousePos();
        Gm.isDragging = true;

    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = Camera.main.nearClipPlane;
        return mousePos;
    }
}
