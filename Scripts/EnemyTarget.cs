﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, Random.Range(0, 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
