﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitdetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HIT");
        EnemyContr enemy = GetComponent<EnemyContr>();
        enemy.die();
        Debug.Log("Hit");

    }
}