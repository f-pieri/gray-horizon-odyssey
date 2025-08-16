using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    private BackgroundMusic backgroundMusic; 
    private GameOver gameOverScript; //I'm adding a reference to gameover script
    private bool canAccessPauseMenu = false; //I'm initially allow access to the pause menu

    private void Start()
    {
        Time.timeScale = 1f;
        canAccessPauseMenu = true;
        pauseMenu.SetActive(false);
        backgroundMusic = FindObjectOfType<BackgroundMusic>(); 
        gameOverScript = FindObjectOfType<GameOver>(); //I'm finding the GameOver script
    }

    public void Pause()
    {
        if (canAccessPauseMenu) //I'm checking if the player can access the pause menu
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            backgroundMusic.PauseMusic(); //I'm pausing the music FRANCO DID THIS
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        backgroundMusic.UnpauseMusic(); //I'm unpausing the music FRANCO DID THIS
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    //I'm declaring a function with a condition allowing for pause menu to be accessed through bool state variable
    public void SetAccessToPauseMenu(bool state)
    {
        canAccessPauseMenu = state;
    }
}
