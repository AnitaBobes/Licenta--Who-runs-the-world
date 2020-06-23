using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject gameOver;
    public GameObject levelAudio;
    public GameObject fadeOut;
    public static int err = 0;
    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
        
        //IEnumerator is used because we are dealing with time
    {
        //youFell.SetActive(true);

        // yield return new WaitForSeconds(3);
        //fadeOut.SetActive(true);
        //yield return new WaitForSeconds(1); //explicat la 2:19:00 
        //when our character colides with this object we need to go to RedirectLevel(scene 0)
        //dupa asta zice you fell off
        levelAudio.SetActive(false);
        GlobalScore.currentScore = 0;
        MainMenuFunction.lifes -= 1;

        if (MainMenuFunction.lifes > 0)
        {
            err = 1;
            //GlobalLife.currentLife -= 1;
            youFell.SetActive(true);
            yield return new WaitForSeconds(3);
            fadeOut.SetActive(true);
            // SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);


        }
        else if (MainMenuFunction.lifes == 0)
        {
            //err = 2;
            //GlobalLife.currentLife = 3;
            gameOver.SetActive(true);
            yield return new WaitForSeconds(3);
            fadeOut.SetActive(true);
            SceneManager.LoadScene(1);
        }
        else 
        {
            //err = 3;
            MainMenuFunction.lifes = 0;
        }


    }




}
