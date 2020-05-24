using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    #region variables
    public Animator anim;
    public Text scoreLabel = null;
    public GameObject pauseCanvas = null;
    public GameObject otherCanvas = null;
    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public bool revive = false;
    #endregion

    #region Functions
    void Awake(){
        if (pauseCanvas != null && otherCanvas != null){
            pauseCanvas.SetActive(false);
            otherCanvas.SetActive(true);
        }
    }
    public void LoadGame () {
        StartCoroutine (LoadLevelOrScene ("MainEasy"));
    }
    public void GameOver () {
        SceneManager.LoadScene ("GameOverScene");
    }
    public void LoadMenu () {
        StartCoroutine (LoadLevelOrScene ("MainMenu"));
    }
    public void LoadIns () {
        StartCoroutine (LoadLevelOrScene ("InstructionsScene"));
    }
    public void Pause () {
        otherCanvas.SetActive(false);
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume(){
        if (pauseCanvas != null && otherCanvas != null){
            otherCanvas.SetActive(true);
            pauseCanvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Quit () {
        Application.Quit ();
    }
    public void AddScore () {
        score++;
        scoreLabel.text = score.ToString ();
    }
    private IEnumerator LoadLevelOrScene (string levelname) {
        Resume();
        anim.SetTrigger ("EndScene");
        yield return new WaitForSeconds (2f);
        SceneManager.LoadScene (levelname);
    }
    #endregion
}