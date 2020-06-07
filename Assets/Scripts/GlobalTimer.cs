using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    //we need to know if we are substracting a second from our time
    public bool isTakingTime = false;
    //keep substracting a second every time
    public int theSeconds = 150;
    public static int extendScore;

    void Update()
    {
        extendScore = theSeconds;
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        //here we take away from theSeconds
        isTakingTime = true;
        //here we display
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
        //explicat la 1:29:00
    }
}
