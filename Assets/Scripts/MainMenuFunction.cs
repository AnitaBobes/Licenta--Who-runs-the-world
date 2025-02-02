﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;
    public static int lifes = 0;
    //public static int timer0 = 0;
    //public static int timer1 = 0;

    void Start()
    {
        Cursor.visible = true;
        //when we finish the level, we are saving that player pref
        //when we are loading the game, we are displaying that player pref
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        lifes = 3;
        //timer0 = 25;
        //timer1 = 25;
        //RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetBest()
    {
        //Here we reset the name for LevelScore back to 0
        PlayerPrefs.SetInt("LevelScore", 0);
    }
}
