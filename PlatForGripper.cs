using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatForGripper : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;

    void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }

    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }
}