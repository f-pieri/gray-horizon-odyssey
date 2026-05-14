using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundPlayer : MonoBehaviour
{
    public AudioClip buttonClickSound; //I'm assigning button click sound in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
        //I'm getting the audioSource component
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayButtonClickSound()
    {
        //I'm declaring an if statement with a condition when button is clicked
        if (buttonClickSound != null)
        {
            audioSource.clip = buttonClickSound;
            audioSource.Play();
        }
    }
}
