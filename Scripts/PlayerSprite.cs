using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    public Animator animator;
    public Player player;

    public void IsFiring ()
    {
        player.gameObject.GetComponent<Player>().Fire();
    }
}
