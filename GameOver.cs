using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Button restartButton; //I'm referencing the restart button
    private LoopingBackground loopingBackground;
    private StopParticlesOnGameOver stopParticlesScript;
    private CameraMovement cameraMovement;
    private BackgroundMusic backgroundMusic;
    private HighScoreManager highScoreManager; //I'm referencing the HighScoreManager script
    private ScoreManager scoreManager; //I'm referencing the ScoreManager script

    private bool isMusicPausedOnDeath = false;
    private PauseMenu pauseMenuScript;

    void Start()
    {
        loopingBackground = FindObjectOfType<LoopingBackground>();
        stopParticlesScript = FindObjectOfType<StopParticlesOnGameOver>();
        cameraMovement = FindObjectOfType<CameraMovement>();
        backgroundMusic = FindObjectOfType<BackgroundMusic>();
        pauseMenuScript = FindObjectOfType<PauseMenu>();
        highScoreManager = FindObjectOfType<HighScoreManager>(); 
        scoreManager = FindObjectOfType<ScoreManager>();

        backgroundMusic.PlayMusic();

    }

    void Update()
    {
        if (GlobalSubstance.obstacleTriggered) 
        {   Debug.Log("TRIED");
            gameOverPanel.SetActive(true);
            loopingBackground.StopBackgroundLooping();

            if (stopParticlesScript != null)
            {
                stopParticlesScript.StopParticles();
            }

            cameraMovement.StopCamera();

            if (!isMusicPausedOnDeath)
            {
                backgroundMusic.PauseMusic();
                isMusicPausedOnDeath = true;
                //pauseMenuScript.SetAccessToPauseMenu(false);
            }

            //I'm updating the high score when the player dies
            highScoreManager.UpdateHighScore(scoreManager.GetScore());
        }
    }

    public void Restart()
    {
        GlobalSubstance.obstacleTriggered = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        cameraMovement.ResumeCamera();

        backgroundMusic.RestartMusicAndUnpause();
        isMusicPausedOnDeath = false;
       //pauseMenuScript.SetAccessToPauseMenu(true);
    }
}
