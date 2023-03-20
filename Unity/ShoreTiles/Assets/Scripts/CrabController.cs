using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    
    public int Health;
    public int Damage;
    public float movementSpeed = 0.35f;
    void Update()
    {
        transform.Translate(new Vector3(movementSpeed * 0, 1, 0));
    }
}
