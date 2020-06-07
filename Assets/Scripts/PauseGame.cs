using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    // Check if the game is paused and then pause the player

    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;

    void Update()
    {
        //here we check if we are pressing the cancel button, which is the escape button
        if (Input.GetButtonDown("Cancel"))
        {
            //we need to chck if gamePaused is equal to false
            if(gamePaused == false)
            {
                //unity is always running on timeScale=1 , that is real time. If we set it to 0, it will freeze. s is doulble fast and so on
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
            }

            else
            {
                pauseMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }
}
