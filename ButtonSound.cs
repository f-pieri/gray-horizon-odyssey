using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using YourNamespace;

public class ButtonSound : MonoBehaviour
{
    public AudioSource soundPlayer;
    private bool soundTriggered = true; //I added a variable to track sound triggering

    //I called the start function
    void Start()
    {
        //I initialized the soundTriggered variable to false at the start
        soundTriggered = true;
    }

    //I called the update function
    void Update()
    {
        //I'm checking if the sound has been triggered
        if (soundTriggered)
        {
            //If the sound is not playing
            if (!soundPlayer.isPlaying)
            {
                //Debug.Log("Sound has been stopped.");
            }
            else
            {
                Debug.Log("Sound is still playing.");
            }
        }
    }

    public void playThisSoundEffect()
    {
        if (GlobalVariables.Checkmark)
        {
            soundPlayer.Play();
        }
        else
        {
            //If Checkmark = false
        }

        //I'm setting the soundTriggered variable to true when the sound is triggered
        soundTriggered = false;
        Debug.Log("Sound has been triggered.");
    }
}