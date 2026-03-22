using UnityEngine;
using TMPro;

public class HighScoreManager : MonoBehaviour
{
    public TMP_Text highScoreText;

    int highScore;

    void Start()
    {
        // Load điểm đã lưu
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        UpdateUI();
    }

    public void AddScore(int score)
    {
        if(score > highScore)
        {
            highScore = score;

            // Save
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();

            UpdateUI();
        }
    }

    void UpdateUI()
    {
        highScoreText.text = "High Score: " + highScore;
    }
}