using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter(Collision collision)
    {
        string x = Score.text;

        Score.text = Convert.ToString(Convert.ToInt32(x) + 100);
    }




}
