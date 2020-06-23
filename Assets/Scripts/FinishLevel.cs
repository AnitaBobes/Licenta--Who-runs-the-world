using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelBlocker;
    public GameObject fadeOut;
    public GameObject gameOver;
    public int bestScore;


    void OnTriggerEnter()
    {
        //this first line will stop triggering the end sequence over and over again
        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        //detach blocker and put it as a main object in the hierarchy => unitychan is no longer tight to that object

        levelBlocker.transform.parent = null;
        timeCalc = GlobalTimer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        //reset the score to 0 before we go to next level
        GlobalScore.currentScore = 0;
        Debug.Log(RedirectToLevel.nextLevel);
        // Final level, show victory or loss message
        if (RedirectToLevel.nextLevel == 6)
        {
            bestScore = PlayerPrefs.GetInt("LevelScore");
            if (totalScored > bestScore)
            {
                timeLeft.GetComponent<Text>().text = "Congratulations,";
                theScore.GetComponent<Text>().text = "you won!";
            }
            else
            {
                gameOver.SetActive(true);
                // timeLeft.GetComponent<Text>().text = "Sorry, you lost";
                //theScore.GetComponent<Text>().text = "try again!";
            }
        }
        else
        {
            // Go to next level
            SceneManager.LoadScene(RedirectToLevel.nextLevel);
        }


    }
}
