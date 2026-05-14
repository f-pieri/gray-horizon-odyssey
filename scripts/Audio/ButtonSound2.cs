using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using YourNamespace1;

public class ButtonSound2 : MonoBehaviour
{
    public AudioSource soundPlayer1;
    private bool soundTriggered1 = true; //I added a variable to track sound triggering

    //I called the start function
    void Start()
    {
        //I initialized the soundTriggered variable to false at the start
        soundTriggered1 = false;
    }

    //I called the update function
    void Update()
    {
        //I'm checking if the sound has been triggered
        if (soundTriggered1)
        {
            //If the sound is not playing
            if (!soundPlayer1.isPlaying)
            {
                Debug.Log("Sound has been stopped.");
            }
            else
            {
                Debug.Log("Sound is still playing.");
            }
        }
    }

    public void playThisSoundEffect()
    {
        //GlobalVariables1.newCheckmark = !GlobalVariables1.newCheckmark; if this line inserted, audio button audio works, the actual button. this line has something to do with it (checkmark)
        if (GlobalVariables1.newCheckmark)
        {
            soundPlayer1.Play();
            Debug.Log("I work");
        }
        else
        {
            //If Checkmark = false
        }

        //I'm setting the soundTriggered variable to true when the sound is triggered
        soundTriggered1 = false;
        //soundPlayer1.Play();
        Debug.Log("Sound has been triggered.");
    }
}