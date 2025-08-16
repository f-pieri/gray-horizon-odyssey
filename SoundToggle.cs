using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YourNamespace
{
    public static class GlobalVariables
    {
        public static bool Checkmark = false;
    }
}

namespace YourNamespace1
{
    public static class GlobalVariables1
    {
        public static bool newCheckmark = true;
    }
}

public class SoundToggle : MonoBehaviour
{
    public GameObject buttonSound; //I'm referencing the ButtonSound GameObject
    public GameObject newbuttonSound; //I'm referencing the ButtonSound GameObject

    private void Start()
    {
        //I'm ensuring the sound is initially enabled
        EnableSound();
        EnableSound1(); 
    }

    //I'm making it so that this method/function will be called when the button is pressed
    public void ToggleSound()
    {
        if (buttonSound != null)
        {
            if (buttonSound.activeSelf)
            {
                //I'm adding the condition that when the sound is enabled, disable it
                DisableSound();
                YourNamespace.GlobalVariables.Checkmark = false; //I'm coreccting the access
            }
            else
            {
                //I'm adding the condition that when the sound is disabled, enable it
                EnableSound();
                YourNamespace.GlobalVariables.Checkmark = true; //I'm coreccting the access
            }
        }

        if (newbuttonSound != null)
        {
            if (newbuttonSound.activeSelf)
            {
                //I'm adding the condition that when the sound is enabled, disable it
                DisableSound1();
                YourNamespace1.GlobalVariables1.newCheckmark = false; //I'm coreccting the access
            }
            else
            {
                //I'm adding the condition that when the sound is disabled, enable it
                EnableSound1();
                YourNamespace1.GlobalVariables1.newCheckmark = true; //I'm coreccting the access
            }
        }
    }

    private void EnableSound()
    {
        if (buttonSound != null)
        {
            buttonSound.SetActive(true);
            YourNamespace.GlobalVariables.Checkmark = true; //I'm coreccting the access
        }
    }

    private void EnableSound1()
    {
        if (newbuttonSound != null)
        {
            newbuttonSound.SetActive(true);
            YourNamespace1.GlobalVariables1.newCheckmark = true; //I'm coreccting the access
        }
    }

    private void DisableSound()
    {
        if (buttonSound != null)
        {
            buttonSound.SetActive(false);
            YourNamespace.GlobalVariables.Checkmark = false; //I'm coreccting the access
        }
    }

    private void DisableSound1()
    {
        if (newbuttonSound != null)
        {
            newbuttonSound.SetActive(false);
            YourNamespace1.GlobalVariables1.newCheckmark = false; //I'm coreccting the access
        }
    }
}