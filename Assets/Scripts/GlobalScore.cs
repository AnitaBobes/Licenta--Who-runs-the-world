using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreBox;
    //currentScoreScore is TransportHeaders master score -will be updated
    public static int currentScore;
    //internalScore is just for viewing purposes

    public int internalScore;

    void Update()
    {
        //here we need to make currentScore and internalScore equal to the same
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;



    }
}
