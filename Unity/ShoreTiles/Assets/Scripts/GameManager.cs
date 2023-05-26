using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Text phaseBanner;
    public bool UnitColl;
    public bool isDragging;

    public bool deployAccess = false;
    public bool movementAccess = false;
    public bool attackAccess = false;

    public bool instanced = false;

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
        if (phase == Phase.DEPLOY) { Deploy(); phaseBanner.text = "Deploy"; }
        if (phase == Phase.PLAYERPHASE) { PlayerPhase(); phaseBanner.text = "Attack"; }
        if (phase == Phase.ENEMYPHASE) { EnemyPhase(); phaseBanner.text = "Enemy's Turn"; }
        if (phase == Phase.END) { EndPhase(); phaseBanner.text = "End"; }
        Reasorces = generator.Reasorces;
    }
    public void PhaseChanger()
    {
        if (phase == Phase.DEPLOY) { phase = Phase.PLAYERPHASE;}
        
       else if (phase == Phase.PLAYERPHASE) { phase = Phase.ENEMYPHASE; }
       else if (phase == Phase.ENEMYPHASE) { phase = Phase.END; }
       else if (phase == Phase.END) { EndPhase(); }
    }
    private void EndPhase()
    {
        Enemy.canDamage = false;
        generator.GenCount = 0;
        if (EnemyCount <= 0)
        {
            round.NextRound();
        }
        else
        {
            phase = Phase.DEPLOY;
        }
        
    }

    private void EnemyPhase()
    {
        movementAccess = false;
        attackAccess = false;
        Enemy.canDamage = true;
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
