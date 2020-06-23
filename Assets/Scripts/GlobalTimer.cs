using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public GameObject gameOver;
    public GameObject youFell;
    public GameObject noTime;
    public GameObject fadeOut;
    //we need to know if we are substracting a second from our time
    public bool isTakingTime = false;
    //keep substracting a second every time
    public int theSeconds;
    public static int extendScore;

    void Update()
    {
        extendScore = theSeconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        
        if (MainMenuFunction.lifes < 1)
        {
            SceneManager.LoadScene(1);
        }
        //here we take away from theSeconds
        isTakingTime = true;
        //here we display
        //theSeconds = MainMenuFunction.timer1;
        theSeconds -= 1;
        //MainMenuFunction.timer1 -= 1;

        if (theSeconds > 0)
        {
            timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
            timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
            yield return new WaitForSeconds(1);
            isTakingTime = false;
        }
        else if (theSeconds == 0)
        {
            MainMenuFunction.lifes -= 1;
            if (MainMenuFunction.lifes > 0)
            {

                isTakingTime = true;
                noTime.SetActive(true);
                //MainMenuFunction.timer1 = MainMenuFunction.timer0;
                yield return new WaitForSeconds(3);
                fadeOut.SetActive(true);
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

            }
            else if (MainMenuFunction.lifes == 0)
            {
                isTakingTime = true;
                gameOver.SetActive(true);
                yield return new WaitForSeconds(3);
                fadeOut.SetActive(true);
                SceneManager.LoadScene(1);
            }
            else
            {
                MainMenuFunction.lifes = 0;
            }
            //isTakingTime = false;
            //timeDisplay02.GetComponent<Text>().text = "Game Over";
            //yield return new WaitForSeconds(2);
            //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            // 
        }
        else { theSeconds = 0; }
        //explicat la 1:29:00
    }
}
