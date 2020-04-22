using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ScoreManagerEnemy : MonoBehaviour
{
    public Text Level1Score;

    public Text Level2Score;

    void Start()
    {
        Level1Score.text = "Highscore: ";
        Level2Score.text = "Highscore: ";

        //PlayerPrefs.SetInt("Level1HighScore", 0);
        //PlayerPrefs.SetInt("Level2HighScore", 0);

        Level1Score.text += PlayerPrefs.GetInt("Level1HighScore").ToString();
        Level2Score.text += PlayerPrefs.GetInt("Level2HighScore").ToString();
    }
}
