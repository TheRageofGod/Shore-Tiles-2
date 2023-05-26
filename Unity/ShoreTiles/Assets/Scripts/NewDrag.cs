using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewDrag : MonoBehaviour
{
  
    public GameManager Gm;
    public SquareSelect Ss;
    public Vector3 SavePoint;
    public int count;

    public int movementValue = 2;
    public int moves = 0;
    public bool movement = true;

    public Vector3 releasePoint;
    public Vector3 nullPoint;
    public bool placed = false;
    public GameObject[] detectPoints;
    public bool instance = false;
    
    public void Start()
    {
        Gm = FindObjectOfType<GameManager>();
        Ss = FindObjectOfType<SquareSelect>();
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
                    nullPoint = transform.position;

                }
                if (Gm.isDragging == true && movement == true)
                {
                    hit.transform.position = GetMousePos();
                    Ss.spaceChecker.transform.position = transform.position;

                }

            }


        }
        else if(Input.GetMouseButtonUp(0))
        {
            if (Gm.isDragging == false)
            {
                
                transform.position = releasePoint;
                placed = true;
                Gm.instanced = false;
                Ss.spaceChecker.transform.position = transform.position;
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
            if (other.GetComponent<BoardPoint>().validPoint == false)
            {
                releasePoint = nullPoint;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().Damage();
                Debug.Log("Damage");

            releasePoint = nullPoint;
        }
    }
    private void OnMouseUp()
    {
        Gm.isDragging = false;
      

    }
    private void OnMouseDrag()
    {
        transform.position = GetMousePos();
        
        Gm.isDragging = true;

    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = Camera.main.nearClipPlane;
        return mousePos;
    }

    public void DestroyThis()
    {
        Destroy(gameObject);
    }
}
