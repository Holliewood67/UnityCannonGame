using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyMissile enemyMissile;
    public EnemyTarget enemyTarget;
    public ScoreUI scoreUI;
    public int enemyScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Fire ()
    {
        EnemyMissile enemyMissileInstance = Instantiate(enemyMissile);
        enemyMissileInstance.Launch(enemyTarget);
    }

}
