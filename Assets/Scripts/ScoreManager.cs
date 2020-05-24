using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	#region Variables
    public Text score;
    bool setting = true;
	#endregion
    void Start(){
        if (setting == true){
            PlayerPrefs.SetInt("HighScore", 0);
            setting = false;
        }
    }
    void FixedUpdate()
    {
        SetHighScore(Int32.Parse(score.text));
    }

    void SetHighScore(int number){
        if (number > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", number);
        }
    }
}
