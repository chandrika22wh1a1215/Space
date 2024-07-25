using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarCollect : MonoBehaviour
{
    public GameObject scoreTextObject; // Assign the UI Text GameObject in the Inspector
    public AudioSource popSound; // Assign the pop sound AudioSource in the Inspector
    private int score = 0; // Initialize score

    void Start()
    {
        UpdateScoreUI(); // Initialize score display
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with: " + other.gameObject.name); // Log to check if the method is called

        if (other.CompareTag("Player")) // Assuming the player has the tag "Player"
        {
            CollectStar();
        }
    }

    void CollectStar()
    {
        Debug.Log("CollectStar called"); // Log to confirm method is called

        if (popSound != null)
        {
            popSound.Play();
            Debug.Log("Pop sound played"); // Log to confirm sound played
        }
        else
        {
            Debug.LogError("Pop sound not assigned.");
        }

        score += 100; // Increase score by 100 or any value you prefer
        UpdateScoreUI();

        Destroy(gameObject); // Destroy the star

        EndLevel();
    }

    void UpdateScoreUI()
    {
        if (scoreTextObject != null)
        {
            Text scoreText = scoreTextObject.GetComponent<Text>();
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score;
                Debug.Log("Score updated: " + score); // Log to confirm score update
            }
            else
            {
                Debug.LogError("Text component not found on scoreTextObject.");
            }
        }
        else
        {
            Debug.LogError("ScoreTextObject is not assigned.");
        }
    }

    void EndLevel()
    {
        Debug.Log("EndLevel called"); // Log to confirm method is called
        // Implement your level ending logic here
        // For example, load the next level
        SceneManager.LoadScene("NextLevelScene"); // Replace with your next level scene name
    }
}

