using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierGame : MonoBehaviour
{
    public bool placed = false;
    public GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    public void Update()
    {
        if (placed == true)
        {
            transform.position = gameManager.currentContainer.transform.position;
        }
    }

    //use in trigger enter to determen if an enemy is within the corect range
}
