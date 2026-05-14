using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score = 0;
    private float scoreIncreaseRate = 0.25f;
    private float scoreIncreaseAcceleration = 0.25f;
    private bool isScoreIncreased = false;
    private float scoreIncreaseDuration = 0.4f; //I'm setting a duration for the increased score display
    private float scoreIncreaseTimer = 0f;
    private bool isScoreVisible = true;

   void Start()
    {
        //I'm initializing the score as "00000"
        UpdateScoreText(0);
    }

    void Update()
    {
        if (!GlobalSubstance.obstacleTriggered)
        {
            //I'm increasing the score continuously based on the time passed
            score += Time.deltaTime * scoreIncreaseRate;

            //I'm increasing the rate at which the score increases over time
            scoreIncreaseRate += scoreIncreaseAcceleration * Time.deltaTime;


            //I'm adding the condition that if the score is increased, temporarily toggle visibility
            if (isScoreIncreased)
            {
                scoreIncreaseTimer += Time.deltaTime;

                //I'm toggling the score text visibility every half of scoreIncreaseDuration
                if (scoreIncreaseTimer < scoreIncreaseDuration)
                {
                    if (isScoreVisible)
                    {
                        scoreText.enabled = false;
                        isScoreVisible = false;
                    }
                }
                else
                {
                    scoreText.enabled = true;
                    isScoreIncreased = false;
                }
            }

            //I'm resetting the score if it exceeds 99999
            if (score > 99999)
            {
                score = 0;
            }

            //I'm updating the score text display
            UpdateScoreText(score);
        }
    }


    //I'm updating the score text with leading zeros 
    private void UpdateScoreText(float currentScore)
    {
        string scoreString = Mathf.RoundToInt(currentScore).ToString("D5"); //I'm displaying the score with leading zeros

        scoreText.text = Mathf.RoundToInt(currentScore).ToString("D5"); //I'm displaying the score with leading zeros
                                                                        //I'm checking if the score is exactly 0
        if (scoreString == "00000")
        {
            scoreText.enabled = true; //I'm ensuring the score text is always visible
        }

        scoreText.text = scoreString;
    }

    public float GetScore()
    {
        return score;
    }
}