using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Phase { DEPLOY, PLAYERPHASE, ENEMYPHASE, END }
public class GameManager : MonoBehaviour
{
 
    public static GameManager instance;

    public Phase phase;
    public Reasorce_Generator generator;
    public Enemy Enemy;
    public Round round;
    public int RoundCounter;
    public int Reasorces;
    public int EnemyCount;

    public bool isDragging;

    public bool deployAccess = false;
    public bool movementAccess = false;
    public bool attackAccess = false;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        round.NextRound();
        
    }

    void Update()
    {
        if (phase == Phase.DEPLOY) { Deploy(); }
        if (phase == Phase.PLAYERPHASE) { PlayerPhase(); }
        if (phase == Phase.ENEMYPHASE) { EnemyPhase(); }
        if (phase == Phase.END) { EndPhase(); }
        Reasorces = generator.Reasorces;
    }

    private void EndPhase()
    {
        if (EnemyCount <= 0)
        {
            round.NextRound();
        }
        else
        {
            phase = Phase.DEPLOY;
        }
        generator.GenCount = 0;
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
        deployAccess = true;
        movementAccess = true;

    }
    
   
}
