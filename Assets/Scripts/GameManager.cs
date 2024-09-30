using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public bool isGameActive = true; // Tracks if the game is still running

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        if (isGameActive) // Only allow adding score if the game is active
        {
            score += value;
            scoreText.text = "Score: " + score;
        }
    }

    // Call this function to stop the game when time runs out
    public void EndGame()
    {
        isGameActive = false;
    }
}
