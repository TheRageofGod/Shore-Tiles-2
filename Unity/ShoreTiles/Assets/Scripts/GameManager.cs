using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;
    public SoldierGame Game;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
    public void PlaceObject()
    {
        if(draggingObject != null && currentContainer !=null)
        {
            Instantiate(draggingObject.GetComponent<SoldierDrag>().card.object_Game, currentContainer.transform);
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
           
            //Debug.Log("soldier deployed");
        }
    }
}
