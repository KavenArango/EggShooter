using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class completeLevel : MonoBehaviour
{

    public Text score;

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
        int Score = Convert.ToInt32(score.text);


        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            if (PlayerPrefs.GetInt("Level1HighScore") < Score)
            {
                PlayerPrefs.SetInt("Level1HighScore", Score);
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "Level 2")
            {
                if (PlayerPrefs.GetInt("Level2HighScore") < Score)
                {
                    PlayerPrefs.SetInt("Level2HighScore", Score);
                }
            }
        }



        SceneManager.LoadScene("Main Menu");
    }


    public void SceneLoader(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
