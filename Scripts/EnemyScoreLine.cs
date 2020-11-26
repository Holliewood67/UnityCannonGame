using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreLine : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box") && !collision.GetComponent<Box>().hasBeenScored)
        {
            player.AddEnemyScore(3);
            collision.GetComponent<Box>().CountAsScored();
        }
    }
}
