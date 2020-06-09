﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI; ia tot ce trebuie din canvas

public class GemPink : MonoBehaviour
{
    //ads score to silver gem
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 400;
        collectSound.Play();
        Destroy(gameObject);
    }

}
