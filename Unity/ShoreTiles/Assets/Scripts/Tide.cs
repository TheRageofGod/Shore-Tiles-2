using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tide : MonoBehaviour
{
    public GameManager Gm;
    public GameObject[] points;

    // Update is called once per frame
    void Update()
    {

        {
            transform.position = points[0].transform.position;
        }
        if (Gm.RoundCounter == 2)
        {
            transform.position = points[1].transform.position;
        }
        if (Gm.RoundCounter == 3)
        {
            transform.position = points[2].transform.position;
        }
        if (Gm.RoundCounter == 4)
        {
            transform.position = points[3].transform.position;
        }
        if (Gm.RoundCounter == 5)
        {
            transform.position = points[4].transform.position;
        }
        if (Gm.RoundCounter == 6)
        {
            transform.position = points[5].transform.position;
        }
    }
}
