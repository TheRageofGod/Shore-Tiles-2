using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    int round = 1;
    public Phase phase;
    public GameManager Gm;
    public void NextRound()
    {
        round = round + 1;
        phase = Phase.DEPLOY;
        Gm.RoundCounter = round;
    }
}
