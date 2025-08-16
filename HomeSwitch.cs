using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeSwitch : MonoBehaviour
{
    public Button homeButton; //I'm referencing the restart button
    private LoopingBackground loopingBackground;
    private CameraMovement cameraMovement;
    private HighScoreManager highScoreManager; //I'm referencing the HighScoreManager script
    private ScoreManager scoreManager; //I'm referencing the ScoreManager script

    // Start is called before the first frame update
    void Start()
    {
        loopingBackground = FindObjectOfType<LoopingBackground>();
        cameraMovement = FindObjectOfType<CameraMovement>();
        highScoreManager = FindObjectOfType<HighScoreManager>(); //I'm finding the HighScoreManager script
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalSubstance.obstacleTriggered)
        {
            Debug.Log("TRIED");
            loopingBackground.StopBackgroundLooping();

            cameraMovement.StopCamera();

            //I'm updating the high score when the player dies
            highScoreManager.UpdateHighScore(scoreManager.GetScore());
        }
    }

    public void Restart()
    {
        GlobalSubstance.obstacleTriggered = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //cameraMovement.ResumeCamera();
        // pauseMenuScript.SetAccessToPauseMenu(true);
    }
}
