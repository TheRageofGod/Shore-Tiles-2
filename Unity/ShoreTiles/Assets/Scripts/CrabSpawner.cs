using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrabSpawner : MonoBehaviour 
{
    public List<GameObject> CrabPreFab;
    public List<Crab> crabs;

    public void Update()
    {
        //Debug.Log(Time.time);
        foreach (Crab crab in crabs)
        {
            if (crab.isSpawned == false && crab.spawnTime <= Time.time)
            {
                Debug.Log("CrabSpawned");
               GameObject crabInstance = Instantiate(CrabPreFab[(int)crab.crabTypes], transform.GetChild(crab.spawner).transform);
                crab.isSpawned = true;
            }
        }
    }
}
