using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    

    public Text timerText;

    private float timer;
    public int score;
    public int health = 5;
    public int scoreText;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName == "level 1")
        {
            timer = 0f;
            Debug.Log("reset");
        }
        else
        {
            timer = PlayerPrefs.GetFloat("time");
            Debug.Log("load");
        }
        
    }

    void Update()
    {
        timer += Time.deltaTime;
                
        timerText.text = scoreText + "s";

        if (Time.timeScale != 1f)
        {
            timer = timer;
        }
        else
        {
            timer += Time.deltaTime;
        }

        losehealth();

        scoreText = (int)timer;
        score = 9999 - (int)timer;

        PlayerPrefs.SetFloat("time", timer);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
                        
    }

    [SerializeField] private string GaOv;
    void losehealth()
    {
        
        if (score == 180)
        {
            health = health - 1;
        }
        if(score  == 360)
        {
            health = health - 1;
        }
        if(score == 540)
        {
            health = health - 1;
        }
        if(score == 720)
        {
            health = health - 1;
        }
        if (score == 900)
        {
            health = health - 1;
        }
        if (health == 0)
        {
            SceneManager.LoadScene(GaOv);
        }
    }

        
}