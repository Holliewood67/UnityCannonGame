using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySprite : MonoBehaviour
{
    public Enemy enemy;

    void Fire ()
    {
        enemy.gameObject.GetComponent<Enemy>().Fire();
    }
}
