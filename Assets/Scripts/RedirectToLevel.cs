using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    //We need  RedirectToLevel because once we leave level001 Scene, everything will be set back to normal. So if we fail, everything will reset.

    //variable that determines what level I want to go to
    public static int redirectToLevel;
    public static int nextLevel;
   
    
    void Update()
    {
        if (redirectToLevel == 3)
        {
            SceneManager.LoadScene(redirectToLevel);
        }
    }
}
