using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    public int score = 0;
    public TextMeshProUGUI scoreText; 

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
        score += value;
        scoreText.text = "Score: " + score;
    }
}
