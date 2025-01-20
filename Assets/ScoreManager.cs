using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Reference to the UI Text to display the score
    private int score = 0;

    // Call this method to increase the score
    public void IncreaseScore()
    {
        score++;
        UpdateScoreDisplay();
    }

    // Update the UI Text with the current score
    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
