using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalLife : MonoBehaviour
{
    public GameObject lifeBox;

    //currentScoreScore is TransportHeaders master score -will be updated
    public static int currentLife = 3;
    //internalScore is just for viewing purposes

    public int internalLife;

    void Update()
    {
        //here we need to make currentScore and internalScore equal to the same

        //currentLife = internalLife;
        //currentLife -= 1;
        lifeBox.GetComponent<Text>().text = "Life: " + MainMenuFunction.lifes;   
    }
}