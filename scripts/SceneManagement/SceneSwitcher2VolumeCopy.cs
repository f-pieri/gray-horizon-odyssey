using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher2VolumeCopy : MonoBehaviour
{
    public AudioSource soundPlayer1;

    public void PlaySound()
    {
        if (soundPlayer1 != null)
        {
            soundPlayer1.volume = GlobalVolume.ButtonVolume; // Set the volume from the global variable
            soundPlayer1.Play();
        }
    }
}
