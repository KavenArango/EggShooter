﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class completeLevel : MonoBehaviour
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
        SceneManager.LoadScene("Main Menu");
    }


    public void SceneLoader(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
