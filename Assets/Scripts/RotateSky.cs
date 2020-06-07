using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float rotateSpeed = 1.2f;

    void Update()
    {
        //to rotate the skuBox access the render settings for the skyBox and set rotateSpeed onto it.
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
