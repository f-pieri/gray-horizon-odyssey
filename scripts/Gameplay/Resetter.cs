using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetter : MonoBehaviour
{
    public ButtonSound buttonSound; //I'm referencing my ButtonSound script
    public BackgroundMusic backgroundMusic; //I'm referencing my BackgroundMusic script

    //I'm calling this method/function when you want to reset the scene
    public void ResetSceneWithSound()
    {
        StartCoroutine(ResetSceneWithDelay());
    }

    //I'm using the Coroutine technique to play the button sound and then reset the scene within the same time 
    private IEnumerator ResetSceneWithDelay()
    {
        if (buttonSound != null)
        {
            //I'm playing the button sound
            buttonSound.playThisSoundEffect();

            //I'm waiting for the sound to finish playing (adjust the delay time if needed)
            yield return new WaitForSeconds(15f/*buttonSound.soundPlayer.clip.length*/);
        }

        //I'm resetting the background music
        if (backgroundMusic != null)
        {
            backgroundMusic.RestartMusicAndUnpause();
        }

        //I'm reloading the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
