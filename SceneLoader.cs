using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public AudioSource soundPlayer1;
    public string sceneNameToLoad = "9999";
    public float sceneSwitchDelay = 5.0f; // Set the delay to 5 seconds

    public void PlaySoundAndSwitchScene()
    {
        if (soundPlayer1 != null)
        {
            soundPlayer1.volume = GlobalVolume.ButtonVolume; // Set the volume from the global variable
            soundPlayer1.Play();
            // Delay the scene switch by 5 seconds after the sound starts playing
            Invoke("SwitchScene", sceneSwitchDelay);
        }
        else
        {
            SwitchScene(); // If there's no sound, switch the scene immediately
        }
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}