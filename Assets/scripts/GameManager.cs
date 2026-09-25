using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverUi;
    private bool isGameOver = false;

    void Start()
    {
        // Make sure game over UI is hidden at start
        if (gameOverUi != null)
        {
            gameOverUi.SetActive(false);
        }
        UpdateScore();
    }

    void Update()
    {
    }

    public void AddScore(int points)
    {
        if (!isGameOver)
        {
            score += points;
            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        if (gameOverUi != null)
        {
            gameOverUi.SetActive(true);
        }
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        isGameOver = false;
        Time.timeScale = 1f;
        score = 0;
        
        // Hide game over UI
        if (gameOverUi != null)
        {
            gameOverUi.SetActive(false);
        }
        
        UpdateScore();
        SceneManager.LoadScene("Game");
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}