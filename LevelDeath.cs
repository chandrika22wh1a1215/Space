using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    
    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
    }
    IEnumerator YouFellOff ()
    {
        youFell.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

}
