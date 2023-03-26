using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Phase { DEPLOY, PLAYERPHASE, ENEMYPHASE, END}

public class GameManager : MonoBehaviour
{
    public Phase phase;
    public Reasorce_Generator generator;
    public Enemy Enemy;
    public Round round;
    public int RoundCounter;
    public int Reasorces;
    public int EnemyCount;

    public bool deployAccess = false;
    public bool movementAccess = false;
    public bool attackAccess = false;

    private void Start()
    {
        round.NextRound();
    }

    void Update()
    {
       if (phase == Phase.DEPLOY) { Deploy(); } 
       if(phase == Phase.PLAYERPHASE) { PlayerPhase(); }
       if(phase == Phase.ENEMYPHASE) { EnemyPhase(); }
       if(phase == Phase.END) { EndPhase(); }
    }

    private void EndPhase()
    {
        if(EnemyCount <= 0)
        {
            round.NextRound();
        }
    }

    private void EnemyPhase()
    {
        movementAccess = false;
        attackAccess = false;
        Enemy.EnemyAI();
    }

    private void PlayerPhase()
    {
        deployAccess = false;
        movementAccess = true;
        attackAccess = true;
    }

    private void Deploy()
    {
        generator.Generate();
        Debug.Log(RoundCounter);
        Debug.Log(Reasorces);
        deployAccess = true;

    }
}
