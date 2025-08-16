using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText; //I'm referencing the UI Text for displaying the high score
    private float highScore = 0;

    private ScoreManager scoreManager; //I'm referencing the ScoreManager script

    private void Start()
    {
        //I'm initializing the high score as "00000"
        highScore = PlayerPrefs.GetFloat("HighScore", 0); //I'm loading the high score from PlayerPrefs
        UpdateHighScoreText();

        //I'm finding and referencing the ScoreManager script in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager script not found in the scene.");
        }

        //I'm setting the initial Y position to -20.5 units
        //RectTransform rectTransform = highScoreText.rectTransform;
        //rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, 1f);
    }

    public void UpdateHighScore(float currentScore)
    {
        //I'm updating the high score if the current score is higher
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetFloat("HighScore", highScore); //I'm saving the new high score to PlayerPrefs
            UpdateHighScoreText();
        }
    }

    //I'm updating the high score text
    private void UpdateHighScoreText()
    {
        string highScoreString = Mathf.RoundToInt(highScore).ToString("D5");
        highScoreText.text = highScoreString;
    }
}
