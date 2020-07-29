using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMaster : MonoBehaviour
{
    private int currentScore;
    private int highScore;
    private bool gameIsPaused = false;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public GameObject gameGUI;
    public GameObject pauseMenu;

    private void Start()
    {
        Time.timeScale = 1f;
        currentScore = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
        UpdateCurrentScoreText();
        UpdateHighScoreText();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameIsPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void UpdateCurrentScoreText()
    {
        scoreText.text = currentScore.ToString();
    }

    public void UpdateHighScoreText()
    {
        highScoreText.text = highScore.ToString();
    }

    public void AddScore()
    {
        currentScore += 5;
        UpdateCurrentScoreText();
        int cHighScore = PlayerPrefs.GetInt("HighScore");
        if (currentScore > cHighScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        gameGUI.SetActive(false);
        pauseMenu.SetActive(true);
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        gameGUI.SetActive(true);
        gameIsPaused = false;
    }
}
