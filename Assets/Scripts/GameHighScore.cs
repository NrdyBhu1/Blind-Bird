using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHighScore : MonoBehaviour
{
	#region Variables
    public Text highScore;
	#endregion

    void Start()
    {
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}