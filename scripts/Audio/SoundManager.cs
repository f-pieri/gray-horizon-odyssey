using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;

    private AudioSource buttonSound; // Reference to the AudioSource for button sound
    private bool muted = false;

    void Start()
    {
        buttonSound = GetComponent<AudioSource>(); // Assign the AudioSource reference

        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }

        UpdateButtonIcon();
    }

    public void OnButtonPress()
    {
        muted = !muted; // Toggle mute state

        if (buttonSound != null)
        {
            buttonSound.volume = muted ? 0 : GlobalVolume.ButtonVolume; // Adjust the volume based on mute state
        }

        Save();
        UpdateButtonIcon();
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
        if (buttonSound != null)
        {
            buttonSound.volume = muted ? 0 : GlobalVolume.ButtonVolume; // Apply the loaded volume based on mute state
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
