using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Slider playerHealthSlider;
    public TextMeshProUGUI healthPercentText;
    public TextMeshProUGUI scoreText; // UI Text to display the score
    public int health;
    public int score = 0; // Initial score
    public int totalDiamonds; // Total diamonds in the level
    private int collectedDiamonds = 0; // Count of collected diamonds

    private void Awake()
    {
        // Ensure there's only one instance of the GameManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Initialize the UI
        UpdatePlayerHealthUI(health);
        UpdateScoreUI();
    }

    // Update the player's health UI
    public void UpdatePlayerHealthUI(float damageValue)
    {
        playerHealthSlider.value = damageValue;
        healthPercentText.text = damageValue.ToString();
    }

    // Overloaded method to update the player's health UI using an int value
    public void UpdatePlayerHealthUI(int healthAmount)
    {
        playerHealthSlider.value = healthAmount;
        healthPercentText.text = healthAmount.ToString();
    }

    // Method to update the score UI
    public void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    // Method to handle diamond collection
    public void CollectDiamond(int diamondValue)
    {
        score += diamondValue;
        collectedDiamonds++;
        UpdateScoreUI();
        CheckForLevelCompletion();
    }

    // Check if all diamonds have been collected to end the level
    private void CheckForLevelCompletion()
    {
        if (collectedDiamonds >= totalDiamonds)
        {
            EndLevel();
        }
    }

    // Method to end the level
    private void EndLevel()
    {
        // Implement your level ending logic here, e.g., load the next level
        SceneManager.LoadScene("level002"); // Replace with your next level scene name
    }

    // Method to end the game (not used in the current context but can be expanded)
    
}
