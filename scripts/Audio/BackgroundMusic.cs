using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;
    private AudioSource audioSource;
    private bool isPaused = false;
    private bool isMuted = false; //I added a variable to track mute state

    private void Awake()
    {
            //I checked if there was already an instance of the background music
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            //I prevented this game object from being destroyed when a new scene was loaded
            DontDestroyOnLoad(backgroundMusic);
        }
        else if (backgroundMusic != this)
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
        {   //I got the AudioSource component again in case it wasn't assigned
            audioSource = GetComponent<AudioSource>();
        }
           //I checked if the loaded scene was the first scene (index 0)
        if (scene.buildIndex == 0)
        {
            StopMusic();
            Debug.Log("I am the culprit: Build Index0");
        }
        else if (scene.buildIndex == 2)
        {
            StopMusic();
            Debug.Log("I am the culprit: Build Index2");
        }
        else
        {
            PlayMusic();
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
        if (isPaused)
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
            //audioSource.Stop(); I commented this code 12/29 maybe uncomment if things start working wrong.
            audioSource.Play();
            isPaused = false;
            Debug.Log("I am the culprit: Audio Source Not Null");
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