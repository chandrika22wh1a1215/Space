using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("RedirectLevel"); // Replace "VideoScene" with the name of your video scene
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game..."); // This is for testing in the Unity Editor
    }
}

