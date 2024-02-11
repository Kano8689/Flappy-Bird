using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Looser : MonoBehaviour
{
    public Text ScoreBox, HighScoreBox;
    public AudioSource background;
    public AnimationClip[] Bird;
    public Animator flying;
    int Score = 0;
    int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        background.Play();

        Score = PlayerPrefs.GetInt("Point", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        if(highScore<=Score)
        {
            PlayerPrefs.SetInt("HighScore", Score);
            highScore = Score;
        }
        //highScore = PlayerPrefs.GetInt("HighScore", 0);

        ScoreBox.text = "" + Score;
        HighScoreBox.text = ""+ highScore;

        flying.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClockRestart()
    {
        SceneManager.LoadScene("Play");
    }

    public void onClickHome()
    {
        SceneManager.LoadScene("Home");
    }

    
}
