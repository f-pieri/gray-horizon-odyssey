using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic1 : MonoBehaviour
{
    private static BackgroundMusic1 backgroundMusic1;
    private AudioSource audioSource;
    private bool isPaused = false;
    private bool isMuted = false; //Added a variable to track mute state

    private void Awake()
    {
            //I checked if there was already an instance of the background music
        if (backgroundMusic1 == null)
        {
            backgroundMusic1 = this;
            //I prevented this game object from being destroyed when a new scene was loaded
            DontDestroyOnLoad(backgroundMusic1);
        }
        else if (backgroundMusic1 != this)
        {   //I destroyed this script if another instance already existed
            Destroy(gameObject);
            return;
        }
            //I got the AudioSource component attached to this game object
        audioSource = GetComponent<AudioSource>();
            //I loaded the scene event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        if (scene.buildIndex == 0)
        {
            if (!audioSource.isPlaying)
            {
                PauseMusic();
                UnpauseMusic();
                PlayMusic();
            }
        }
        else if (scene.buildIndex > 0)
        {
            if (scene.name == "HomeScene") 
            {
                RestartMusicAndUnpause(); //Reset music when entering the home scene
            }
            else if (audioSource.isPlaying)
            {
                isPaused = true;
                audioSource.Pause();
                Debug.Log("Music paused for scene transition.");
            }
        }
    }


    public void PlayMusic()
    {
        if (!isMuted)
        {
            audioSource.Play();
            isPaused = false;
            Debug.Log("Music resumed.");
        }
    }

    public void PauseMusic()
    {
        if (!isPaused)
        {
            audioSource.Pause();
            isPaused = true;
            Debug.Log("Music paused.");
        }
    }

    public void UnpauseMusic()
    {
        /*if (isPaused)
        {
            audioSource.UnPause();
            isPaused = false;
            Debug.Log("Music unpaused.");
        }*/

        if (isPaused && audioSource.clip != null && !audioSource.isPlaying)
        {
            audioSource.UnPause();
            isPaused = false;
            Debug.Log("Music unpaused.");
        }
    }

    public void RestartMusicAndUnpause()
    {
        if (audioSource != null)
        {
            //audioSource.Stop();
            audioSource.Play();
            isPaused = false;
            Debug.Log("I am the culprit: BackgroundMusic1 script");
        }
    }

    public void ToggleMute(bool mute)
    {
        isMuted = mute;
        audioSource.mute = mute;
        Debug.Log("Music muted: " + mute);
    }

    public bool IsMuted()
    {
        return isMuted;
    }

    public void StopMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            Debug.Log("Background music stopped.");
        }
    }
}
