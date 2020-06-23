using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GemLife : MonoBehaviour
{
    //ads score to silver gem
    public GameObject lifeBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        MainMenuFunction.lifes += 1;
        collectSound.Play();
        Destroy(gameObject);
    }

}
