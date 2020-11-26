using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    public Rigidbody2D rig;

    public void Launch(EnemyTarget enemyTarget)
    {
        rig.AddForce((enemyTarget.transform.position - transform.position) * Random.Range(2.0f, 2.3f), ForceMode2D.Impulse);
    }
}
