﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    //we need the player to be a part of this specific object, so hw will move along with the platform
    //we need to have the object and the player as objects

    public GameObject theLedge;
    public GameObject thePlayer;

    void OnTriggerEnter()
    {
        //when we enter this trigger, the player becomes the child and the ledge becomes the parent so we need to make them both parents

        thePlayer.transform.parent = theLedge.transform;
        //the parent for the player becomes the ledge

    }

    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }

}
