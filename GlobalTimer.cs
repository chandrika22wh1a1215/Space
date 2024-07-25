using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public bool isTakingTime = false;
    public int theSeconds = 150;

    void Update()
    {
        if (!isTakingTime)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;

        // Add a null check before accessing Text component
        if (timeDisplay01 != null)
        {
            Text textComponent = timeDisplay01.GetComponent<Text>();
            if (textComponent != null)
            {
                textComponent.text = theSeconds.ToString();
            }
            else
            {
                Debug.LogError("Text component not found on timeDisplay01 GameObject.");
            }
        }
        else
        {
            Debug.LogError("timeDisplay01 GameObject is not assigned.");
        }

        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
