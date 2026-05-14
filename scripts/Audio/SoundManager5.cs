using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager5 : MonoBehaviour
{
    [SerializeField] Image soundOnIcon; //I'm using serialized fields to constantly update sound on/off icons
    [SerializeField] Image soundOffIcon; //I'm using serialized fields to constantly update sound on/off icons
    private bool muted = false;

    private void Start()
    {
        Load(); //I'm loading the mute state from PlayerPrefs
        UpdateButtonIcon();

        //I'm finding/creating (if I cant find anything) the BackgroundMusic object
        BackgroundMusic1 backgroundMusic = FindObjectOfType<BackgroundMusic1>();
        if (backgroundMusic == null)
        {
            //I'm creeating a new GameObject with BackgroundMusic component
            GameObject backgroundMusicObject = new GameObject("BackgroundMusic1");
            backgroundMusic = backgroundMusicObject.AddComponent<BackgroundMusic1>();
            DontDestroyOnLoad(backgroundMusicObject);
        }

        //I'm setting the mute state of the background music
        backgroundMusic.ToggleMute(muted);
    }

    public void OnButtonPress()
    {
        muted = !muted; //I'm toggling the mute state
        Save(); //I'm saving the mute state to PlayerPrefs
        UpdateButtonIcon();

        //I'm finding/creating (if I cant find anything) the BackgroundMusic object
        BackgroundMusic1 backgroundMusic = FindObjectOfType<BackgroundMusic1>();
        if (backgroundMusic != null)
        {
            //I'm toggling the mute state of the background music
            backgroundMusic.ToggleMute(muted);
        }
    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
        PlayerPrefs.Save(); //I'm saving the PlayerPrefs data immediately
    }
}
