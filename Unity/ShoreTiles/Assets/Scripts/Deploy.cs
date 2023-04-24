using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deploy : MonoBehaviour
{
   public Transform Parent;
    public GameObject objectToSpawn;
    public Button spawnButton;
    private GameObject spawnedObject;
    
    

    public GameManager Gm;
    public Reasorce_Generator RG;
   

    void Update()
    {
        if (Gm.deployAccess == false)
        {
            spawnButton.interactable = false; spawnButton.enabled = false;
        }
        else if (Gm.deployAccess == true && RG.Reasorces >= 3)
        {
            spawnButton.interactable = true; spawnButton.enabled = true;
        }
       

    }
    public void SpawnObject()
    {
        // Instantiate the objectToSpawn and set it as the spawnedObject
        spawnedObject = Instantiate(objectToSpawn);
        spawnedObject.transform.SetParent(Parent);
        
    }
   
}
