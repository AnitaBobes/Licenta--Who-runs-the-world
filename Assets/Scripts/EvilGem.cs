using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvilGem : MonoBehaviour
{
    public GameObject scoreBox;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore -= 100;
        Destroy(gameObject);
    }
}
