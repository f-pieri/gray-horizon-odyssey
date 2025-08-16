using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public AudioSource soundPlayer1;
    public string sceneToLoad = "Selector";
    public float soundDuration = 0.15f;

    public void PlaySoundAndSwitchScene()
    {
        if (soundPlayer1 != null)
        {
            soundPlayer1.Play();
            Invoke("KillSoundAndSwitchScene", soundDuration);
            Debug.Log("///////Sound is still playing.///////");
        }
        else
        {
            Debug.LogWarning("////////No sound assigned. Switching scene immediately.///////");
            SwitchScene();
        }
    }

    void KillSoundAndSwitchScene()
    {
        if (soundPlayer1 != null && soundPlayer1.isPlaying)
        {
            soundPlayer1.Stop(); // Stop playing the sound
            soundPlayer1.enabled = false; // Disable the audio source
            Debug.Log("///////Sound has been disabled.///////");
        }
        SwitchScene();
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("//////Scene has been switched.//////");
    }
}