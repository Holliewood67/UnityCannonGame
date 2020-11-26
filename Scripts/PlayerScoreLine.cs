using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreLine : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box") && !collision.GetComponent<Box>().hasBeenScored)
        {
            player.AddScore(3);
            collision.GetComponent<Box>().CountAsScored();
        }
    }
}
