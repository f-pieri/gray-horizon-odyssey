using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //MUSIC

public class SoundManager1 : MonoBehaviour
{
    [SerializeField] Image soundOnIcon; //I'm using serialized fields to constantly update sound on/off icons
    [SerializeField] Image soundOffIcon; //I'm using serialized fields to constantly update sound on/off icons
    private bool muted1 = false;

    private void Start()
    {
        Load(); //I'm loading the mute state from PlayerPrefs
        UpdateButtonIcon();

        //I'm finding/creating (if I cant find anything) the BackgroundMusic object
        BackgroundMusic backgroundMusic = FindObjectOfType<BackgroundMusic>();
        if (backgroundMusic == null)
        {
            //I'm creeating a new GameObject with BackgroundMusic component
            GameObject backgroundMusicObject = new GameObject("BackgroundMusic");
            backgroundMusic = backgroundMusicObject.AddComponent<BackgroundMusic>();
            DontDestroyOnLoad(backgroundMusicObject);
        }

        //I'm setting the mute state of the background music
        backgroundMusic.ToggleMute(muted1);
    }

    public void OnButtonPress()
    {
        muted1 = !muted1; //I'm toggling the mute state
        Save(); //I'm saving the mute state to PlayerPrefs
        UpdateButtonIcon();

        //I'm finding/creating (if I cant find anything) the BackgroundMusic object
        BackgroundMusic backgroundMusic = FindObjectOfType<BackgroundMusic>();
        if (backgroundMusic != null)
        {
            //I'm toggling the mute state of the background music
            backgroundMusic.ToggleMute(muted1);
        }
    }

    private void UpdateButtonIcon()
    {
        if (muted1 == false)
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
        muted1 = PlayerPrefs.GetInt("muted1") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted1", muted1 ? 1 : 0);
        PlayerPrefs.Save(); //I'm saving the PlayerPrefs data immediately
    }
}
