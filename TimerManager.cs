using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Text scoreText;
    private float score = 0f;
    private int displayedScore = 0;

    //I'm calling the update function
    void Update()
    {
        if (!GlobalSubstance.obstacleTriggered) 
        {
            //I'm increasing the score continuously based on the time passed
            score += Time.deltaTime;

            //I'm updating the displayed score with leading zeros
            displayedScore = Mathf.FloorToInt(score);

            //I'm updating the score text display with leading zeros
            scoreText.text = displayedScore.ToString("D5");
        }
    }
}
