using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissile : MonoBehaviour
{
    public Rigidbody2D rig;

    public void Launch (PlayerTarget playerTarget)
    {
        rig.AddForce((playerTarget.transform.position - transform.position) * Random.Range(2.0f, 2.3f), ForceMode2D.Impulse);
    }
}
