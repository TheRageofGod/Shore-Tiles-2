using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Crab 
{
    public int spawnTime;
    public int spawner;
    public bool RandomSpawn;
    public bool isSpawned;
    public CrabTypes crabTypes;

}
public enum CrabTypes
{
    BASIC
}
