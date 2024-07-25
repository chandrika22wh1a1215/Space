using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectToLevel = 2;


    void Update()
    {
        if(redirectToLevel == 2)
        {
            SceneManager.LoadScene(redirectToLevel);
        }
    }
}
