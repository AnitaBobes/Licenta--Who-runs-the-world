using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper002 : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;
    public GameObject theRedGem;

    void OnTriggerEnter()
    {
        //when we enter this trigger, the player becomes the child and the ledge becomes the parent so we need to make them both parents

        thePlayer.transform.parent = theLedge.transform;
        theRedGem.transform.parent = theLedge.transform;
        //the parent for the player becomes the ledge

    }

    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
        theRedGem.transform.parent = null;
    }
}
