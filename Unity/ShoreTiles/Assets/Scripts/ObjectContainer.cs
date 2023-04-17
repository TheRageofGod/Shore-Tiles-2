using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectContainer : MonoBehaviour
{
    public bool isFull;
    public GameManager gameManager;
    public Image backgroundImage;

    private void Start()
    {
        gameManager = GameManager.instance;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       
        
    }
   
}
