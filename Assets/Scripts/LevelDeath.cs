using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;

    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1); //explicat la 2:19:00 
        //when our character colides with this object we need to go to RedirectLevel(scene 0)
        //dupa asta zice you fell off
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
